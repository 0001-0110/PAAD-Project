﻿using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Models;
using PAAD.HMI.Common;

namespace PAAD.HMI.Administrator
{
	public partial class AdminViewCoursesUC : UserControl
	{
		IAuthenticationService _authenticationService;
		private IDataService _dataService;
		private IDependencyInjector _injector;
		private const string EDIT = "Edit";
		private const string DELETE = "Delete";
		public AdminViewCoursesUC(IDependencyInjector injector, IDataService dataService, IAuthenticationService authenticationService)
		{
			_injector = injector;
			_dataService = dataService;
			InitializeComponent();
			_authenticationService = authenticationService;
			AddHeader();
		}

		private void AddHeader()
		{
			HeaderUC headerUC = _injector.Instantiate<HeaderUC>()!;
			headerUC.Dock = DockStyle.Top;
			Controls.Add(headerUC);
		}

		private void AdminViewCoursesUC_Load(object sender, EventArgs e)
		{
			try
			{
				IEnumerable<Course> courses = _dataService.GetAll<Course>();
				foreach (Course course in courses)
				{
					dgvCourses.Rows.Add(course.Name, EDIT, DELETE);
				}
			}
			catch (Exception ex)
			{
				Utils.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			try
			{
				var senderGrid = (DataGridView)sender;

				var row = senderGrid.SelectedRows[0]; //we know there is only one max
				if (row == null)
					return;

				ConfirmationForm form = _injector.Instantiate<ConfirmationForm>()!;
				if (form.ShowDialog() == DialogResult.OK)
				{
					string initialName = (string)row.Cells[0].Value;

					//Delete the row and the database
					var course = _dataService.GetAll<Course>().FirstOrDefault(c => c.Name == initialName);
					dgvCourses.Rows.Remove(row);

					if (course != null)
					{
						_dataService.Delete<Course>(course.Id);
					}
					else //you're not supposed to get there
						throw new Exception("unknown course");
				}
			}
			catch (Exception ex)
			{
				Utils.ShowError(ex.Message);
				Environment.Exit(1);
			}
		}

		private void Edit_Click(object sender, EventArgs e)
		{
			try
			{
				var senderGrid = (DataGridView)sender;

				var row = senderGrid.SelectedRows[0]; //we know there is only one max

				string initialName = (string)row.Cells[0].Value;
				AddCourseForm form = _injector.Instantiate<AddCourseForm>("Edit")!;
				form.SetName(initialName);
				if (form.ShowDialog() == DialogResult.OK)
				{
					
					string newName = form.GetName();

					//Edit the row and the database
					row.Cells[0].Value = newName;
					var course = _dataService.GetAll<Course>().FirstOrDefault(c => c.Name == initialName);

					if (course != null)
					{
						course.Name = newName;

						_dataService.Edit<Course>(course.Id, course);
					}
					else //you're not supposed to get there
						throw new Exception("unknown course");
				}
			}
			catch (Exception ex)
			{
				Utils.ShowError(ex.Message);
				Environment.Exit(1);
			}

		}

		//Handle click on buttons
		private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;

			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
				e.RowIndex >= 0)
			{
				if (e.ColumnIndex == 1)
					Edit_Click(sender, e);
				else
					Delete_Click(sender, e);
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

		private void btnAddCourse_Click(object sender, EventArgs e)
		{
			try
			{
				AddCourseForm addCourseForm = _injector.Instantiate<AddCourseForm>("Add")!;

				if (addCourseForm.ShowDialog() == DialogResult.OK)
				{
					Course course = _injector.Instantiate<Course>()!;

					course.Name = addCourseForm.GetName();

					//add in the database
					_dataService.Create<Course>(course);

					//add in the grid
					dgvCourses.Rows.Add(course.Name, EDIT, DELETE);
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
