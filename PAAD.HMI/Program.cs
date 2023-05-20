using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.DAL.DatabaseContext;
using PAAD.DAL.Models;
using PAAD.DAL.Repositories;
using PAAD.HMI.Administrator;
using PAAD.HMI.Common;
using PAAD.HMI.Lecturer;
using System.Security.Cryptography;

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
            // Here is where you map your dependencies
            // Don't forget to add them bottom up (the ones with no dependencies first)
            // The first argument should be the type you use in your constructor
            // The second argument should be inheriting of the first argument
            DependencyInjector injector = new DependencyInjector()
                .MapSingleton<AufgepasstDbContext, AufgepasstDbContext>()
                .MapSingleton<IRepository<Notification>, NotificationRepository>()
                //.Map<IRepository<Student>, StudentRepository>()
                .MapSingleton<IRepository<Lecturer>, LecturerRepository>()
                .MapSingleton<IRepository<Administrator>, AdministratorRepository>()
                .MapSingleton<IRepository<Course>, CourseRepository>()
                .Map<IRepositoryCollection, RepositoryCollection>()
                .Map<IDataService, DataService>()
                .MapSingleton<HashAlgorithm, SHA256>(SHA256.Create())
                .MapSingleton<IAuthenticationService, AuthenticationService>();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //To be able to logout and do all the process again
            Restart(injector);
        }

        public static void Restart(IDependencyInjector injector)
        {
			LoginForm loginForm = injector.Instantiate<LoginForm>()!;
			Application.Run(loginForm);

           

			if (loginForm.CurrentUser != null)
			{
				Application.Run(injector.Instantiate<CommonForm>());
                    
                Restart(injector);
            }
		}
    }
}
