namespace ThreadTest
{
    partial class MainWindow
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
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.pictureBox_Left = new System.Windows.Forms.PictureBox();
            this.pictureBox_Right = new System.Windows.Forms.PictureBox();
            this.panel_Left.SuspendLayout();
            this.panel_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Right)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Left.Controls.Add(this.pictureBox_Left);
            this.panel_Left.Location = new System.Drawing.Point(12, 12);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(444, 386);
            this.panel_Left.TabIndex = 0;
            // 
            // panel_Right
            // 
            this.panel_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Right.Controls.Add(this.pictureBox_Right);
            this.panel_Right.Location = new System.Drawing.Point(512, 12);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(454, 386);
            this.panel_Right.TabIndex = 1;
            // 
            // pictureBox_Left
            // 
            this.pictureBox_Left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Left.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox_Left.Name = "pictureBox_Left";
            this.pictureBox_Left.Size = new System.Drawing.Size(4096, 4096);
            this.pictureBox_Left.TabIndex = 0;
            this.pictureBox_Left.TabStop = false;
            // 
            // pictureBox_Right
            // 
            this.pictureBox_Right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Right.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Right.Name = "pictureBox_Right";
            this.pictureBox_Right.Size = new System.Drawing.Size(4096, 4096);
            this.pictureBox_Right.TabIndex = 0;
            this.pictureBox_Right.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 410);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Left);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.panel_Left.ResumeLayout(false);
            this.panel_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Right)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.PictureBox pictureBox_Left;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.PictureBox pictureBox_Right;
    }
}