using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Common;
using PAAD.HMI.Utilities;

namespace PAAD.HMI.Administrator
{
	public partial class AdminViewLecturersUC : UserControl
	{
		private readonly IDataService _dataService;
		private readonly IDependencyInjector _injector;

		private const string EDIT = "Edit";
		private const string DELETE = "Delete";

		public AdminViewLecturersUC(IDependencyInjector injector, IDataService dataService)
		{
			InitializeComponent();
			_injector = injector;
			_dataService = dataService;

			AddHeader();
		}

		private void AddHeader()
		{
			HeaderUC headerUC = _injector.Instantiate<HeaderUC>()!;
			headerUC.Dock = DockStyle.Top;
			Controls.Add(headerUC);
		}

		private void AdminViewLecturersUC_Load(object sender, EventArgs e)
		{
			string courseName;
			IEnumerable<DAL.Models.Lecturer> lecturers = _dataService.GetAll<DAL.Models.Lecturer>();
			foreach (DAL.Models.Lecturer lecturer in lecturers)
			{
				if (lecturer.CourseId != null)
					courseName = _dataService.GetById<Course>((int)lecturer.CourseId)!.Name;
				else
					courseName = "";
				dataGridView_Lecturer.Rows.Add($"{lecturer.FirstName} {lecturer.LastName}", courseName, EDIT, DELETE);
			}
		}

		private void btnAddLecturer_Click(object sender, EventArgs e)
		{
			AddLecturerForm addLecturerForm = _injector.Instantiate<AddLecturerForm>("Add")!;
			if (addLecturerForm.ShowDialog() == DialogResult.OK)
			{
				DAL.Models.Lecturer lecturer = addLecturerForm.GetData();
				Course course = _dataService.GetById<Course>((int)lecturer.CourseId!)!;

				//save into database
				_dataService.Create<DAL.Models.Lecturer>(lecturer);

				//adds in the table
				dataGridView_Lecturer.Rows.Add($"{lecturer.FirstName} {lecturer.LastName}", course.Name, EDIT, DELETE);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			AdminHomeUC adminHomeUC = _injector.Instantiate<AdminHomeUC>()!;

			adminHomeUC.Dock = DockStyle.Fill;

			Parent.Controls.Add(adminHomeUC);
			Parent.Controls.Remove(this);

			Dispose();
		}

		private void dataGridView_Lecturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView senderGrid = (DataGridView)sender;

			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
				e.RowIndex >= 0)
			{
				if (e.ColumnIndex == 2)
					Edit_Click(sender, e);
				else
					Delete_Click(sender, e);
			}
		}

		private void Delete_Click(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				ConfirmationForm form = _injector.Instantiate<ConfirmationForm>()!;
				if (form.ShowDialog() == DialogResult.OK)
				{
					DataGridView senderGrid = (DataGridView)sender;

					DataGridViewRow row = senderGrid.SelectedRows[0];

					DAL.Models.Lecturer lecturer = _dataService.GetAll<DAL.Models.Lecturer>().FirstOrDefault(l => $"{l.FirstName} {l.LastName}" == row.Cells[0].Value.ToString())!;
					int id = lecturer.Id;

					//delete in the database
					_dataService.Delete<DAL.Models.Lecturer>(id);

					//delete row
					dataGridView_Lecturer.Rows.Remove(row);
				}
			}
			catch (Exception ex) // Can happens if you delete a lecturer with notifications
			{
				MessageBoxUtility.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}

		private void Edit_Click(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView senderGrid = (DataGridView)sender;

				DataGridViewRow row = senderGrid.SelectedRows[0]; //we know there is only one max

				DAL.Models.Lecturer dbLecturer = _dataService.GetAll<DAL.Models.Lecturer>().FirstOrDefault(l => $"{l.FirstName} {l.LastName}" == row.Cells[0].Value.ToString())!;
				int id = dbLecturer.Id;

				AddLecturerForm addLecturerForm = _injector.Instantiate<AddLecturerForm>("Edit", dbLecturer)!;

				if (addLecturerForm.ShowDialog() == DialogResult.OK)
				{
					DAL.Models.Lecturer lecturer = addLecturerForm.GetData();

					//update database
					_dataService.Edit<DAL.Models.Lecturer>(id, lecturer);

					lecturer = _dataService.GetAll<DAL.Models.Lecturer>()!.Single(l => $"{l.FirstName} {l.LastName}" == $"{lecturer.FirstName} {lecturer.LastName}");

					//update table
					row.Cells[0].Value = $"{lecturer.FirstName} {lecturer.LastName}";
					row.Cells[1].Value = _dataService.GetById<Course>((int)lecturer.CourseId!);
				}

			}
			catch (Exception ex)
			{
				MessageBoxUtility.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}
	}
}
