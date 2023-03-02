﻿using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Attributes;
using mag_app.Service.Dtos.Accounts;
using mag_app.Service.Service;
using System.ComponentModel;

namespace mag_app.Winform.Windows
{
	public partial class LoginForm : Form
	{
		private readonly AppDbContext _dbContex;
		private readonly UserService _service;
		public LoginForm(AppDbContext appDbContext)
		{
			_dbContex = appDbContext;
			_service = new UserService(appDbContext);
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{

		}

		private void loginPassShow_Click(object sender, EventArgs e)
		{
			if (loginPass.UseSystemPasswordChar == PasswordPropertyTextAttribute.No.Password)
			{
				loginPassShow.Image = Image.FromFile("C:\\Users\\davok\\OneDrive\\Рабочий стол\\mag-app\\src\\mag-app.Winform\\Resources\\view.png");
				loginPass.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
			}
			else
			{
				loginPass.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
				loginPassShow.Image = Image.FromFile("C:\\Users\\davok\\OneDrive\\Рабочий стол\\mag-app\\src\\mag-app.Winform\\Resources\\hide (1).png");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			RegisterForm register = new RegisterForm(_dbContex);
			this.Hide();
			register.ShowDialog();
		}

		private async void registerBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(loginlogin.Text) && !string.IsNullOrEmpty(loginPass.Text)
			  && loginLoginerror.Text == "" && loginPasserror.Text == "")
			{
				LoginDto accountLoginDto = new LoginDto() { Login = loginlogin.Text, Password = loginPass.Text };
				var res = await _service.AccountLoginAsync(accountLoginDto);

				if (res == "False")
				{
					if (rememberMe.Checked)
					{
						var remember = await _service.AccountRememberMeAsync(accountLoginDto);
					}
					else
					{
						_service.AccountLogout();
					}
				}
				else if (res == "True")
				{
					if (rememberMe.Checked)
					{
						var remember = await _service.AccountRememberMeAsync(accountLoginDto);
					}
					else
					{
						_service.AccountLogout();
					}
					Form1 mainForm = new Form1(_dbContex);
					this.Hide();
					mainForm.ShowDialog();

				}
				else MessageBox.Show(res);
			}
		}

		private void loginlogin_TextChanged(object sender, EventArgs e)
		{
		}

		private void loginPass_TextChanged(object sender, EventArgs e)
		{
		}
	}
}