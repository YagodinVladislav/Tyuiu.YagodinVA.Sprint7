
namespace Project.V
{
    partial class FormAbout
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
            this.buttonOK_SSV = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_SSV = new System.Windows.Forms.PictureBox();
            this.labelInfo_SSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SSV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_SSV
            // 
            this.buttonOK_SSV.Location = new System.Drawing.Point(460, 160);
            this.buttonOK_SSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK_SSV.Name = "buttonOK_SSV";
            this.buttonOK_SSV.Size = new System.Drawing.Size(100, 28);
            this.buttonOK_SSV.TabIndex = 1;
            this.buttonOK_SSV.Text = "Ок";
            this.buttonOK_SSV.UseVisualStyleBackColor = true;
            this.buttonOK_SSV.Click += new System.EventHandler(this.buttonOK_SSV_Click);
            // 
            // pictureBoxAvatar_SSV
            // 
            this.pictureBoxAvatar_SSV.Location = new System.Drawing.Point(16, 48);
            this.pictureBoxAvatar_SSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxAvatar_SSV.Name = "pictureBoxAvatar_SSV";
            this.pictureBoxAvatar_SSV.Size = new System.Drawing.Size(156, 96);
            this.pictureBoxAvatar_SSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_SSV.TabIndex = 2;
            this.pictureBoxAvatar_SSV.TabStop = false;
            // 
            // labelInfo_SSV
            // 
            this.labelInfo_SSV.AutoSize = true;
            this.labelInfo_SSV.Location = new System.Drawing.Point(181, 11);
            this.labelInfo_SSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo_SSV.Name = "labelInfo_SSV";
            this.labelInfo_SSV.Size = new System.Drawing.Size(39, 17);
            this.labelInfo_SSV.TabIndex = 3;
            this.labelInfo_SSV.Text = "fyjjcfj";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 203);
            this.Controls.Add(this.labelInfo_SSV);
            this.Controls.Add(this.pictureBoxAvatar_SSV);
            this.Controls.Add(this.buttonOK_SSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOK_SSV;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SSV;
        private System.Windows.Forms.Label labelInfo_SSV;
    }
}