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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
           if( rdoRed.Checked==true)
               rdoRed.ForeColor = Color.FromName("red");
           else
               rdoRed.ForeColor = Color.FromName("black");
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen.Checked == true)
                rdoGreen.ForeColor = Color.FromName("green");
            else
                rdoGreen.ForeColor = Color.FromName("black");
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue.Checked == true)
                rdoBlue.ForeColor = Color.FromName("blue");
            else
                rdoBlue.ForeColor = Color.FromName("black");
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow.Checked == true)
                rdoYellow.ForeColor = Color.FromName("yellow");
            else
                rdoYellow.ForeColor = Color.FromName("black");
        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            RdoRed2.ForeColor = Color.FromName("red");
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            RdoGreen2.ForeColor = Color.FromName("green");
        }

        private void RodBlue2_CheckedChanged(object sender, EventArgs e)
        {
            RodBlue2.ForeColor = Color.FromName("blue");
        }

        private void RodYellow2_CheckedChanged(object sender, EventArgs e)
        {
            RodYellow2.ForeColor = Color.FromName("yellow");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoRed.Checked = false;
            rdoGreen.Checked = false;
            rdoBlue.Checked = false;
            rdoYellow.Checked = false;

            rdoRed.ForeColor = Color.FromName("black");
            rdoGreen.ForeColor = Color.FromName("black");
            rdoBlue.ForeColor = Color.FromName("black");
            rdoYellow.ForeColor = Color.FromName("black");
            
        }
    }
}
