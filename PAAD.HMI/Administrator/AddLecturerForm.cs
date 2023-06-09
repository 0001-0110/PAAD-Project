using InversionOfControl;
using Microsoft.IdentityModel.Tokens;
using PAAD.BLL.Services;
using PAAD.BLL.Utilities;
using PAAD.DAL.Models;
using PAAD.HMI.Extensions;
using PAAD.HMI.Utilities;
using System.Security.Cryptography;

namespace PAAD.HMI.Administrator
{
    public partial class AddLecturerForm : Form
    {
        private const int PASSWORDMINLENGTH = 6;

        private readonly IDependencyInjector _injector;
        private readonly IDataService _dataService;
        private readonly HashAlgorithm _hashAlgorithm;
        private DAL.Models.Lecturer? dbLecturer = null;

        public AddLecturerForm(IDependencyInjector injector, IDataService dataService, HashAlgorithm hashAlgorithm, string action)
        {
            _injector = injector;
            _dataService = dataService;
            _hashAlgorithm = hashAlgorithm;
            InitializeComponent();
            UpdateAction(action);

            tbFirstName.SetValidator(textBox => !textBox.Text.IsNullOrEmpty(), "You must enter a first name");
            tbLastName.SetValidator(textBox => !textBox.Text.IsNullOrEmpty(), "You must enter a last name");
            tbEmail.SetValidator(textBox => EmailUtility.IsValidEmail(textBox.Text), "This is not a valid email address");
            // If the lecturer is already set and the password has not been modified, no need to check for its new length
            tbPassword.SetValidator(textBox => (dbLecturer != null && textBox.Text.IsNullOrEmpty()) || textBox.Text.Length >= PASSWORDMINLENGTH, $"Your password must be at least {PASSWORDMINLENGTH} characters long");
            // Check that something is selected (just in case)
            cbCourses.SetValidator(comboBox => comboBox.SelectedIndex >= 0, "You need to select a course");
        }

        public AddLecturerForm(IDependencyInjector injector, IDataService dataService, HashAlgorithm hashAlgorithm, string action, DAL.Models.Lecturer lecturer) : this(injector, dataService, hashAlgorithm, action)
        {
            dbLecturer = lecturer;
        }

        private void AddLecturerForm_Load(object sender, EventArgs e)
        {
            IEnumerable<Course> courses = _dataService.GetAll<Course>();
            foreach (Course course in courses)
                cbCourses.Items.Add(course);

            if (dbLecturer != null)
                SetData(dbLecturer);
            else
                cbCourses.SelectedIndex = 0;
        }

        private void UpdateAction(string action)
        {
            lbTitle.Text = $"{action} lecturer";
        }

        // Used to retrieve infos from the AdminViewLecturer
        public DAL.Models.Lecturer GetData()
        {
            if (dbLecturer == null)
                dbLecturer = _injector.Instantiate<DAL.Models.Lecturer>()!;
            dbLecturer.FirstName = tbFirstName.Text;
            dbLecturer.LastName = tbLastName.Text;
            dbLecturer.CourseId = ((Course)cbCourses.SelectedItem).Id;
            dbLecturer.Course = (Course)cbCourses.SelectedItem;
            dbLecturer.Email = tbEmail.Text;
            // Add a lecturer with empty password manage in submit button
            if (tbPassword.Text != "")
                dbLecturer.PasswordHash = SecurityUtility.GetHash(tbPassword.Text, _hashAlgorithm);

            return dbLecturer;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!this.IsFormValid())
                return;

            DialogResult = DialogResult.OK;
        }

        public void SetData(DAL.Models.Lecturer lecturer)
        {
            tbFirstName.Text = lecturer.FirstName;
            tbLastName.Text = lecturer.LastName;
            tbEmail.Text = lecturer.Email;
            tbPassword.Text = "";

            List<Course> courses = _dataService.GetAll<Course>().ToList();
            courses.Sort((c1, c2) => string.Compare(c1.ToString(), c2.ToString()));

            cbCourses.SelectedIndex = courses.IndexOf(courses.FirstOrDefault(c => c.Id == lecturer.CourseId)!);
        }

        private void AddLecturerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DisposeValidators();
        }
    }
}
