using InversionOfControl;
using PAAD.BLL.Services;

namespace PAAD.HMI.Common
{
	public partial class LoginForm : Form
	{
		private IDependencyInjector injector;
		private IAuthenticationService authenticationService;
		private Form? homeForm;

		public LoginForm(IDependencyInjector injector, IAuthenticationService authenticationService)
		{
			this.injector = injector;
			this.authenticationService = authenticationService;
			authenticationService.OnLogOut += ShowLogin;
			InitializeComponent();
		}

		private void ShowLogin()
		{
			homeForm!.FormClosed -= OnClose;
			lbError.Hide();
			tbEmail.Text = string.Empty;
			tbPassword.Text = string.Empty;
			Show();
		}

		private void OnClose(object? sender, FormClosedEventArgs args)
		{
			Close();
		}

		private void btnSubmitLogin_Click(object sender, EventArgs e)
		{
			if (!authenticationService.TryAuthenticate(tbEmail.Text, tbPassword.Text))
			{
				lbError.Show();
				return;
			}

			Hide();
			// Show the main form
			homeForm = injector.Instantiate<CommonForm>()!;
			homeForm.Show();
			homeForm.FormClosed += OnClose;
		}
	}
}
