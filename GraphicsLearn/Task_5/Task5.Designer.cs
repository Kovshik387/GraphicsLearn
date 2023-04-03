namespace GraphicsLearn.Task_5
{
    partial class Task5
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
            this.components = new System.ComponentModel.Container();
            this.Scene = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.InfoKeyboard = new System.Windows.Forms.Label();
            this.JumpTimer = new System.Windows.Forms.Timer(this.components);
            this.AttackTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Scene)).BeginInit();
            this.SuspendLayout();
            // 
            // Scene
            // 
            this.Scene.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scene.Location = new System.Drawing.Point(2, 9);
            this.Scene.Name = "Scene";
            this.Scene.Size = new System.Drawing.Size(1000, 550);
            this.Scene.TabIndex = 0;
            this.Scene.TabStop = false;
            // 
            // InfoKeyboard
            // 
            this.InfoKeyboard.AutoSize = true;
            this.InfoKeyboard.Location = new System.Drawing.Point(21, 9);
            this.InfoKeyboard.Name = "InfoKeyboard";
            this.InfoKeyboard.Size = new System.Drawing.Size(35, 13);
            this.InfoKeyboard.TabIndex = 1;
            this.InfoKeyboard.Text = "label1";
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.InfoKeyboard);
            this.Controls.Add(this.Scene);
            this.MaximumSize = new System.Drawing.Size(1020, 600);
            this.MinimumSize = new System.Drawing.Size(1020, 600);
            this.Name = "Task5";
            this.Text = "Task5";
            ((System.ComponentModel.ISupportInitialize)(this.Scene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Scene;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label InfoKeyboard;
        private System.Windows.Forms.Timer JumpTimer;
        private System.Windows.Forms.Timer AttackTimer;
    }
}