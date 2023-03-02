﻿namespace mag_app.Winform.Windows
{
	partial class RegisterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
			this.label1 = new System.Windows.Forms.Label();
			this.registerLogintb = new System.Windows.Forms.TextBox();
			this.registerEmailtb = new System.Windows.Forms.TextBox();
			this.registerPasswordtb = new System.Windows.Forms.TextBox();
			this.registerConfirmtb = new System.Windows.Forms.TextBox();
			this.confirmShowbt = new System.Windows.Forms.Button();
			this.passwordShowbt = new System.Windows.Forms.Button();
			this.registerBtn = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.loginlabel = new System.Windows.Forms.Label();
			this.emaillabel = new System.Windows.Forms.Label();
			this.passwordlabel = new System.Windows.Forms.Label();
			this.confirmlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Text Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(147, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 58);
			this.label1.TabIndex = 0;
			this.label1.Text = "Register";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// registerLogintb
			// 
			this.registerLogintb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.registerLogintb.Location = new System.Drawing.Point(52, 184);
			this.registerLogintb.Name = "registerLogintb";
			this.registerLogintb.PlaceholderText = "Login";
			this.registerLogintb.Size = new System.Drawing.Size(380, 36);
			this.registerLogintb.TabIndex = 1;
			this.registerLogintb.TextChanged += new System.EventHandler(this.registerLogintb_TextChanged);
			// 
			// registerEmailtb
			// 
			this.registerEmailtb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.registerEmailtb.Location = new System.Drawing.Point(52, 261);
			this.registerEmailtb.Name = "registerEmailtb";
			this.registerEmailtb.PlaceholderText = "Email";
			this.registerEmailtb.Size = new System.Drawing.Size(380, 36);
			this.registerEmailtb.TabIndex = 2;
			this.registerEmailtb.TextChanged += new System.EventHandler(this.registerEmailtb_TextChanged);
			// 
			// registerPasswordtb
			// 
			this.registerPasswordtb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.registerPasswordtb.Location = new System.Drawing.Point(52, 346);
			this.registerPasswordtb.Name = "registerPasswordtb";
			this.registerPasswordtb.PlaceholderText = "Password";
			this.registerPasswordtb.Size = new System.Drawing.Size(380, 36);
			this.registerPasswordtb.TabIndex = 3;
			this.registerPasswordtb.UseSystemPasswordChar = true;
			this.registerPasswordtb.TextChanged += new System.EventHandler(this.registerPasswordtb_TextChanged);
			// 
			// registerConfirmtb
			// 
			this.registerConfirmtb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.registerConfirmtb.Location = new System.Drawing.Point(52, 430);
			this.registerConfirmtb.Name = "registerConfirmtb";
			this.registerConfirmtb.PlaceholderText = "Confirm your password";
			this.registerConfirmtb.Size = new System.Drawing.Size(380, 36);
			this.registerConfirmtb.TabIndex = 4;
			this.registerConfirmtb.UseSystemPasswordChar = true;
			this.registerConfirmtb.TextChanged += new System.EventHandler(this.registerConfirmtb_TextChanged);
			// 
			// confirmShowbt
			// 
			this.confirmShowbt.BackColor = System.Drawing.Color.Transparent;
			this.confirmShowbt.Image = ((System.Drawing.Image)(resources.GetObject("confirmShowbt.Image")));
			this.confirmShowbt.Location = new System.Drawing.Point(399, 433);
			this.confirmShowbt.Name = "confirmShowbt";
			this.confirmShowbt.Size = new System.Drawing.Size(30, 29);
			this.confirmShowbt.TabIndex = 6;
			this.confirmShowbt.UseVisualStyleBackColor = false;
			this.confirmShowbt.Click += new System.EventHandler(this.confirmShowbt_Click);
			// 
			// passwordShowbt
			// 
			this.passwordShowbt.BackColor = System.Drawing.Color.Transparent;
			this.passwordShowbt.Image = ((System.Drawing.Image)(resources.GetObject("passwordShowbt.Image")));
			this.passwordShowbt.Location = new System.Drawing.Point(398, 349);
			this.passwordShowbt.Name = "passwordShowbt";
			this.passwordShowbt.Size = new System.Drawing.Size(30, 29);
			this.passwordShowbt.TabIndex = 8;
			this.passwordShowbt.UseVisualStyleBackColor = false;
			this.passwordShowbt.Click += new System.EventHandler(this.passwordShowbt_Click);
			// 
			// registerBtn
			// 
			this.registerBtn.BackColor = System.Drawing.Color.SpringGreen;
			this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.registerBtn.Location = new System.Drawing.Point(52, 533);
			this.registerBtn.Name = "registerBtn";
			this.registerBtn.Size = new System.Drawing.Size(376, 59);
			this.registerBtn.TabIndex = 9;
			this.registerBtn.Text = "Register";
			this.registerBtn.UseVisualStyleBackColor = false;
			this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(83, 615);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(319, 46);
			this.button1.TabIndex = 10;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// loginlabel
			// 
			this.loginlabel.AutoSize = true;
			this.loginlabel.ForeColor = System.Drawing.Color.Red;
			this.loginlabel.Location = new System.Drawing.Point(52, 223);
			this.loginlabel.Name = "loginlabel";
			this.loginlabel.Size = new System.Drawing.Size(0, 20);
			this.loginlabel.TabIndex = 11;
			// 
			// emaillabel
			// 
			this.emaillabel.AutoSize = true;
			this.emaillabel.ForeColor = System.Drawing.Color.Red;
			this.emaillabel.Location = new System.Drawing.Point(52, 300);
			this.emaillabel.Name = "emaillabel";
			this.emaillabel.Size = new System.Drawing.Size(0, 20);
			this.emaillabel.TabIndex = 12;
			// 
			// passwordlabel
			// 
			this.passwordlabel.AutoSize = true;
			this.passwordlabel.ForeColor = System.Drawing.Color.Red;
			this.passwordlabel.Location = new System.Drawing.Point(52, 385);
			this.passwordlabel.Name = "passwordlabel";
			this.passwordlabel.Size = new System.Drawing.Size(0, 20);
			this.passwordlabel.TabIndex = 13;
			// 
			// confirmlabel
			// 
			this.confirmlabel.AutoSize = true;
			this.confirmlabel.ForeColor = System.Drawing.Color.Red;
			this.confirmlabel.Location = new System.Drawing.Point(52, 469);
			this.confirmlabel.Name = "confirmlabel";
			this.confirmlabel.Size = new System.Drawing.Size(0, 20);
			this.confirmlabel.TabIndex = 14;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(484, 731);
			this.Controls.Add(this.confirmlabel);
			this.Controls.Add(this.passwordlabel);
			this.Controls.Add(this.emaillabel);
			this.Controls.Add(this.loginlabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.registerBtn);
			this.Controls.Add(this.passwordShowbt);
			this.Controls.Add(this.confirmShowbt);
			this.Controls.Add(this.registerConfirmtb);
			this.Controls.Add(this.registerPasswordtb);
			this.Controls.Add(this.registerEmailtb);
			this.Controls.Add(this.registerLogintb);
			this.Controls.Add(this.label1);
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegisterForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox registerLogintb;
		private TextBox registerEmailtb;
		private TextBox registerPasswordtb;
		private TextBox registerConfirmtb;
		private Button confirmShowbt;
		private Button passwordShowbt;
		private Button registerBtn;
		private Button button1;
		private Label loginlabel;
		private Label emaillabel;
		private Label passwordlabel;
		private Label confirmlabel;
	}
}