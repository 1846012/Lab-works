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
    public partial class FormF : Form
    {

        Random rnd = new Random();
        int[] b = new int[500];

        Int32[] iArray1 = new Int32[5];
        Int32[] iArray2 = new Int32[5];
        Int32[] iArray3 = new Int32[5] { 21, 22, 23, 24, 25 };
        Int32[] iArray4 = new Int32[] { 11, 12, 13, 14, 15 };
        Int32[] iArray5 = { 31, 32, 33, 34, 35 };

        int[,] iArray55 = new int[5, 5];
        int[,,] iArray345 = new int[3, 4, 5];
        int[,] iArray32 = new int[3, 2]
            {
            {1,2},
            {3,4},
            {5,6}
            };
        public FormF()
        {
            InitializeComponent();
        }

        private void frmArray_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void BtnDisplayRandomList_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Some Methods and Properties of Random Array b :";
            ListRandom.Items.Clear();
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(500, 1000);
                ListRandom.Items.Add(b[i]);
            }
            lblDisplay.Text = lblDisplay.Text + "\n" + "Min of Random Array b is:" + b.Min();
            lblDisplay.Text = lblDisplay.Text + "\n" + "Max of Random Array b is:" + b.Max();
            lblDisplay.Text = lblDisplay.Text + "\n" + "Sum of Random Array b is:" + b.Sum();
            lblDisplay.Text = lblDisplay.Text + "\n" + "Average of Random Array b is:" + b.Average();
        }

        private void BtnDisplay1DForLoop_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "1D Array named iArray3 using for loop";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);
            }
        }

        private void BtnDisplay1DForEachLoop_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "1D Array named iArray5 using foreach loop";
            foreach (Int32 j in iArray5)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(j);
            }
        }

        private void BtnDisplayPropertiesMethods1D_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Some Methods and Properties";

            // Some Methods of Array 
            lblDisplay.Text = lblDisplay.Text + "\n" + "Min of iArray5 is:" + iArray5.Min();
            lblDisplay.Text = lblDisplay.Text + "\n" + "Max of iArray5 is:" + iArray5.Max();
            lblDisplay.Text = lblDisplay.Text + "\n" + "Sum of iArray5 is:" + iArray5.Sum();

            // Some Properties of Array 
            lblDisplay.Text = lblDisplay.Text + "\n" + "Rank of iArray5 is:" + iArray5.Rank;
            lblDisplay.Text = lblDisplay.Text + "\n" + "Length of iArray5 is:" + iArray5.Length;

        }

        private void BtnDisplay2DForLoop_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "2D Array named iArray32 using nested for loop";
            for (int i = 1; i < 4; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n";
                for (int j = 1; j < 3; j++)
                {
                    lblDisplay.Text = lblDisplay.Text + " " + Convert.ToString(iArray32[i - 1, j - 1]);
                }
            }
        }

        private void BtnDisplayPropertiesMethods2D_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Some Methods and Properties:";


            lblDisplay.Text = lblDisplay.Text + "\n" + "Rank of iArray23 is:" + iArray32.Rank;   // Dimensions
            lblDisplay.Text = lblDisplay.Text + "\n" + "Length of iArray23 is:" + iArray32.Length;// Length: Total number of elements in all dimensions


            lblDisplay.Text = lblDisplay.Text + "\n" + "Number of Rows of  of iArray23 is:" + iArray32.GetLength(0);
            lblDisplay.Text = lblDisplay.Text + "\n" + "Number of Columns of iArray23 is:" + iArray32.GetLength(1);


        }

        private void BtnModifyAnArray_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "1D Array named iArray3 has \n following values BEFORE MODIFICATION";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);

            }

            ModifyArray(iArray3);

            lblDisplay.Text = lblDisplay.Text + "\n\n" + "1D Array named iArray3 has \n following values AFTER MODIFICATION";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);

            }
        }

        void ModifyArray(Int32[] MyArray)
        {
            for (Int32 i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = MyArray[i] + 10;
            }
        }
        void ModifyElement(int AnElement)
        {
            AnElement = AnElement + 10;

            lblDisplay.Text = lblDisplay.Text + "\n\n" + "Value of Element from inside the called method is: " + AnElement;

        }

        private void BtnModifyAnElement_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "1D Array named iArray3 has \n following values BEFORE MODIFICATION of ELEMENT#3";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);

            }

            ModifyElement(iArray3[2]);

            lblDisplay.Text = lblDisplay.Text + "\n\n" + "1D Array named iArray3 has \n following values AFTER MODIFICATION of ELEMENT#3";
            for (Int32 i = 0; i < 5; i++)
            {
                lblDisplay.Text = lblDisplay.Text + "\n" + Convert.ToString(iArray3[i]);

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BtnReset_Click(object sender, EventArgs e)
        {
            ListRandom.Items.Clear();

            //1D Arrays


            Int32[] iArray3 = { 21, 22, 23, 24, 25 };//RECOMMENDED WAY:Declaration, Definition & Initialization
            Int32[] iArray4 = new Int32[] { 11, 12, 13, 14, 15 }; //Declaration, Definition & Initialization (can omit size value only if initialization)           
            Int32[] iArray5 = { 31, 32, 33, 34, 35 };//Declaration, Definition & Initialization (can omit new keyword only if initialization) 

            //2D Arrays
            int[,] iArray55 = new int[5, 5]; //Declaration and Definition of 2D array 
            int[,,] iArray345 = new int[3, 4, 5]; //Declaration and Definition of 3D array

            int[,] iArray32 = new int[3, 2]
                                    {
                                         { 1, 2 },
                                         { 3, 4 },
                                         { 5, 6 }
                                    }; //Declaration,Definition & Initialization of 2D array


            //Array to be filled with Random numbers
            Random rnd = new Random();
            int[] b = new int[500];

        }

        private void ListRandom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}
