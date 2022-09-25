namespace assignment10
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
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPriceTicket = new System.Windows.Forms.Label();
            this.lblPriceTicketAns = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 33);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age";
            // 
            // lblPriceTicket
            // 
            this.lblPriceTicket.AutoSize = true;
            this.lblPriceTicket.Location = new System.Drawing.Point(12, 167);
            this.lblPriceTicket.Name = "lblPriceTicket";
            this.lblPriceTicket.Size = new System.Drawing.Size(81, 20);
            this.lblPriceTicket.TabIndex = 1;
            this.lblPriceTicket.Text = "Price ticket";
            // 
            // lblPriceTicketAns
            // 
            this.lblPriceTicketAns.AutoSize = true;
            this.lblPriceTicketAns.Location = new System.Drawing.Point(258, 167);
            this.lblPriceTicketAns.Name = "lblPriceTicketAns";
            this.lblPriceTicketAns.Size = new System.Drawing.Size(48, 20);
            this.lblPriceTicketAns.TabIndex = 2;
            this.lblPriceTicketAns.Text = "€ 0.00";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 111);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(331, 42);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "&Calculate Price";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(218, 33);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 27);
            this.txtInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 248);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblPriceTicketAns);
            this.Controls.Add(this.lblPriceTicket);
            this.Controls.Add(this.lblAge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAge;
        private Label lblPriceTicket;
        private Label lblPriceTicketAns;
        private Button btnCalc;
        private TextBox txtInput;
    }
}