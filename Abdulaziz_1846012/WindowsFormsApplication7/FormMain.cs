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
    public partial class akn : Form
    {
        public akn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
            MessageBox.Show("login successfully");
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void btncobo_Click(object sender, EventArgs e)
        {
            FormCombo frm = new FormCombo();
            frm.ShowDialog();
        }

        private void btnfood_Click(object sender, EventArgs e)
        {
            frmcheck frm = new frmcheck();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmArray frm = new FrmArray();
            frm.ShowDialog();
        }

        private void BtniArrayz_Click(object sender, EventArgs e)
        {
            FormF frm = new FormF();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.ShowDialog();
        }
    }
}
