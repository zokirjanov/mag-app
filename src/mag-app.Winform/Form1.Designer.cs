﻿namespace mag_app.Winform
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MenuPanel = new System.Windows.Forms.Panel();
			this.marketbtn = new System.Windows.Forms.Button();
			this.ControlPanel = new System.Windows.Forms.Panel();
			this.MainPanel = new System.Windows.Forms.Panel();
			this.MenuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuPanel
			// 
			this.MenuPanel.Controls.Add(this.marketbtn);
			this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuPanel.Location = new System.Drawing.Point(0, 0);
			this.MenuPanel.Name = "MenuPanel";
			this.MenuPanel.Size = new System.Drawing.Size(250, 721);
			this.MenuPanel.TabIndex = 0;
			// 
			// marketbtn
			// 
			this.marketbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.marketbtn.Location = new System.Drawing.Point(13, 12);
			this.marketbtn.Name = "marketbtn";
			this.marketbtn.Size = new System.Drawing.Size(222, 80);
			this.marketbtn.TabIndex = 0;
			this.marketbtn.Text = "Store";
			this.marketbtn.UseVisualStyleBackColor = true;
			this.marketbtn.Click += new System.EventHandler(this.marketbtn_Click);
			// 
			// ControlPanel
			// 
			this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.ControlPanel.Location = new System.Drawing.Point(958, 0);
			this.ControlPanel.Name = "ControlPanel";
			this.ControlPanel.Size = new System.Drawing.Size(305, 721);
			this.ControlPanel.TabIndex = 0;
			// 
			// MainPanel
			// 
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new System.Drawing.Point(250, 0);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(708, 721);
			this.MainPanel.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1263, 721);
			this.Controls.Add(this.MainPanel);
			this.Controls.Add(this.ControlPanel);
			this.Controls.Add(this.MenuPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MenuPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel MenuPanel;
		private Button marketbtn;
		private Panel ControlPanel;
		private Panel MainPanel;
	}
}