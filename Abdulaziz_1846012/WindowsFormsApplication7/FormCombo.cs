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
    public partial class FormCombo : Form
    {
        public FormCombo()
        {
            InitializeComponent();

            cmbdays.Items.Add("Sunday");

            cmbdays.Items.Add("Monday");

            cmbdays.Items.Add("Tuesday");

            cmbdays.Items.Add("Wednesday");

            cmbdays.Items.Add("Thursday");

            cmbdays.Items.Add("Friday");

            cmbdays.Items.Add("Saturday");

            cmbdays.Items.Add("Funday");

            cmbdays.Items.Add("Examday");
        }

        private void cmdays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnshow1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbdays.Text);
        }

        private void btnRemoveByName_Click(object sender, EventArgs e)
        {
            
            cmbdays.Items.Remove("Friday");
        }

        private void btnRemveByIndex_Click(object sender, EventArgs e)
        {
            cmbdays.Items.RemoveAt(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnremoveLast_Click(object sender, EventArgs e)
        {
            cmbdays.Items.RemoveAt(cmbdays.Items.Count - 1);
            if (cmbdays.Items.Count >= 1)

            {

                cmbdays.Items.RemoveAt(cmbdays.Items.Count - 1);

            }

            else

            {

                MessageBox.Show("Can't remove last item");

            }
        }
    }
}