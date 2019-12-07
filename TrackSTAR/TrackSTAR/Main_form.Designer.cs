namespace TrackSTAR
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DocTracker_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(894, 720);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DocTracker_button
            // 
            this.DocTracker_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DocTracker_button.BackgroundImage")));
            this.DocTracker_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DocTracker_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocTracker_button.ForeColor = System.Drawing.Color.Transparent;
            this.DocTracker_button.Location = new System.Drawing.Point(342, 43);
            this.DocTracker_button.Name = "DocTracker_button";
            this.DocTracker_button.Size = new System.Drawing.Size(644, 577);
            this.DocTracker_button.TabIndex = 2;
            this.DocTracker_button.UseVisualStyleBackColor = true;
            this.DocTracker_button.Click += new System.EventHandler(this.DocTracker_button_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1310, 887);
            this.Controls.Add(this.DocTracker_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main_form";
            this.Text = "TrackSTAR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DocTracker_button;
    }
}

