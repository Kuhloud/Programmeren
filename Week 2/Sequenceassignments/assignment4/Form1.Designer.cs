namespace assignment4
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAnt = new System.Windows.Forms.Button();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.lblPrijsAnt = new System.Windows.Forms.Label();
            this.lblVATAnt = new System.Windows.Forms.Label();
            this.lblTotaalAnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(22, 52);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(95, 20);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Enter a price:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(196, 52);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 27);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(22, 109);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(299, 29);
            this.btnAnt.TabIndex = 2;
            this.btnAnt.Text = "&Determine VAT";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(22, 186);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(44, 20);
            this.lblPrijs.TabIndex = 3;
            this.lblPrijs.Text = "Price:";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(22, 247);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(37, 20);
            this.lblVAT.TabIndex = 4;
            this.lblVAT.Text = "VAT:";
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(22, 306);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(45, 20);
            this.lblTotaal.TabIndex = 5;
            this.lblTotaal.Text = "Total:";
            // 
            // lblPrijsAnt
            // 
            this.lblPrijsAnt.AutoSize = true;
            this.lblPrijsAnt.Location = new System.Drawing.Point(285, 186);
            this.lblPrijsAnt.Name = "lblPrijsAnt";
            this.lblPrijsAnt.Size = new System.Drawing.Size(36, 20);
            this.lblPrijsAnt.TabIndex = 6;
            this.lblPrijsAnt.Text = "0.00";
            // 
            // lblVATAnt
            // 
            this.lblVATAnt.AutoSize = true;
            this.lblVATAnt.Location = new System.Drawing.Point(285, 247);
            this.lblVATAnt.Name = "lblVATAnt";
            this.lblVATAnt.Size = new System.Drawing.Size(36, 20);
            this.lblVATAnt.TabIndex = 7;
            this.lblVATAnt.Text = "0.00";
            // 
            // lblTotaalAnt
            // 
            this.lblTotaalAnt.AutoSize = true;
            this.lblTotaalAnt.Location = new System.Drawing.Point(285, 306);
            this.lblTotaalAnt.Name = "lblTotaalAnt";
            this.lblTotaalAnt.Size = new System.Drawing.Size(36, 20);
            this.lblTotaalAnt.TabIndex = 8;
            this.lblTotaalAnt.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 356);
            this.Controls.Add(this.lblTotaalAnt);
            this.Controls.Add(this.lblVATAnt);
            this.Controls.Add(this.lblPrijsAnt);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.Text = "Sequence - assignment 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private Label lblPrijs;
        private Label lblVAT;
        private Label lblTotaal;
        private Label lblPrijsAnt;
        private Label lblVATAnt;
        private Label lblTotaalAnt;
        public Button btnAnt;
    }
}