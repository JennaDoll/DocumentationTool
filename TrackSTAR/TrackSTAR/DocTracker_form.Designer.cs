namespace TrackSTAR
{
    partial class DocTracker_form
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
            this.firstlastname_textbox = new System.Windows.Forms.TextBox();
            this.firstlastname_label = new System.Windows.Forms.Label();
            this.NotQuoted_label = new System.Windows.Forms.Label();
            this.NotQuoted_combobox = new System.Windows.Forms.ComboBox();
            this.NotQuotedNotes_richtextbox = new System.Windows.Forms.RichTextBox();
            this.whynotquoted_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NotQuotedAdditionalNotes_richtextbox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DidYouQuote_label = new System.Windows.Forms.Label();
            this.DidYouQuote_combobox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // firstlastname_textbox
            // 
            this.firstlastname_textbox.Location = new System.Drawing.Point(295, 49);
            this.firstlastname_textbox.Name = "firstlastname_textbox";
            this.firstlastname_textbox.Size = new System.Drawing.Size(374, 31);
            this.firstlastname_textbox.TabIndex = 0;
            // 
            // firstlastname_label
            // 
            this.firstlastname_label.AutoSize = true;
            this.firstlastname_label.Location = new System.Drawing.Point(24, 53);
            this.firstlastname_label.Name = "firstlastname_label";
            this.firstlastname_label.Size = new System.Drawing.Size(267, 25);
            this.firstlastname_label.TabIndex = 1;
            this.firstlastname_label.Text = "Customer First & Last Name";
            // 
            // NotQuoted_label
            // 
            this.NotQuoted_label.AutoSize = true;
            this.NotQuoted_label.Location = new System.Drawing.Point(90, 160);
            this.NotQuoted_label.Name = "NotQuoted_label";
            this.NotQuoted_label.Size = new System.Drawing.Size(201, 25);
            this.NotQuoted_label.TabIndex = 2;
            this.NotQuoted_label.Text = "Reason Not Quoted";
            // 
            // NotQuoted_combobox
            // 
            this.NotQuoted_combobox.FormattingEnabled = true;
            this.NotQuoted_combobox.Items.AddRange(new object[] {
            "Not Qualified",
            "Inquiry Only",
            "Transfer",
            "Other"});
            this.NotQuoted_combobox.Location = new System.Drawing.Point(295, 160);
            this.NotQuoted_combobox.Name = "NotQuoted_combobox";
            this.NotQuoted_combobox.Size = new System.Drawing.Size(374, 33);
            this.NotQuoted_combobox.TabIndex = 3;
            this.NotQuoted_combobox.SelectedIndexChanged += new System.EventHandler(this.NotQuoted_combobox_SelectedIndexChanged);
            // 
            // NotQuotedNotes_richtextbox
            // 
            this.NotQuotedNotes_richtextbox.Location = new System.Drawing.Point(1699, 272);
            this.NotQuotedNotes_richtextbox.Name = "NotQuotedNotes_richtextbox";
            this.NotQuotedNotes_richtextbox.Size = new System.Drawing.Size(640, 1089);
            this.NotQuotedNotes_richtextbox.TabIndex = 8;
            this.NotQuotedNotes_richtextbox.Text = "";
            // 
            // whynotquoted_label
            // 
            this.whynotquoted_label.AutoSize = true;
            this.whynotquoted_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.whynotquoted_label.Location = new System.Drawing.Point(70, 955);
            this.whynotquoted_label.Name = "whynotquoted_label";
            this.whynotquoted_label.Size = new System.Drawing.Size(609, 50);
            this.whynotquoted_label.TabIndex = 6;
            this.whynotquoted_label.Text = "Must provide notes as to why not quoted. If call was a transfer,\r\nmust provide wh" +
    "y call was transfered.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1956, 1462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 76);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Preview";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NotQuotedAdditionalNotes_richtextbox
            // 
            this.NotQuotedAdditionalNotes_richtextbox.Location = new System.Drawing.Point(75, 1022);
            this.NotQuotedAdditionalNotes_richtextbox.Name = "NotQuotedAdditionalNotes_richtextbox";
            this.NotQuotedAdditionalNotes_richtextbox.Size = new System.Drawing.Size(640, 352);
            this.NotQuotedAdditionalNotes_richtextbox.TabIndex = 4;
            this.NotQuotedAdditionalNotes_richtextbox.Text = "";
            this.NotQuotedAdditionalNotes_richtextbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(2188, 1462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 76);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generate Notes";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // DidYouQuote_label
            // 
            this.DidYouQuote_label.AutoSize = true;
            this.DidYouQuote_label.Location = new System.Drawing.Point(136, 107);
            this.DidYouQuote_label.Name = "DidYouQuote_label";
            this.DidYouQuote_label.Size = new System.Drawing.Size(157, 25);
            this.DidYouQuote_label.TabIndex = 9;
            this.DidYouQuote_label.Text = "Did you quote?";
            // 
            // DidYouQuote_combobox
            // 
            this.DidYouQuote_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DidYouQuote_combobox.FormattingEnabled = true;
            this.DidYouQuote_combobox.IntegralHeight = false;
            this.DidYouQuote_combobox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.DidYouQuote_combobox.Location = new System.Drawing.Point(295, 107);
            this.DidYouQuote_combobox.Name = "DidYouQuote_combobox";
            this.DidYouQuote_combobox.Size = new System.Drawing.Size(374, 33);
            this.DidYouQuote_combobox.TabIndex = 10;
            this.DidYouQuote_combobox.SelectedIndexChanged += new System.EventHandler(this.DidYouQuote_combobox_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(694, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(174, 132);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // DocTracker_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2409, 1581);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.DidYouQuote_combobox);
            this.Controls.Add(this.DidYouQuote_label);
            this.Controls.Add(this.whynotquoted_label);
            this.Controls.Add(this.NotQuotedNotes_richtextbox);
            this.Controls.Add(this.NotQuotedAdditionalNotes_richtextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstlastname_label);
            this.Controls.Add(this.firstlastname_textbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NotQuoted_label);
            this.Controls.Add(this.NotQuoted_combobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DocTracker_form";
            this.Text = "DocTracker_form";
            this.Load += new System.EventHandler(this.DocTracker_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstlastname_textbox;
        private System.Windows.Forms.Label firstlastname_label;
        private System.Windows.Forms.Label NotQuoted_label;
        private System.Windows.Forms.ComboBox NotQuoted_combobox;
        private System.Windows.Forms.RichTextBox NotQuotedAdditionalNotes_richtextbox;
        private System.Windows.Forms.RichTextBox NotQuotedNotes_richtextbox;
        private System.Windows.Forms.Label whynotquoted_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label DidYouQuote_label;
        private System.Windows.Forms.ComboBox DidYouQuote_combobox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}