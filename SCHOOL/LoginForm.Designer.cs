namespace SCHOOL
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.passwordLabel = new Mbb.Windows.Forms.Label();
			this.passwordTextBox = new Mbb.Windows.Forms.TextBox();
			this.picturBox2 = new Mbb.Windows.Forms.PicturBox();
			this.usernameLabel = new Mbb.Windows.Forms.Label();
			this.usernameTextBox = new Mbb.Windows.Forms.TextBox();
			this.picturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.loginPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.resetPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.exitPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.registerPicturBox = new Mbb.Windows.Forms.PicturBox();
			((System.ComponentModel.ISupportInitialize)(this.picturBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.loginPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.resetPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exitPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.registerPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// passwordLabel
			// 
			this.passwordLabel.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.passwordLabel.ForeColor = System.Drawing.Color.White;
			this.passwordLabel.Location = new System.Drawing.Point(27, 63);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(50, 20);
			this.passwordLabel.TabIndex = 8;
			this.passwordLabel.Text = "رمز عبور";
			this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.passwordLabel.Visible = false;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.ForeColor = System.Drawing.Color.White;
			this.passwordTextBox.Location = new System.Drawing.Point(31, 85);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(389, 18);
			this.passwordTextBox.TabIndex = 7;
			this.passwordTextBox.Text = "رمز عبور";
			this.passwordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
			this.passwordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
			// 
			// picturBox2
			// 
			this.picturBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picturBox2.Image = global::SCHOOL.Properties.Resources.Box;
			this.picturBox2.Location = new System.Drawing.Point(12, 71);
			this.picturBox2.Name = "picturBox2";
			this.picturBox2.Size = new System.Drawing.Size(420, 46);
			this.picturBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picturBox2.TabIndex = 6;
			this.picturBox2.TabStop = false;
			// 
			// usernameLabel
			// 
			this.usernameLabel.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.usernameLabel.ForeColor = System.Drawing.Color.White;
			this.usernameLabel.Location = new System.Drawing.Point(27, 4);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(80, 20);
			this.usernameLabel.TabIndex = 4;
			this.usernameLabel.Text = "شناسه کاربری";
			this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.usernameLabel.Visible = false;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.BackColor = System.Drawing.Color.SlateBlue;
			this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextBox.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.ForeColor = System.Drawing.Color.White;
			this.usernameTextBox.Location = new System.Drawing.Point(31, 29);
			this.usernameTextBox.MaxLength = 20;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(389, 18);
			this.usernameTextBox.TabIndex = 3;
			this.usernameTextBox.Text = "شناسه کاربری";
			this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
			this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
			// 
			// picturBox1
			// 
			this.picturBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picturBox1.Image = global::SCHOOL.Properties.Resources.Box;
			this.picturBox1.Location = new System.Drawing.Point(12, 12);
			this.picturBox1.Name = "picturBox1";
			this.picturBox1.Size = new System.Drawing.Size(420, 50);
			this.picturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picturBox1.TabIndex = 2;
			this.picturBox1.TabStop = false;
			// 
			// loginPicturBox
			// 
			this.loginPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("loginPicturBox.Image")));
			this.loginPicturBox.Location = new System.Drawing.Point(13, 123);
			this.loginPicturBox.Name = "loginPicturBox";
			this.loginPicturBox.Size = new System.Drawing.Size(100, 50);
			this.loginPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.loginPicturBox.TabIndex = 9;
			this.loginPicturBox.TabStop = false;
			this.loginPicturBox.Click += new System.EventHandler(this.LoginPicturBox_Click);
			this.loginPicturBox.MouseEnter += new System.EventHandler(this.LoginPicturBox_MouseEnter);
			this.loginPicturBox.MouseLeave += new System.EventHandler(this.LoginPicturBox_MouseLeave);
			// 
			// resetPicturBox
			// 
			this.resetPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("resetPicturBox.Image")));
			this.resetPicturBox.Location = new System.Drawing.Point(119, 123);
			this.resetPicturBox.Name = "resetPicturBox";
			this.resetPicturBox.Size = new System.Drawing.Size(100, 50);
			this.resetPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.resetPicturBox.TabIndex = 10;
			this.resetPicturBox.TabStop = false;
			this.resetPicturBox.Click += new System.EventHandler(this.ResetPicturBox_Click);
			this.resetPicturBox.MouseEnter += new System.EventHandler(this.ResetPicturBox_MouseEnter);
			this.resetPicturBox.MouseLeave += new System.EventHandler(this.ResetPicturBox_MouseLeave);
			// 
			// exitPicturBox
			// 
			this.exitPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPicturBox.Image")));
			this.exitPicturBox.Location = new System.Drawing.Point(331, 123);
			this.exitPicturBox.Name = "exitPicturBox";
			this.exitPicturBox.Size = new System.Drawing.Size(100, 50);
			this.exitPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.exitPicturBox.TabIndex = 12;
			this.exitPicturBox.TabStop = false;
			this.exitPicturBox.Click += new System.EventHandler(this.ExitPicturBox_Click);
			this.exitPicturBox.MouseEnter += new System.EventHandler(this.ExitPicturBox_MouseEnter);
			this.exitPicturBox.MouseLeave += new System.EventHandler(this.ExitPicturBox_MouseLeave);
			// 
			// registerPicturBox
			// 
			this.registerPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("registerPicturBox.Image")));
			this.registerPicturBox.Location = new System.Drawing.Point(225, 123);
			this.registerPicturBox.Name = "registerPicturBox";
			this.registerPicturBox.Size = new System.Drawing.Size(100, 50);
			this.registerPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.registerPicturBox.TabIndex = 11;
			this.registerPicturBox.TabStop = false;
			this.registerPicturBox.Click += new System.EventHandler(this.RegisterPicturBox_Click);
			this.registerPicturBox.MouseEnter += new System.EventHandler(this.RegisterPicturBox_MouseEnter);
			this.registerPicturBox.MouseLeave += new System.EventHandler(this.RegisterPicturBox_MouseLeave);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 181);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.picturBox2);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.picturBox1);
			this.Controls.Add(this.loginPicturBox);
			this.Controls.Add(this.resetPicturBox);
			this.Controls.Add(this.exitPicturBox);
			this.Controls.Add(this.registerPicturBox);
			this.MaximumSize = new System.Drawing.Size(600, 220);
			this.MinimumSize = new System.Drawing.Size(460, 220);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			((System.ComponentModel.ISupportInitialize)(this.picturBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.loginPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.resetPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exitPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.registerPicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.TextBox usernameTextBox;
		private Mbb.Windows.Forms.PicturBox picturBox1;
		private Mbb.Windows.Forms.Label usernameLabel;
		private Mbb.Windows.Forms.Label passwordLabel;
		private Mbb.Windows.Forms.TextBox passwordTextBox;
		private Mbb.Windows.Forms.PicturBox picturBox2;
		private Mbb.Windows.Forms.PicturBox loginPicturBox;
		private Mbb.Windows.Forms.PicturBox resetPicturBox;
		private Mbb.Windows.Forms.PicturBox registerPicturBox;
		private Mbb.Windows.Forms.PicturBox exitPicturBox;
	}
}