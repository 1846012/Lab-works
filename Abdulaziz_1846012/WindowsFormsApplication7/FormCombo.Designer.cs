
namespace WindowsFormsApplication7
{
    partial class FormCombo
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
            this.cmbdays = new System.Windows.Forms.ComboBox();
            this.btnshow1 = new System.Windows.Forms.Button();
            this.btnRemoveByName = new System.Windows.Forms.Button();
            this.btnRemveByIndex = new System.Windows.Forms.Button();
            this.butnbackCombo = new System.Windows.Forms.Button();
            this.btnremoveLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbdays
            // 
            this.cmbdays.FormattingEnabled = true;
            this.cmbdays.Location = new System.Drawing.Point(77, 180);
            this.cmbdays.Name = "cmbdays";
            this.cmbdays.Size = new System.Drawing.Size(121, 27);
            this.cmbdays.TabIndex = 0;
            this.cmbdays.SelectedIndexChanged += new System.EventHandler(this.cmdays_SelectedIndexChanged);
            // 
            // btnshow1
            // 
            this.btnshow1.Location = new System.Drawing.Point(44, 45);
            this.btnshow1.Name = "btnshow1";
            this.btnshow1.Size = new System.Drawing.Size(193, 38);
            this.btnshow1.TabIndex = 2;
            this.btnshow1.Text = "show slected";
            this.btnshow1.UseVisualStyleBackColor = true;
            this.btnshow1.Click += new System.EventHandler(this.btnshow1_Click);
            // 
            // btnRemoveByName
            // 
            this.btnRemoveByName.Location = new System.Drawing.Point(356, 47);
            this.btnRemoveByName.Name = "btnRemoveByName";
            this.btnRemoveByName.Size = new System.Drawing.Size(173, 36);
            this.btnRemoveByName.TabIndex = 3;
            this.btnRemoveByName.Text = "remove by name";
            this.btnRemoveByName.UseVisualStyleBackColor = true;
            this.btnRemoveByName.Click += new System.EventHandler(this.btnRemoveByName_Click);
            // 
            // btnRemveByIndex
            // 
            this.btnRemveByIndex.Location = new System.Drawing.Point(614, 45);
            this.btnRemveByIndex.Name = "btnRemveByIndex";
            this.btnRemveByIndex.Size = new System.Drawing.Size(159, 38);
            this.btnRemveByIndex.TabIndex = 4;
            this.btnRemveByIndex.Text = "remove by number";
            this.btnRemveByIndex.UseVisualStyleBackColor = true;
            this.btnRemveByIndex.Click += new System.EventHandler(this.btnRemveByIndex_Click);
            // 
            // butnbackCombo
            // 
            this.butnbackCombo.Location = new System.Drawing.Point(614, 350);
            this.butnbackCombo.Name = "butnbackCombo";
            this.butnbackCombo.Size = new System.Drawing.Size(126, 49);
            this.butnbackCombo.TabIndex = 5;
            this.butnbackCombo.Text = "back";
            this.butnbackCombo.UseVisualStyleBackColor = true;
            this.butnbackCombo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnremoveLast
            // 
            this.btnremoveLast.Location = new System.Drawing.Point(344, 155);
            this.btnremoveLast.Name = "btnremoveLast";
            this.btnremoveLast.Size = new System.Drawing.Size(185, 75);
            this.btnremoveLast.TabIndex = 6;
            this.btnremoveLast.Text = "remove last";
            this.btnremoveLast.UseVisualStyleBackColor = true;
            this.btnremoveLast.Click += new System.EventHandler(this.btnremoveLast_Click);
            // 
            // frmcombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnremoveLast);
            this.Controls.Add(this.butnbackCombo);
            this.Controls.Add(this.btnRemveByIndex);
            this.Controls.Add(this.btnRemoveByName);
            this.Controls.Add(this.btnshow1);
            this.Controls.Add(this.cmbdays);
            this.Name = "frmcombo";
            this.Text = "combo form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbdays;
        private System.Windows.Forms.Button btnshow1;
        private System.Windows.Forms.Button btnRemoveByName;
        private System.Windows.Forms.Button btnRemveByIndex;
        private System.Windows.Forms.Button butnbackCombo;
        private System.Windows.Forms.Button btnremoveLast;
    }
}