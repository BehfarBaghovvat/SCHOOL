namespace SCHOOL
{
	public partial class LoginForm : Infrastructure.BaseForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}
		#region Initialize
		public void Initialize()
		{
			usernameLabel.Visible = true;
			usernameTextBox.Text = string.Empty;
			usernameTextBox.Focus();

			passwordLabel.Visible = false;
			passwordTextBox.Text = "رمز عبور";
			passwordTextBox.UseSystemPasswordChar = false;
		}
		#endregion /Initialize
		//******
		#region usernameTextBox_Enter
		private void usernameTextBox_Enter(object sender, System.EventArgs e)
		{
			usernameLabel.Visible = true;
			usernameTextBox.Text = string.Empty;
		}
		#endregion /usernameTextBox_Enter

		#region  usernameTextBox_Leave
		private void usernameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
			{
				usernameLabel.Visible = false;
				usernameTextBox.Text = "شناسه کاربری";
			}
		}
		#endregion / usernameTextBox_Leave
		//******
		//******
		#region PasswordTextBox_Enter
		private void PasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordLabel.Visible = true;
			passwordTextBox.Text = string.Empty;
			passwordTextBox.UseSystemPasswordChar = true;
		}
		#endregion /PasswordTextBox_Enter

		#region PasswordTextBox_Leave
		private void PasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				passwordLabel.Visible = false;
				passwordTextBox.Text = "رمز عبور";
				passwordTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /PasswordTextBox_Leave
		//******
		//******
		#region LoginPicturBox_Click
		private void LoginPicturBox_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /LoginPicturBox_Click

		#region LoginPicturBox_MouseEnter
		private void LoginPicturBox_MouseEnter(object sender, System.EventArgs e)
		{
			loginPicturBox.Image = Properties.Resources.LoginButton_Glow;
		}
		#endregion /LoginPicturBox_MouseEnter

		#region LoginPicturBox_MouseLeave
		private void LoginPicturBox_MouseLeave(object sender, System.EventArgs e)
		{
			loginPicturBox.Image = Properties.Resources.LoginButton;
		}
		#endregion /LoginPicturBox_MouseLeave
		//******
		//******
		#region ResetPicturBox_Click
		private void ResetPicturBox_Click(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /ResetPicturBox_Click

		#region ResetPicturBox_MouseEnter
		private void ResetPicturBox_MouseEnter(object sender, System.EventArgs e)
		{
			resetPicturBox.Image = Properties.Resources.ResetButton_Glow;
		}
		#endregion ResetPicturBox_MouseEnter

		#region ResetPicturBox_MouseLeave
		private void ResetPicturBox_MouseLeave(object sender, System.EventArgs e)
		{
			resetPicturBox.Image = Properties.Resources.ResetButton;
		}
		#endregion ResetPicturBox_MouseLeave
		//******
		//******
		#region RegisterPicturBox_Click
		private void RegisterPicturBox_Click(object sender, System.EventArgs e)
		{
			Hide();
			Program.ShowRegisterForm();
		}
		#endregion /RegisterPicturBox_Click

		#region RegisterPicturBox_MouseEnter
		private void RegisterPicturBox_MouseEnter(object sender, System.EventArgs e)
		{
			registerPicturBox.Image = Properties.Resources.RegisterButton_Glow;
		}
		#endregion /RegisterPicturBox_MouseEnter

		#region RegisterPicturBox_MouseLeave
		private void RegisterPicturBox_MouseLeave(object sender, System.EventArgs e)
		{
			registerPicturBox.Image = Properties.Resources.RegisterButton;
		}
		#endregion /RegisterPicturBox_MouseLeave
		//******
		//******
		#region ExitPicturBox_Click
		private void ExitPicturBox_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.Exit();
		}
		#endregion /ExitPicturBox_Click

		#region ExitPicturBox_MouseEnter
		private void ExitPicturBox_MouseEnter(object sender, System.EventArgs e)
		{
			exitPicturBox.Image = Properties.Resources.ExitButton_Glow;
		}
		#endregion /ExitPicturBox_MouseEnter

		#region ExitPicturBox_MouseLeave
		private void ExitPicturBox_MouseLeave(object sender, System.EventArgs e)
		{
			exitPicturBox.Image = Properties.Resources.ExitButton;
		}
		#endregion /ExitPicturBox_MouseLeave
		//******
	}
}
