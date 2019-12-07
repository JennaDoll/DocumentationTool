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
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void DocTracker_button_Click(object sender, EventArgs e)
        {
            DocTracker_form DocTracker_form = new DocTracker_form();
            DocTracker_form.Show();
            this.Hide();

        }

    }
}
