
namespace WindowsFormsApplication7
{
    partial class FormF
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.ListRandom = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnModifyAnElement = new System.Windows.Forms.Button();
            this.BtnDisplayPropertiesMethods2D = new System.Windows.Forms.Button();
            this.BtnModifyAnArray = new System.Windows.Forms.Button();
            this.BtnDisplay2DForLoop = new System.Windows.Forms.Button();
            this.BtnDisplayPropertiesMethods1D = new System.Windows.Forms.Button();
            this.BtnDisplay1DForEachLoop = new System.Windows.Forms.Button();
            this.BtnDisplayRandomList = new System.Windows.Forms.Button();
            this.BtnDisplay1DForLoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(1, 171);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(60, 19);
            this.lblDisplay.TabIndex = 37;
            this.lblDisplay.Text = "Display";
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // ListRandom
            // 
            this.ListRandom.BackColor = System.Drawing.Color.White;
            this.ListRandom.FormattingEnabled = true;
            this.ListRandom.ItemHeight = 19;
            this.ListRandom.Location = new System.Drawing.Point(898, 27);
            this.ListRandom.Margin = new System.Windows.Forms.Padding(4);
            this.ListRandom.Name = "ListRandom";
            this.ListRandom.Size = new System.Drawing.Size(159, 441);
            this.ListRandom.TabIndex = 36;
            this.ListRandom.SelectedIndexChanged += new System.EventHandler(this.ListRandom_SelectedIndexChanged);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.LightGray;
            this.BtnExit.Location = new System.Drawing.Point(930, 515);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(127, 98);
            this.BtnExit.TabIndex = 35;
            this.BtnExit.Text = "Back";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.LightGray;
            this.BtnReset.Location = new System.Drawing.Point(729, 515);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(143, 98);
            this.BtnReset.TabIndex = 34;
            this.BtnReset.Text = "Reset All";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnModifyAnElement
            // 
            this.BtnModifyAnElement.BackColor = System.Drawing.Color.Silver;
            this.BtnModifyAnElement.Location = new System.Drawing.Point(672, 325);
            this.BtnModifyAnElement.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModifyAnElement.Name = "BtnModifyAnElement";
            this.BtnModifyAnElement.Size = new System.Drawing.Size(217, 110);
            this.BtnModifyAnElement.TabIndex = 33;
            this.BtnModifyAnElement.Text = "Modify An Element";
            this.BtnModifyAnElement.UseVisualStyleBackColor = false;
            this.BtnModifyAnElement.Click += new System.EventHandler(this.BtnModifyAnElement_Click);
            // 
            // BtnDisplayPropertiesMethods2D
            // 
            this.BtnDisplayPropertiesMethods2D.BackColor = System.Drawing.Color.Silver;
            this.BtnDisplayPropertiesMethods2D.Location = new System.Drawing.Point(470, 325);
            this.BtnDisplayPropertiesMethods2D.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDisplayPropertiesMethods2D.Name = "BtnDisplayPropertiesMethods2D";
            this.BtnDisplayPropertiesMethods2D.Size = new System.Drawing.Size(184, 110);
            this.BtnDisplayPropertiesMethods2D.TabIndex = 32;
            this.BtnDisplayPropertiesMethods2D.Text = "Display Properties and Methods of 2D Array";
            this.BtnDisplayPropertiesMethods2D.UseVisualStyleBackColor = false;
            this.BtnDisplayPropertiesMethods2D.Click += new System.EventHandler(this.BtnDisplayPropertiesMethods2D_Click);
            // 
            // BtnModifyAnArray
            // 
            this.BtnModifyAnArray.BackColor = System.Drawing.Color.Silver;
            this.BtnModifyAnArray.Location = new System.Drawing.Point(672, 166);
            this.BtnModifyAnArray.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModifyAnArray.Name = "BtnModifyAnArray";
            this.BtnModifyAnArray.Size = new System.Drawing.Size(200, 119);
            this.BtnModifyAnArray.TabIndex = 31;
            this.BtnModifyAnArray.Text = "Modify An Array";
            this.BtnModifyAnArray.UseVisualStyleBackColor = false;
            this.BtnModifyAnArray.Click += new System.EventHandler(this.BtnModifyAnArray_Click);
            // 
            // BtnDisplay2DForLoop
            // 
            this.BtnDisplay2DForLoop.BackColor = System.Drawing.Color.Silver;
            this.BtnDisplay2DForLoop.Location = new System.Drawing.Point(470, 171);
            this.BtnDisplay2DForLoop.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDisplay2DForLoop.Name = "BtnDisplay2DForLoop";
            this.BtnDisplay2DForLoop.Size = new System.Drawing.Size(184, 119);
            this.BtnDisplay2DForLoop.TabIndex = 30;
            this.BtnDisplay2DForLoop.Text = "Display 2D Array Using For Loop ";
            this.BtnDisplay2DForLoop.UseVisualStyleBackColor = false;
            this.BtnDisplay2DForLoop.Click += new System.EventHandler(this.BtnDisplay2DForLoop_Click);
            // 
            // BtnDisplayPropertiesMethods1D
            // 
            this.BtnDisplayPropertiesMethods1D.BackColor = System.Drawing.Color.Silver;
            this.BtnDisplayPropertiesMethods1D.Location = new System.Drawing.Point(672, 24);
            this.BtnDisplayPropertiesMethods1D.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDisplayPropertiesMethods1D.Name = "BtnDisplayPropertiesMethods1D";
            this.BtnDisplayPropertiesMethods1D.Size = new System.Drawing.Size(200, 109);
            this.BtnDisplayPropertiesMethods1D.TabIndex = 29;
            this.BtnDisplayPropertiesMethods1D.Text = "Display Properties and Methods of 1D Array";
            this.BtnDisplayPropertiesMethods1D.UseVisualStyleBackColor = false;
            this.BtnDisplayPropertiesMethods1D.Click += new System.EventHandler(this.BtnDisplayPropertiesMethods1D_Click);
            // 
            // BtnDisplay1DForEachLoop
            // 
            this.BtnDisplay1DForEachLoop.BackColor = System.Drawing.Color.Silver;
            this.BtnDisplay1DForEachLoop.Location = new System.Drawing.Point(239, 19);
            this.BtnDisplay1DForEachLoop.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDisplay1DForEachLoop.Name = "BtnDisplay1DForEachLoop";
            this.BtnDisplay1DForEachLoop.Size = new System.Drawing.Size(184, 109);
            this.BtnDisplay1DForEachLoop.TabIndex = 28;
            this.BtnDisplay1DForEachLoop.Text = "Display 1D Array Using For Each Loop";
            this.BtnDisplay1DForEachLoop.UseVisualStyleBackColor = false;
            this.BtnDisplay1DForEachLoop.Click += new System.EventHandler(this.BtnDisplay1DForEachLoop_Click);
            // 
            // BtnDisplayRandomList
            // 
            this.BtnDisplayRandomList.BackColor = System.Drawing.Color.Silver;
            this.BtnDisplayRandomList.Location = new System.Drawing.Point(454, 24);
            this.BtnDisplayRandomList.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDisplayRandomList.Name = "BtnDisplayRandomList";
            this.BtnDisplayRandomList.Size = new System.Drawing.Size(200, 114);
            this.BtnDisplayRandomList.TabIndex = 27;
            this.BtnDisplayRandomList.Text = "Display a Random Array in List Box";
            this.BtnDisplayRandomList.UseVisualStyleBackColor = false;
            this.BtnDisplayRandomList.Click += new System.EventHandler(this.BtnDisplayRandomList_Click);
            // 
            // BtnDisplay1DForLoop
            // 
            this.BtnDisplay1DForLoop.BackColor = System.Drawing.Color.Silver;
            this.BtnDisplay1DForLoop.Location = new System.Drawing.Point(22, 19);
            this.BtnDisplay1DForLoop.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDisplay1DForLoop.Name = "BtnDisplay1DForLoop";
            this.BtnDisplay1DForLoop.Size = new System.Drawing.Size(184, 104);
            this.BtnDisplay1DForLoop.TabIndex = 26;
            this.BtnDisplay1DForLoop.Text = "Display 1D Array Using For Loop ";
            this.BtnDisplay1DForLoop.UseVisualStyleBackColor = false;
            this.BtnDisplay1DForLoop.Click += new System.EventHandler(this.BtnDisplay1DForLoop_Click);
            // 
            // FormF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 641);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.ListRandom);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnModifyAnElement);
            this.Controls.Add(this.BtnDisplayPropertiesMethods2D);
            this.Controls.Add(this.BtnModifyAnArray);
            this.Controls.Add(this.BtnDisplay2DForLoop);
            this.Controls.Add(this.BtnDisplayPropertiesMethods1D);
            this.Controls.Add(this.BtnDisplay1DForEachLoop);
            this.Controls.Add(this.BtnDisplayRandomList);
            this.Controls.Add(this.BtnDisplay1DForLoop);
            this.Name = "FormF";
            this.Text = "FormF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.ListBox ListRandom;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnModifyAnElement;
        private System.Windows.Forms.Button BtnDisplayPropertiesMethods2D;
        private System.Windows.Forms.Button BtnModifyAnArray;
        private System.Windows.Forms.Button BtnDisplay2DForLoop;
        private System.Windows.Forms.Button BtnDisplayPropertiesMethods1D;
        private System.Windows.Forms.Button BtnDisplay1DForEachLoop;
        private System.Windows.Forms.Button BtnDisplayRandomList;
        private System.Windows.Forms.Button BtnDisplay1DForLoop;
    }
}