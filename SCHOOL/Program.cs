namespace SCHOOL
{
	static class Program
	{

		//public static Models.User AuthenticatedUser { get; set; }
		//==================================================

		//==================================================
		#region LoginForm
		private static LoginForm loginForm;

		public static LoginForm LoginForm
		{
			get
			{
				if (loginForm == null)
				{
					loginForm =
						new LoginForm();
				}

				return loginForm;
			}
		}

		public static void ShowLoginForm()
		{
			//AuthenticatedUser = null;

			LoginForm.Show();
			LoginForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		}
		#endregion /LoginForm
		//==================================================

		//==================================================
		#region RegisterForm
		private static RegisterForm registerForm;

		public static RegisterForm RegistrForm
		{
			get
			{
				if (registerForm == null)
				{
					registerForm =
						new RegisterForm();
				}

				return registerForm;
			}
		}
		public static void ShowRegisterForm()
		{
			RegistrForm.Show();
			RegistrForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		}
		#endregion /RegisterForm
		//==================================================

		//==================================================

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[System.STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			System.Windows.Forms.Application.Run(new LoginForm());
		}
	}
}
