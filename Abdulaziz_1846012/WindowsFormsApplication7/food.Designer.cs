
namespace WindowsFormsApplication7
{
    partial class frmcheck
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
            this.btnshow = new System.Windows.Forms.Button();
            this.btnback2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkbrowne = new System.Windows.Forms.CheckBox();
            this.checkdounat = new System.Windows.Forms.CheckBox();
            this.checkcoffe = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(306, 74);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(89, 38);
            this.btnshow.TabIndex = 0;
            this.btnshow.Text = "show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnback2
            // 
            this.btnback2.Location = new System.Drawing.Point(629, 382);
            this.btnback2.Name = "btnback2";
            this.btnback2.Size = new System.Drawing.Size(95, 42);
            this.btnback2.TabIndex = 1;
            this.btnback2.Text = "Back";
            this.btnback2.UseVisualStyleBackColor = true;
            this.btnback2.Click += new System.EventHandler(this.btnback2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkbrowne);
            this.groupBox1.Controls.Add(this.checkdounat);
            this.groupBox1.Controls.Add(this.checkcoffe);
            this.groupBox1.Location = new System.Drawing.Point(394, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // checkbrowne
            // 
            this.checkbrowne.AutoSize = true;
            this.checkbrowne.Location = new System.Drawing.Point(25, 141);
            this.checkbrowne.Name = "checkbrowne";
            this.checkbrowne.Size = new System.Drawing.Size(88, 23);
            this.checkbrowne.TabIndex = 2;
            this.checkbrowne.Text = "Browne";
            this.checkbrowne.UseVisualStyleBackColor = true;
            // 
            // checkdounat
            // 
            this.checkdounat.AutoSize = true;
            this.checkdounat.Location = new System.Drawing.Point(25, 95);
            this.checkdounat.Name = "checkdounat";
            this.checkdounat.Size = new System.Drawing.Size(86, 23);
            this.checkdounat.TabIndex = 1;
            this.checkdounat.Text = "Dounat";
            this.checkdounat.UseVisualStyleBackColor = true;
            // 
            // checkcoffe
            // 
            this.checkcoffe.AutoSize = true;
            this.checkcoffe.Location = new System.Drawing.Point(25, 49);
            this.checkcoffe.Name = "checkcoffe";
            this.checkcoffe.Size = new System.Drawing.Size(72, 23);
            this.checkcoffe.TabIndex = 0;
            this.checkcoffe.Text = "Coffe";
            this.checkcoffe.UseVisualStyleBackColor = true;
            this.checkcoffe.CheckedChanged += new System.EventHandler(this.checkcoffe_CheckedChanged);
            // 
            // frmcheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnback2);
            this.Controls.Add(this.btnshow);
            this.Name = "frmcheck";
            this.Text = "food";
            this.Load += new System.EventHandler(this.food_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnback2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkbrowne;
        private System.Windows.Forms.CheckBox checkdounat;
        private System.Windows.Forms.CheckBox checkcoffe;
    }
}