using OpenTK.Graphics;

namespace SorcerousLands
{
    partial class SorcerousLands
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
			glControl1 = new OpenTK.GLControl.GLControl();
			SuspendLayout();
			// 
			// glControl1
			// 
			glControl1.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
			glControl1.APIVersion = new Version(3, 3, 0, 0);
			glControl1.Dock = DockStyle.Fill;
			glControl1.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
			glControl1.IsEventDriven = true;
			glControl1.Location = new Point(0, 0);
			glControl1.Name = "glControl1";
			glControl1.Profile = OpenTK.Windowing.Common.ContextProfile.Core;
			glControl1.SharedContext = null;
			glControl1.Size = new Size(784, 561);
			glControl1.TabIndex = 0;
			// 
			// SorcerousLands
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(784, 561);
			Controls.Add(glControl1);
			Font = new Font("Segoe UI", 12F);
			Margin = new Padding(4);
			MinimumSize = new Size(800, 600);
			Name = "SorcerousLands";
			Text = "Колдовские земли.";
			ResumeLayout(false);
		}

		#endregion

		private OpenTK.GLControl.GLControl glControl1;
	}
}
