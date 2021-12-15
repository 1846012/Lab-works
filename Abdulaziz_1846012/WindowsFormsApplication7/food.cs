using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class frmcheck : Form
    {
        public frmcheck()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if(checkcoffe.Checked == true)
            {
                msg = checkcoffe.Text;
            }

            if (checkdounat.Checked == true)
            {
                msg = msg+" "+ checkdounat.Text;

            }

            if (checkbrowne.Checked == true)
            {
                msg = msg+" "+ checkbrowne.Text;
            }

            if(msg.Length > 0)
            {
                MessageBox.Show(msg + " "+ "selected");


            }

            else
            {
                MessageBox.Show("nothing selected");
            }

        }

        private void checkcoffe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnback2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void food_Load(object sender, EventArgs e)
        {

        }
    }
}
