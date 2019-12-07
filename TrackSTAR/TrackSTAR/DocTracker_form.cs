using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackSTAR
{
    public partial class DocTracker_form : Form
    {
        public DocTracker_form()
        {
            InitializeComponent();
        }

        private void DocTracker_form_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            NotQuotedNotes_richtextbox.Text = "Spoke To:" + firstlastname_textbox.Text + Environment.NewLine + NotQuoted_combobox.Text + NotQuotedAdditionalNotes_richtextbox.Text;
        }

        private void NotQuoted_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void DidYouQuote_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string da = DidYouQuote_combobox.Text.ToString();
            if (da == "No")
            { flowLayoutPanel1.Show(); }
            if (da == "Yes")
            { flowLayoutPanel1.Hide(); }
            if (da == "")
            { flowLayoutPanel1.Hide(); }

        }
    }
}
