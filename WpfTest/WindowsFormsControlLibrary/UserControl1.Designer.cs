﻿namespace WindowsFormsControlLibrary
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.userControl11 = new WpfControlLibrary.UserControl1();
			this.SuspendLayout();
			// 
			// elementHost1
			// 
			this.elementHost1.Location = new System.Drawing.Point(40, 24);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(478, 234);
			this.elementHost1.TabIndex = 0;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.Child = this.userControl11;
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.elementHost1);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(570, 305);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private WpfControlLibrary.UserControl1 userControl11;
	}
}
