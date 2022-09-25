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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblTimeAnt = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(169, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 27);
            this.txtInput.TabIndex = 0;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(34, 30);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(67, 20);
            this.lblSeconds.TabIndex = 1;
            this.lblSeconds.Text = "Seconds:";
            // 
            // lblTimeAnt
            // 
            this.lblTimeAnt.AutoSize = true;
            this.lblTimeAnt.Location = new System.Drawing.Point(45, 181);
            this.lblTimeAnt.Name = "lblTimeAnt";
            this.lblTimeAnt.Size = new System.Drawing.Size(63, 20);
            this.lblTimeAnt.TabIndex = 2;
            this.lblTimeAnt.Text = "00:00:00";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(34, 141);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(172, 20);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "hours : minutes : seconds";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(34, 91);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(260, 29);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calculate TIme";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 282);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimeAnt);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Sequentie - assigmnent 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput;
        private Label lblSeconds;
        private Label lblTimeAnt;
        private Label lblTime;
        private Button btnCalc;
    }
}