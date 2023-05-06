using PAAD.HMI;
using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.Repositories;
using PAAD.DAL.Models;
using PAAD.DAL.DatabaseContext;

namespace PAAD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DependencyInjector injector = new DependencyInjector()
                .Map<IDataService, DataService>()
                .Map<IRepositoryCollection, RepositoryCollection>()
                .Map<IRepository<Notification>, NotificationRepository>()
                //.Map<IRepository<Student>, StudentRepository>()
                .Map<IRepository<Lecturer>, LecturerRepository>()
                .Map<IRepository<Administrator>, AdministratorRepository>()
                .Map<IRepository<Course>, CourseRepository>()
                // TODO Add interface
                .Map<AufgepasstDbContext, AufgepasstDbContext>();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run((Form1)injector.Instantiate(typeof(Form1)));
        }
    }
}
