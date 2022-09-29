namespace assignment6
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
            this.lblStartAmount = new System.Windows.Forms.Label();
            this.lblFinalCapital = new System.Windows.Forms.Label();
            this.lblFinalCapitalAns = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStartAmount
            // 
            this.lblStartAmount.AutoSize = true;
            this.lblStartAmount.Location = new System.Drawing.Point(38, 27);
            this.lblStartAmount.Name = "lblStartAmount";
            this.lblStartAmount.Size = new System.Drawing.Size(95, 20);
            this.lblStartAmount.TabIndex = 0;
            this.lblStartAmount.Text = "Start amount";
            // 
            // lblFinalCapital
            // 
            this.lblFinalCapital.AutoSize = true;
            this.lblFinalCapital.Location = new System.Drawing.Point(38, 145);
            this.lblFinalCapital.Name = "lblFinalCapital";
            this.lblFinalCapital.Size = new System.Drawing.Size(89, 20);
            this.lblFinalCapital.TabIndex = 1;
            this.lblFinalCapital.Text = "Final capital";
            // 
            // lblFinalCapitalAns
            // 
            this.lblFinalCapitalAns.AutoSize = true;
            this.lblFinalCapitalAns.Location = new System.Drawing.Point(306, 145);
            this.lblFinalCapitalAns.Name = "lblFinalCapitalAns";
            this.lblFinalCapitalAns.Size = new System.Drawing.Size(44, 20);
            this.lblFinalCapitalAns.TabIndex = 2;
            this.lblFinalCapitalAns.Text = "€0,00";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(225, 24);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 27);
            this.txtInput.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(38, 91);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(312, 29);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calculate final capital";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 222);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblFinalCapitalAns);
            this.Controls.Add(this.lblFinalCapital);
            this.Controls.Add(this.lblStartAmount);
            this.Name = "Form1";
            this.Text = "Iteration assignment 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStartAmount;
        private Label lblFinalCapital;
        private Label lblFinalCapitalAns;
        private TextBox txtInput;
        private Button btnCalc;
    }
}