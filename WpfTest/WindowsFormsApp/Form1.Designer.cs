﻿namespace WindowsFormsApp
{
	partial class Form1
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
			this.userControl11 = new WindowsFormsControlLibrary.UserControl1();
			this.userControl21 = new WindowsFormsControlLibrary.UserControl2();
			this.SuspendLayout();
			// 
			// userControl11
			// 
			this.userControl11.Location = new System.Drawing.Point(33, 30);
			this.userControl11.Name = "userControl11";
			this.userControl11.Size = new System.Drawing.Size(491, 244);
			this.userControl11.TabIndex = 0;
			// 
			// userControl21
			// 
			this.userControl21.Location = new System.Drawing.Point(503, 30);
			this.userControl21.Name = "userControl21";
			this.userControl21.Size = new System.Drawing.Size(712, 361);
			this.userControl21.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1214, 391);
			this.Controls.Add(this.userControl21);
			this.Controls.Add(this.userControl11);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private WindowsFormsControlLibrary.UserControl1 userControl11;
		private WindowsFormsControlLibrary.UserControl2 userControl21;
	}
}

