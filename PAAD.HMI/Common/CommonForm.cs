using InversionOfControl;
using PAAD.BLL.Services;
using PAAD.HMI.Administrator;
using PAAD.HMI.Lecturer;

namespace PAAD.HMI.Common
{
    public partial class CommonForm : Form
    {
        private IAuthenticationService _authenticationService;
        private IDependencyInjector _injector;

        public CommonForm(IDependencyInjector injector, IAuthenticationService authenticationService)
        {
            _injector = injector;
            _authenticationService = authenticationService;
            InitializeComponent();
            DisplayInitialView();
        }

        private void DisplayInitialView()
        {
            UserControl userControl;
            if (_authenticationService.CurrentUser is DAL.Models.Administrator)
                userControl = _injector.Instantiate<AdminHomeUC>()!;
            else
                userControl = _injector.Instantiate<LecturerViewNotifsUC>()!;

            userControl.Dock = DockStyle.Fill;
            Controls.Add(userControl);
        }
    }
}
