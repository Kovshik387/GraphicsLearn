extern alias global1;
using global1::Tao.Platform.Windows;

namespace GraphicsLearn.Task_6
{
    partial class Task6
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
            this.View3d = new global1::Tao.Platform.Windows.SimpleOpenGlControl();
            this.ShowView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // View3d
            // 
            this.View3d.AccumBits = ((byte)(0));
            this.View3d.AutoCheckErrors = false;
            this.View3d.AutoFinish = false;
            this.View3d.AutoMakeCurrent = true;
            this.View3d.AutoSwapBuffers = true;
            this.View3d.BackColor = System.Drawing.Color.Black;
            this.View3d.ColorBits = ((byte)(32));
            this.View3d.DepthBits = ((byte)(16));
            this.View3d.Location = new System.Drawing.Point(12, 12);
            this.View3d.Name = "View3d";
            this.View3d.Size = new System.Drawing.Size(562, 426);
            this.View3d.StencilBits = ((byte)(0));
            this.View3d.TabIndex = 0;
            // 
            // ShowView
            // 
            this.ShowView.Location = new System.Drawing.Point(580, 415);
            this.ShowView.Name = "ShowView";
            this.ShowView.Size = new System.Drawing.Size(208, 23);
            this.ShowView.TabIndex = 1;
            this.ShowView.Text = "button1";
            this.ShowView.UseVisualStyleBackColor = true;
            this.ShowView.Click += new System.EventHandler(this.ShowView_Click);
            // 
            // Task6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowView);
            this.Controls.Add(this.View3d);
            this.Name = "Task6";
            this.Text = "Task6";
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleOpenGlControl View3d;
        private System.Windows.Forms.Button ShowView;
    }
}