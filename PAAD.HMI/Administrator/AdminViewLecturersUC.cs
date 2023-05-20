using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Common;

namespace PAAD.HMI.Administrator
{
	public partial class AdminViewLecturersUC : UserControl
	{
		private readonly IDataService _dataService;
		private readonly IDependencyInjector _injector;
		private readonly IAuthenticationService _authenticationService;

		private const string EDIT = "Edit";
		private const string DELETE = "Delete";
		public AdminViewLecturersUC(IAuthenticationService authenticationService, IDependencyInjector injector, IDataService dataService)
		{
			InitializeComponent();
			_authenticationService = authenticationService;
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

			try
			{
				Course course;
				IEnumerable<DAL.Models.Lecturer> lecturers = _dataService.GetAll<DAL.Models.Lecturer>();
				foreach (var lecturer in lecturers)
				{
					course = _dataService.GetById<Course>((int)lecturer.CourseId!)!;
					dataGridView_Lecturer.Rows.Add($"{lecturer.FirstName} {lecturer.LastName}", course.Name, EDIT, DELETE);
				}
			}
			catch (Exception ex)
			{
				Utils.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}

		private void btnAddLecturer_Click(object sender, EventArgs e)
		{
			AddLecturerForm addLecturerForm = _injector.Instantiate<AddLecturerForm>("Add")!;
			if (addLecturerForm.ShowDialog() == DialogResult.OK)
			{
				var lecturer = addLecturerForm.GetData();
				var course = _dataService.GetById<Course>((int)lecturer.CourseId!)!;

				//save into database
				_dataService.Create<DAL.Models.Lecturer>(lecturer);

				//adds in the table
				dataGridView_Lecturer.Rows.Add($"{lecturer.FirstName} {lecturer.LastName}", course.Name, EDIT, DELETE);

			}
		}


		private void btnBack_Click(object sender, EventArgs e)
		{
			try
			{
				AdminHomeUC adminHomeUC = _injector.Instantiate<AdminHomeUC>()!;

				adminHomeUC.Dock = DockStyle.Fill;

				Parent.Controls.Add(adminHomeUC);
				Parent.Controls.Remove(this);

				this.Dispose();
			}
			catch (Exception ex)
			{
				Utils.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}

		private void dataGridView_Lecturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;

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
				var senderGrid = (DataGridView)sender;

				var row = senderGrid.SelectedRows[0];

				var lecturer = _dataService.GetAll<DAL.Models.Lecturer>().FirstOrDefault(l => $"{l.FirstName} {l.LastName}" == row.Cells[0].Value.ToString())!;
				var id = lecturer.Id;

				//delete row
				dataGridView_Lecturer.Rows.Remove(row);

				//delete in the database
				_dataService.Delete<DAL.Models.Lecturer>(id);
			}
			catch (Exception ex)
			{
				Utils.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}

		private void Edit_Click(object sender, DataGridViewCellEventArgs e)
		{

			try
			{
				var senderGrid = (DataGridView)sender;

				var row = senderGrid.SelectedRows[0]; //we know there is only one max

				var lecturer = _dataService.GetAll<DAL.Models.Lecturer>().FirstOrDefault(l => $"{l.FirstName} {l.LastName}" == row.Cells[0].Value.ToString())!;
				var id = lecturer.Id;

				AddLecturerForm addLecturerForm = _injector.Instantiate<AddLecturerForm>("Edit", lecturer)!;

				if (addLecturerForm.ShowDialog() == DialogResult.OK)
				{
					lecturer = addLecturerForm.GetData();

					//update database
					_dataService.Edit<DAL.Models.Lecturer>(id, lecturer);

					//update table
					row.Cells[0].Value = $"{lecturer.FirstName} {lecturer.LastName}";
					row.Cells[1].Value = _dataService.GetById<Course>((int)lecturer.CourseId!);
				}

			}
			catch (Exception ex)
			{
				Utils.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}
	}
}
