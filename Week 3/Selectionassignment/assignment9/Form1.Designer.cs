namespace assignment9
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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.lblSport = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblFeeAns = new System.Windows.Forms.Label();
            this.radFootball = new System.Windows.Forms.RadioButton();
            this.radHandball = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(347, 140);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(125, 27);
            this.txtInput1.TabIndex = 0;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(347, 173);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(125, 27);
            this.txtInput2.TabIndex = 1;
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(92, 64);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(45, 20);
            this.lblSport.TabIndex = 2;
            this.lblSport.Text = "Sport";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(92, 140);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(92, 176);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(152, 20);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Membership duration";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(92, 345);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(105, 20);
            this.lblFee.TabIndex = 5;
            this.lblFee.Text = "Fee to be paid";
            // 
            // lblFeeAns
            // 
            this.lblFeeAns.AutoSize = true;
            this.lblFeeAns.Location = new System.Drawing.Point(399, 345);
            this.lblFeeAns.Name = "lblFeeAns";
            this.lblFeeAns.Size = new System.Drawing.Size(48, 20);
            this.lblFeeAns.TabIndex = 6;
            this.lblFeeAns.Text = "€ 0,00";
            // 
            // radFootball
            // 
            this.radFootball.AutoSize = true;
            this.radFootball.Location = new System.Drawing.Point(347, 60);
            this.radFootball.Name = "radFootball";
            this.radFootball.Size = new System.Drawing.Size(85, 24);
            this.radFootball.TabIndex = 7;
            this.radFootball.TabStop = true;
            this.radFootball.Text = "Football";
            this.radFootball.UseVisualStyleBackColor = true;
            // 
            // radHandball
            // 
            this.radHandball.AutoSize = true;
            this.radHandball.Location = new System.Drawing.Point(347, 88);
            this.radHandball.Name = "radHandball";
            this.radHandball.Size = new System.Drawing.Size(91, 24);
            this.radHandball.TabIndex = 8;
            this.radHandball.TabStop = true;
            this.radHandball.Text = "Handball";
            this.radHandball.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(92, 254);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(380, 49);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "&Calculate Fee";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 409);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.radHandball);
            this.Controls.Add(this.radFootball);
            this.Controls.Add(this.lblFeeAns);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSport);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput1;
        private TextBox txtInput2;
        private Label lblSport;
        private Label lblAge;
        private Label lblDuration;
        private Label lblFee;
        private Label lblFeeAns;
        private RadioButton radFootball;
        private RadioButton radHandball;
        private Button btnCalc;
    }
}