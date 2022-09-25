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
            this.lblTshirts = new System.Windows.Forms.Label();
            this.lblJeans = new System.Windows.Forms.Label();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.lblNiks1 = new System.Windows.Forms.Label();
            this.lblNiks2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalAnt = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblVatAnt = new System.Windows.Forms.Label();
            this.lblPriceAnt = new System.Windows.Forms.Label();
            this.lblDateAnt = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTshirts
            // 
            this.lblTshirts.AutoSize = true;
            this.lblTshirts.Location = new System.Drawing.Point(24, 26);
            this.lblTshirts.Name = "lblTshirts";
            this.lblTshirts.Size = new System.Drawing.Size(208, 20);
            this.lblTshirts.TabIndex = 0;
            this.lblTshirts.Text = "Number of T-shirts (x € 30.00):";
            // 
            // lblJeans
            // 
            this.lblJeans.AutoSize = true;
            this.lblJeans.Location = new System.Drawing.Point(24, 78);
            this.lblJeans.Name = "lblJeans";
            this.lblJeans.Size = new System.Drawing.Size(202, 20);
            this.lblJeans.TabIndex = 1;
            this.lblJeans.Text = "Number of jeans (x € 100.00):";
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(288, 19);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(125, 27);
            this.txtInput1.TabIndex = 2;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(288, 71);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(125, 27);
            this.txtInput2.TabIndex = 3;
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.lblNiks1);
            this.grpInvoice.Controls.Add(this.lblNiks2);
            this.grpInvoice.Controls.Add(this.lblTotal);
            this.grpInvoice.Controls.Add(this.lblTotalAnt);
            this.grpInvoice.Controls.Add(this.lblVat);
            this.grpInvoice.Controls.Add(this.lblPrice);
            this.grpInvoice.Controls.Add(this.lblVatAnt);
            this.grpInvoice.Controls.Add(this.lblPriceAnt);
            this.grpInvoice.Controls.Add(this.lblDateAnt);
            this.grpInvoice.Controls.Add(this.lblDate);
            this.grpInvoice.Location = new System.Drawing.Point(24, 187);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(389, 242);
            this.grpInvoice.TabIndex = 4;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "Invoice";
            // 
            // lblNiks1
            // 
            this.lblNiks1.AutoSize = true;
            this.lblNiks1.Location = new System.Drawing.Point(226, 36);
            this.lblNiks1.Name = "lblNiks1";
            this.lblNiks1.Size = new System.Drawing.Size(63, 20);
            this.lblNiks1.TabIndex = 14;
            this.lblNiks1.Text = "00:00:00";
            // 
            // lblNiks2
            // 
            this.lblNiks2.AutoSize = true;
            this.lblNiks2.Location = new System.Drawing.Point(289, 36);
            this.lblNiks2.Name = "lblNiks2";
            this.lblNiks2.Size = new System.Drawing.Size(81, 20);
            this.lblNiks2.TabIndex = 13;
            this.lblNiks2.Text = "dd/mm/jjjj";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(30, 183);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total price:";
            // 
            // lblTotalAnt
            // 
            this.lblTotalAnt.AutoSize = true;
            this.lblTotalAnt.Location = new System.Drawing.Point(291, 183);
            this.lblTotalAnt.Name = "lblTotalAnt";
            this.lblTotalAnt.Size = new System.Drawing.Size(48, 20);
            this.lblTotalAnt.TabIndex = 9;
            this.lblTotalAnt.Text = "€ 0.00";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(30, 131);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(37, 20);
            this.lblVat.TabIndex = 6;
            this.lblVat.Text = "VAT:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 86);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
            // 
            // lblVatAnt
            // 
            this.lblVatAnt.AutoSize = true;
            this.lblVatAnt.Location = new System.Drawing.Point(291, 131);
            this.lblVatAnt.Name = "lblVatAnt";
            this.lblVatAnt.Size = new System.Drawing.Size(48, 20);
            this.lblVatAnt.TabIndex = 10;
            this.lblVatAnt.Text = "€ 0.00";
            // 
            // lblPriceAnt
            // 
            this.lblPriceAnt.AutoSize = true;
            this.lblPriceAnt.Location = new System.Drawing.Point(291, 86);
            this.lblPriceAnt.Name = "lblPriceAnt";
            this.lblPriceAnt.Size = new System.Drawing.Size(48, 20);
            this.lblPriceAnt.TabIndex = 11;
            this.lblPriceAnt.Text = "€ 0.00";
            // 
            // lblDateAnt
            // 
            this.lblDateAnt.AutoSize = true;
            this.lblDateAnt.Location = new System.Drawing.Point(220, 36);
            this.lblDateAnt.Name = "lblDateAnt";
            this.lblDateAnt.Size = new System.Drawing.Size(0, 20);
            this.lblDateAnt.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(30, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(24, 122);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(389, 49);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpInvoice);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.lblJeans);
            this.Controls.Add(this.lblTshirts);
            this.Name = "Form1";
            this.Text = "Sequence - assignment 8";
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTshirts;
        private Label lblJeans;
        private TextBox txtInput1;
        private TextBox txtInput2;
        private GroupBox grpInvoice;
        private Label lblDateAnt;
        private Label lblDate;
        private Label lblVat;
        private Label lblPrice;
        private Label lblTotal;
        private Label lblTotalAnt;
        private Label lblVatAnt;
        private Label lblPriceAnt;
        private Button btnCalc;
        private Label lblNiks1;
        private Label lblNiks2;
    }
}