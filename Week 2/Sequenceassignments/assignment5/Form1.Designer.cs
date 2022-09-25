namespace assignment5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblAverageAnt = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(12, 242);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(64, 20);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.Text = "Average";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(12, 17);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(78, 20);
            this.lblN1.TabIndex = 1;
            this.lblN1.Text = "Number 1:";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(12, 83);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(78, 20);
            this.lblN2.TabIndex = 2;
            this.lblN2.Text = "Number 2:";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(12, 145);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(78, 20);
            this.lblN3.TabIndex = 3;
            this.lblN3.Text = "Number 3:";
            // 
            // lblAverageAnt
            // 
            this.lblAverageAnt.AutoSize = true;
            this.lblAverageAnt.Location = new System.Drawing.Point(201, 242);
            this.lblAverageAnt.Name = "lblAverageAnt";
            this.lblAverageAnt.Size = new System.Drawing.Size(44, 20);
            this.lblAverageAnt.TabIndex = 4;
            this.lblAverageAnt.Text = "0.000";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 185);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(352, 29);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "&Calculate average";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtInput3
            // 
            this.txtInput3.Location = new System.Drawing.Point(239, 142);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(125, 27);
            this.txtInput3.TabIndex = 6;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(239, 83);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(125, 27);
            this.txtInput2.TabIndex = 7;
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(239, 17);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(125, 27);
            this.txtInput1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 289);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblAverageAnt);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.lblAverage);
            this.Name = "Form1";
            this.Text = "Sequence - assignment 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAverage;
        private Label lblN1;
        private Label lblN2;
        private Label lblN3;
        private Label lblAverageAnt;
        private Button btnCalc;
        private TextBox txtInput3;
        private TextBox txtInput2;
        private TextBox txtInput1;
    }
}