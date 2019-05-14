﻿using System.Linq;

namespace SCHOOL
{
	public partial class RegisterForm : Infrastructure.BaseForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}
		//******************************
		#region RegisterForm_Load
		private void RegisterForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /RegisterForm_Load
		//******************************

		//******************************
		#region Initialize
		public void Initialize()
		{
			usernameTextBox.Text = "شناسه کاربری";
			usernameTextBox.Focus();

			newPasswordLabel.Visible = false;
			newPasswordTextBox.Text = "رمز جدید";
			newPasswordTextBox.UseSystemPasswordChar = false;

			confirmPasswordLabel.Visible = false;
			confirmpasswordTextBox.Text = "تایید رمز";
			confirmpasswordTextBox.UseSystemPasswordChar = false;

			fullNameLabel.Visible = false;
			fullNameTextBox.Text = "نام و نام خانوادگی";
		}
		#endregion /Initialize
		//******************************

		//******************************
		#region UsernameTextBox_Enter
		private void UsernameTextBox_Enter(object sender, System.EventArgs e)
		{
			usernameLabel.Visible = true;
			usernameTextBox.ResetText();
		}
		#endregion /UsernameTextBox_Enter

		#region UsernameTextBox_Leave
		private void UsernameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
			{
				usernameLabel.Visible = false;
				usernameTextBox.Text = "شناسه کاربری";
			}
		}
		#endregion /UsernameTextBox_Leave
		//******************************

		//******************************
		#region NewPasswordTextBox_Enter
		private void NewPasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			newPasswordLabel.Visible = true;
			if (string.Compare(newPasswordTextBox.Text, "رمز جدید", ignoreCase: false) == 0)
			{
				newPasswordTextBox.ResetText();
			}

			newPasswordTextBox.UseSystemPasswordChar = true;
		}
		#endregion /NewPasswordTextBox_Enter

		#region NewPasswordTextBox_Leave
		private void NewPasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
			{
				newPasswordLabel.Visible = false;
				newPasswordTextBox.Text = "رمز جدید";
				newPasswordTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /NewPasswordTextBox_Leave

		#region ShowNewPasswordPicturBox_MouseDown
		private void ShowNewPasswordPicturBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			showNewPasswordPicturBox.Image = Properties.Resources.icons8_hide_100;
			newPasswordTextBox.UseSystemPasswordChar = false;
		}
		#endregion /ShowNewPasswordPicturBox_MouseDown

		#region ShowNewPasswordPicturBox_MouseUp
		private void ShowNewPasswordPicturBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			showNewPasswordPicturBox.Image = Properties.Resources.icons8_eye_100;
			newPasswordTextBox.UseSystemPasswordChar = true;
		}
		#endregion /ShowNewPasswordPicturBox_MouseUp
		//******************************

		//******************************
		#region ConfirmpasswordTextBox_Enter
		private void ConfirmpasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			confirmPasswordLabel.Visible = true;

			if (string.Compare(confirmpasswordTextBox.Text, "تایید رمز", ignoreCase: false) == 0)
			{
				confirmpasswordTextBox.ResetText();
			}
			confirmpasswordTextBox.UseSystemPasswordChar = true;
		}
		#endregion /ConfirmpasswordTextBox_Enter

		#region ConfirmpasswordTextBox_Leave
		private void ConfirmpasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(confirmpasswordTextBox.Text))
			{
				confirmPasswordLabel.Visible = false;
				confirmpasswordTextBox.Text = "تایید رمز";
				confirmpasswordTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /ConfirmpasswordTextBox_Leave

		#region ShowConfirmPasswordPicturBox_MouseDown
		private void ShowConfirmPasswordPicturBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			showConfirmPasswordPicturBox.Image = Properties.Resources.icons8_hide_100;
			confirmpasswordTextBox.UseSystemPasswordChar = false;
		}
		#endregion /ShowConfirmPasswordPicturBox_MouseDown

		#region ShowConfirmPasswordPicturBox_MouseUp
		private void ShowConfirmPasswordPicturBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			showConfirmPasswordPicturBox.Image = Properties.Resources.icons8_eye_100;
			confirmpasswordTextBox.UseSystemPasswordChar = true;
		}
		#endregion /ShowConfirmPasswordPicturBox_MouseUp
		//******************************

		//******************************
		#region FullNameTextBox_Enter
		private void FullNameTextBox_Enter(object sender, System.EventArgs e)
		{
			fullNameLabel.Visible = true;
			fullNameTextBox.ResetText();
		}
		#endregion /FullNameTextBox_Enter

		#region FullNameTextBox_Leave
		private void FullNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
			{
				fullNameLabel.Visible = false;
				fullNameTextBox.Text = "نام و نام خانوادگی";
			}
		}
		#endregion /FullNameTextBox_Leave
		//******************************

		//******************************
		#region RegisterPicturBox_Click
		private void RegisterPicturBox_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				#region Vallidation
				string informationMessage = string.Empty;

				if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
					string.Compare(usernameTextBox.Text, "شناسه کاربری",
					ignoreCase: true) == 0)
				{
					informationMessage =
					"تکمیل فیلد شناسه کاربری الزامی است.";
				}

				if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text) ||
					string.Compare(newPasswordTextBox.Text, "رمز جدید",
					ignoreCase: true) == 0)
				{
					if (informationMessage != string.Empty)
					{
						informationMessage +=
							System.Environment.NewLine;
					}

					informationMessage +=
					"تکمیل فیلد رمز جدید الزامی است!";
				}

				if (string.IsNullOrWhiteSpace(confirmpasswordTextBox.Text) ||
					string.Compare(confirmpasswordTextBox.Text, "تایید رمز",
					ignoreCase: true) == 0)
				{
					if (informationMessage != string.Empty)
					{
						informationMessage +=
							System.Environment.NewLine;
					}

					informationMessage +=
					"تکمیل فیلد تایید رمز الزامی است!";
				}

				if (informationMessage != string.Empty)
				{
					if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
					string.Compare(usernameTextBox.Text, "شناسه کاربری",
					ignoreCase: true) == 0)
					{
						usernameTextBox.Focus();
					}

					else if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text) ||
					string.Compare(newPasswordTextBox.Text, "رمز جدید",
					ignoreCase: true) == 0)
					{
						newPasswordTextBox.Focus();
					}

					else if (string.IsNullOrWhiteSpace(confirmpasswordTextBox.Text) ||
					string.Compare(confirmpasswordTextBox.Text, "تایید رمز",
					ignoreCase: true) == 0)
					{
						confirmpasswordTextBox.Focus();
					}

					Mbb.Windows.Forms.MessagesBox.InformationMessage(informationMessage, "اخطار");

					return;
				}

				if (string.Compare(newPasswordTextBox.Text,
					confirmpasswordTextBox.Text,
					ignoreCase: true) != 0)
				{
					string errorMessage =
						"رمز وارد شده یکی نمی باشد. لطفا مجدد رمز را وارد نماید!";

					Mbb.Windows.Forms.MessagesBox.ErrorMessage(errorMessage);

					newPasswordTextBox.Focus();

					return;
				}
				#endregion /Vallidation
				//====================================================================================================

				//====================================================================================================
				Models.User user =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
					.FirstOrDefault();

				if (user != null)
				{
					informationMessage =
						" شناسه کاربری مورد نظر در سیستم موجود است. لطفا از شناسه کابری دیگری استفاده نمایید.";

					Mbb.Windows.Forms.MessagesBox.InformationMessage(informationMessage, "اطلاع");

					usernameTextBox.Focus();

					return;
				}

				user = new Models.User
				{
					IsActive = true,
					Username = usernameTextBox.Text,
					Password = newPasswordTextBox.Text,
					FullName = fullNameTextBox.Text,
				};

				databaseContext.Users.Add(user);

				databaseContext.SaveChanges();
				//====================================================================================================

				//====================================================================================================
				string message =
					//$"کاربر { usernameTextBox.Text } با موفقیت اضافه گردید.";
					"اطلاعات با موفقیت ثبت گردید";

				Mbb.Windows.Forms.MessagesBox.InformationMessage(message, "اطلاع");
				//====================================================================================================
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
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
		//******************************

		//******************************
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
		#endregion /ResetPicturBox_MouseEnter

		#region ResetPicturBox_MouseLeave
		private void ResetPicturBox_MouseLeave(object sender, System.EventArgs e)
		{
			resetPicturBox.Image = Properties.Resources.ResetButton;
		}
		#endregion /ResetPicturBox_MouseLeave
		//******************************

		//******************************
		#region LoginPicturBox_Click
		private void LoginPicturBox_Click(object sender, System.EventArgs e)
		{
			Hide();
			Program.ShowLoginForm();
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
		//******************************

		//******************************
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
		//******************************
	}
}
