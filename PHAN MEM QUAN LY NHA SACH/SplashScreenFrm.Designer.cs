namespace PHAN_MEM_QUAN_LY_NHA_SACH
{
    partial class SplashScreenFrm
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
            this.pBarSplashScreen = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pBarSplashScreen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pBarSplashScreen
            // 
            this.pBarSplashScreen.EditValue = 0;
            this.pBarSplashScreen.Location = new System.Drawing.Point(0, 400);
            this.pBarSplashScreen.Name = "pBarSplashScreen";
            this.pBarSplashScreen.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pBarSplashScreen.Size = new System.Drawing.Size(600, 10);
            this.pBarSplashScreen.TabIndex = 5;
            // 
            // pictureEdit
            // 
            this.pictureEdit.EditValue = global::PHAN_MEM_QUAN_LY_NHA_SACH.Properties.Resources.SplashScreen;
            this.pictureEdit.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.AllowFocused = false;
            this.pictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit.Properties.ShowMenu = false;
            this.pictureEdit.Size = new System.Drawing.Size(600, 400);
            this.pictureEdit.TabIndex = 9;
            // 
            // SplashScreenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 410);
            this.Controls.Add(this.pictureEdit);
            this.Controls.Add(this.pBarSplashScreen);
            this.Name = "SplashScreenFrm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBarSplashScreen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl pBarSplashScreen;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
    }
}
