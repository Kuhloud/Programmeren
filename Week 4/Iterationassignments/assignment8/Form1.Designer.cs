namespace assignment8
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblFormula1 = new System.Windows.Forms.Label();
            this.lblFormula2 = new System.Windows.Forms.Label();
            this.lblFormula1Ans = new System.Windows.Forms.Label();
            this.lblFormula2Ans = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(33, 31);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(132, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter a number (n)";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(33, 226);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(18, 20);
            this.lblCheck.TabIndex = 1;
            this.lblCheck.Text = "...";
            // 
            // lblFormula1
            // 
            this.lblFormula1.AutoSize = true;
            this.lblFormula1.Location = new System.Drawing.Point(33, 121);
            this.lblFormula1.Name = "lblFormula1";
            this.lblFormula1.Size = new System.Drawing.Size(141, 20);
            this.lblFormula1.TabIndex = 2;
            this.lblFormula1.Text = "sum = 1 + 2 + ... + n";
            // 
            // lblFormula2
            // 
            this.lblFormula2.AutoSize = true;
            this.lblFormula2.Location = new System.Drawing.Point(32, 157);
            this.lblFormula2.Name = "lblFormula2";
            this.lblFormula2.Size = new System.Drawing.Size(142, 20);
            this.lblFormula2.TabIndex = 3;
            this.lblFormula2.Text = "sum = n * (n + 1) / 2";
            // 
            // lblFormula1Ans
            // 
            this.lblFormula1Ans.AutoSize = true;
            this.lblFormula1Ans.Location = new System.Drawing.Point(283, 121);
            this.lblFormula1Ans.Name = "lblFormula1Ans";
            this.lblFormula1Ans.Size = new System.Drawing.Size(18, 20);
            this.lblFormula1Ans.TabIndex = 4;
            this.lblFormula1Ans.Text = "...";
            // 
            // lblFormula2Ans
            // 
            this.lblFormula2Ans.AutoSize = true;
            this.lblFormula2Ans.Location = new System.Drawing.Point(283, 157);
            this.lblFormula2Ans.Name = "lblFormula2Ans";
            this.lblFormula2Ans.Size = new System.Drawing.Size(18, 20);
            this.lblFormula2Ans.TabIndex = 5;
            this.lblFormula2Ans.Text = "...";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(33, 73);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(281, 29);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "&Compare";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(189, 31);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 27);
            this.txtInput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 272);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblFormula2Ans);
            this.Controls.Add(this.lblFormula1Ans);
            this.Controls.Add(this.lblFormula2);
            this.Controls.Add(this.lblFormula1);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.lblNumber);
            this.Name = "Form1";
            this.Text = "Iteration assignment 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumber;
        private Label lblCheck;
        private Label lblFormula1;
        private Label lblFormula2;
        private Label lblFormula1Ans;
        private Label lblFormula2Ans;
        private Button btnCalc;
        private TextBox txtInput;
    }
}