namespace CalculateAssessment1
{
    partial class MainForm
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
            this.BackgroundImage = new System.Windows.Forms.PictureBox();
            this.GunShootButton = new System.Windows.Forms.Button();
            this.ShootAwayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundImage
            // 
            this.BackgroundImage.Image = global::CalculateAssessment1.Properties.Resources.bike;
            this.BackgroundImage.Location = new System.Drawing.Point(33, 60);
            this.BackgroundImage.Name = "BackgroundImage";
            this.BackgroundImage.Size = new System.Drawing.Size(437, 357);
            this.BackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackgroundImage.TabIndex = 0;
            this.BackgroundImage.TabStop = false;
            // 
            // GunShootButton
            // 
            this.GunShootButton.Location = new System.Drawing.Point(52, 94);
            this.GunShootButton.Name = "GunShootButton";
            this.GunShootButton.Size = new System.Drawing.Size(183, 116);
            this.GunShootButton.TabIndex = 1;
            this.GunShootButton.Text = "GunShoot";
            this.GunShootButton.UseVisualStyleBackColor = true;
            this.GunShootButton.Click += new System.EventHandler(this.GunShootButton_Click);
            // 
            // ShootAwayButton
            // 
            this.ShootAwayButton.Location = new System.Drawing.Point(69, 242);
            this.ShootAwayButton.Name = "ShootAwayButton";
            this.ShootAwayButton.Size = new System.Drawing.Size(151, 87);
            this.ShootAwayButton.TabIndex = 2;
            this.ShootAwayButton.Text = "ShootAway";
            this.ShootAwayButton.UseVisualStyleBackColor = true;
            this.ShootAwayButton.Click += new System.EventHandler(this.ShootAwayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.ShootAwayButton);
            this.Controls.Add(this.GunShootButton);
            this.Controls.Add(this.BackgroundImage);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundImage;
        private System.Windows.Forms.Button GunShootButton;
        private System.Windows.Forms.Button ShootAwayButton;
    }
}

