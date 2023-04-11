extern alias global1;
using global1::Tao.Platform.Windows;
using Tao.DevIl;
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ShowFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // View3d
            // 
            this.View3d.AccumBits = ((byte)(0));
            this.View3d.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.View3d.AutoCheckErrors = false;
            this.View3d.AutoFinish = false;
            this.View3d.AutoMakeCurrent = true;
            this.View3d.AutoSwapBuffers = true;
            this.View3d.BackColor = System.Drawing.Color.Black;
            this.View3d.ColorBits = ((byte)(32));
            this.View3d.DepthBits = ((byte)(16));
            this.View3d.Location = new System.Drawing.Point(12, 12);
            this.View3d.Name = "View3d";
            this.View3d.Size = new System.Drawing.Size(951, 585);
            this.View3d.StencilBits = ((byte)(0));
            this.View3d.TabIndex = 0;
            this.View3d.Load += new System.EventHandler(this.View3d_Load);
            // 
            // ShowView
            // 
            this.ShowView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowView.Location = new System.Drawing.Point(969, 545);
            this.ShowView.Name = "ShowView";
            this.ShowView.Size = new System.Drawing.Size(174, 23);
            this.ShowView.TabIndex = 1;
            this.ShowView.Text = "button1";
            this.ShowView.UseVisualStyleBackColor = true;
            this.ShowView.Click += new System.EventHandler(this.ShowView_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Конус",
            "Куб",
            "Цилиндр",
            "Додекаэдр",
            "Икосаэдр",
            "Октаэдр",
            "Ромбический додекаэдр",
            "Фрактал Губка Серпинского",
            "Сфера",
            "Чайник",
            "Тетраэдр",
            "Тор"});
            this.comboBox1.Location = new System.Drawing.Point(969, 518);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // ShowFill
            // 
            this.ShowFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowFill.Location = new System.Drawing.Point(969, 574);
            this.ShowFill.Name = "ShowFill";
            this.ShowFill.Size = new System.Drawing.Size(174, 23);
            this.ShowFill.TabIndex = 3;
            this.ShowFill.Text = "button2";
            this.ShowFill.UseVisualStyleBackColor = true;
            this.ShowFill.Click += new System.EventHandler(this.ShowFill_Click);
            // 
            // Task6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 609);
            this.Controls.Add(this.ShowFill);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ShowView);
            this.Controls.Add(this.View3d);
            this.Name = "Task6";
            this.Text = "Task6";
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleOpenGlControl View3d;
        private System.Windows.Forms.Button ShowView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ShowFill;
    }
}