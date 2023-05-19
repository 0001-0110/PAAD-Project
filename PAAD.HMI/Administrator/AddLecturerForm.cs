using InversionOfControl;
using Microsoft.VisualBasic.Devices;
using PAAD.BLL.Services;
using PAAD.BLL.Utilities;
using PAAD.DAL.Models;
using System.Security.Cryptography;

namespace PAAD.HMI.Administrator
{
	public partial class AddLecturerForm : Form
	{
		private readonly IDependencyInjector _injector;
		private readonly IDataService _dataService;
		private readonly HashAlgorithm _hashAlgorithm;
		private DAL.Models.Lecturer _lecturer = null;
		public AddLecturerForm(IDependencyInjector injector, IDataService dataService, HashAlgorithm hashAlgorithm, string action)
		{
			_injector = injector;
			_dataService = dataService;
			_hashAlgorithm = hashAlgorithm;
			InitializeComponent();
			UpdateAction(action);
		}

		public AddLecturerForm(IDependencyInjector injector, IDataService dataService, HashAlgorithm hashAlgorithm, string action, DAL.Models.Lecturer lecturer) : this(injector, dataService, hashAlgorithm, action)
		{
			_lecturer = lecturer;
		}

		private void UpdateAction(string action)
		{
			lbTitle.Text = $"{action} lecturer";
		}

		public DAL.Models.Lecturer GetData()
		{
			var lecturer = _injector.Instantiate<DAL.Models.Lecturer>()!;

			lecturer.FirstName = tbFirstName.Text;
			lecturer.LastName = tbLastName.Text;
			lecturer.CourseId = ((Course)cbCourses.SelectedItem).Id;
			lecturer.Email = tbEmail.Text;
			lecturer.PasswordHash = SecurityUtility.GetHash(tbPassword.Text, _hashAlgorithm);

			return lecturer;
		}

		private void AddLecturerForm_Load(object sender, EventArgs e)
		{
			try
			{
				IEnumerable<Course> courses = _dataService.GetAll<Course>();
				foreach (Course course in courses)
				{
					cbCourses.Items.Add(course);
				}

				if (_lecturer != null)
					SetData(_lecturer);
				else
					cbCourses.SelectedIndex = 0;


			}
			catch (Exception ex)
			{
				Utils.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (tbFirstName.Text == "" || tbLastName.Text == "" || tbEmail.Text == "" || tbPassword.Text == "")
				Utils.ShowError("One or more fields are empty. Please fill all of them.");
			else
				DialogResult = DialogResult.OK;
		}

		public void SetData(DAL.Models.Lecturer lecturer)
		{
			tbFirstName.Text = lecturer.FirstName;
			tbLastName.Text = lecturer.LastName;
			tbEmail.Text = lecturer.Email;

			List<Course> courses = _dataService.GetAll<Course>().ToList();
			courses.Sort((c1, c2) => string.Compare(c1.ToString(), c2.ToString()));

			cbCourses.SelectedIndex = courses.IndexOf(courses.FirstOrDefault(c => c.Id == lecturer.CourseId)!);
			
		}
	}
}
