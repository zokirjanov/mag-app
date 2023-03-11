﻿namespace mag_app.Winform.Windows.Product_Forms
{
    partial class StoreProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreProductsForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.productChildPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.magazineLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuPanel.Controls.Add(this.backButton);
            this.MenuPanel.Controls.Add(this.productBtn);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(219, 638);
            this.MenuPanel.TabIndex = 1;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(11, 593);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(194, 38);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productBtn.Image = ((System.Drawing.Image)(resources.GetObject("productBtn.Image")));
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(13, 10);
            this.productBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productBtn.Name = "productBtn";
            this.productBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.productBtn.Size = new System.Drawing.Size(194, 60);
            this.productBtn.TabIndex = 0;
            this.productBtn.Text = "Создать продукт";
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // productChildPanel
            // 
            this.productChildPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productChildPanel.Location = new System.Drawing.Point(219, 33);
            this.productChildPanel.Name = "productChildPanel";
            this.productChildPanel.Size = new System.Drawing.Size(861, 605);
            this.productChildPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.magazineLabel);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(219, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 33);
            this.panel1.TabIndex = 3;
            // 
            // magazineLabel
            // 
            this.magazineLabel.AutoSize = true;
            this.magazineLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.magazineLabel.Location = new System.Drawing.Point(7, 9);
            this.magazineLabel.Name = "magazineLabel";
            this.magazineLabel.Size = new System.Drawing.Size(82, 21);
            this.magazineLabel.TabIndex = 1;
            this.magazineLabel.Text = "Магазин:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(123, 4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(0, 26);
            this.TitleLabel.TabIndex = 0;
            // 
            // StoreProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productChildPanel);
            this.Controls.Add(this.MenuPanel);
            this.MaximumSize = new System.Drawing.Size(1096, 677);
            this.MinimumSize = new System.Drawing.Size(1096, 677);
            this.Name = "StoreProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreProductsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StoreProductsForm_FormClosed);
            this.Load += new System.EventHandler(this.StoreProductsForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private Button productBtn;
        private Panel productChildPanel;
        private Button backButton;
        private Panel panel1;
        private Label TitleLabel;
        private Label magazineLabel;
    }
}