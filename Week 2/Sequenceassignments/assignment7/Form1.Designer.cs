namespace assignment7
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
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.lblSkm = new System.Windows.Forms.Label();
            this.lblEkm = new System.Windows.Forms.Label();
            this.lblPkm = new System.Windows.Forms.Label();
            this.lblVatPriceAnt = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblVatPrice = new System.Windows.Forms.Label();
            this.lblPriceAnt = new System.Windows.Forms.Label();
            this.lblVatAnt = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(144, 17);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(125, 27);
            this.txtInput1.TabIndex = 0;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(144, 50);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(125, 27);
            this.txtInput2.TabIndex = 1;
            // 
            // txtInput3
            // 
            this.txtInput3.Location = new System.Drawing.Point(144, 83);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(125, 27);
            this.txtInput3.TabIndex = 2;
            // 
            // lblSkm
            // 
            this.lblSkm.AutoSize = true;
            this.lblSkm.Location = new System.Drawing.Point(12, 17);
            this.lblSkm.Name = "lblSkm";
            this.lblSkm.Size = new System.Drawing.Size(64, 20);
            this.lblSkm.TabIndex = 3;
            this.lblSkm.Text = "Start km";
            // 
            // lblEkm
            // 
            this.lblEkm.AutoSize = true;
            this.lblEkm.Location = new System.Drawing.Point(12, 50);
            this.lblEkm.Name = "lblEkm";
            this.lblEkm.Size = new System.Drawing.Size(58, 20);
            this.lblEkm.TabIndex = 4;
            this.lblEkm.Text = "End km";
            // 
            // lblPkm
            // 
            this.lblPkm.AutoSize = true;
            this.lblPkm.Location = new System.Drawing.Point(12, 83);
            this.lblPkm.Name = "lblPkm";
            this.lblPkm.Size = new System.Drawing.Size(75, 20);
            this.lblPkm.TabIndex = 5;
            this.lblPkm.Text = "Price / km";
            // 
            // lblVatPriceAnt
            // 
            this.lblVatPriceAnt.AutoSize = true;
            this.lblVatPriceAnt.Location = new System.Drawing.Point(326, 199);
            this.lblVatPriceAnt.Name = "lblVatPriceAnt";
            this.lblVatPriceAnt.Size = new System.Drawing.Size(36, 20);
            this.lblVatPriceAnt.TabIndex = 6;
            this.lblVatPriceAnt.Text = "0.00";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 149);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 20);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price excl VAT";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(133, 149);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(34, 20);
            this.lblVAT.TabIndex = 8;
            this.lblVAT.Text = "VAT";
            // 
            // lblVatPrice
            // 
            this.lblVatPrice.AutoSize = true;
            this.lblVatPrice.Location = new System.Drawing.Point(326, 149);
            this.lblVatPrice.Name = "lblVatPrice";
            this.lblVatPrice.Size = new System.Drawing.Size(97, 20);
            this.lblVatPrice.TabIndex = 9;
            this.lblVatPrice.Text = "Price incl VAT";
            // 
            // lblPriceAnt
            // 
            this.lblPriceAnt.AutoSize = true;
            this.lblPriceAnt.Location = new System.Drawing.Point(20, 199);
            this.lblPriceAnt.Name = "lblPriceAnt";
            this.lblPriceAnt.Size = new System.Drawing.Size(36, 20);
            this.lblPriceAnt.TabIndex = 10;
            this.lblPriceAnt.Text = "0.00";
            // 
            // lblVatAnt
            // 
            this.lblVatAnt.AutoSize = true;
            this.lblVatAnt.Location = new System.Drawing.Point(133, 199);
            this.lblVatAnt.Name = "lblVatAnt";
            this.lblVatAnt.Size = new System.Drawing.Size(36, 20);
            this.lblVatAnt.TabIndex = 11;
            this.lblVatAnt.Text = "0.00";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(296, 83);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(94, 29);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(296, 17);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(94, 29);
            this.btnErase.TabIndex = 13;
            this.btnErase.Text = "&Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 285);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblVatAnt);
            this.Controls.Add(this.lblPriceAnt);
            this.Controls.Add(this.lblVatPrice);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblVatPriceAnt);
            this.Controls.Add(this.lblPkm);
            this.Controls.Add(this.lblEkm);
            this.Controls.Add(this.lblSkm);
            this.Controls.Add(this.txtInput3);
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
        private TextBox txtInput3;
        private Label lblSkm;
        private Label lblEkm;
        private Label lblPkm;
        private Label lblVatPriceAnt;
        private Label lblPrice;
        private Label lblVAT;
        private Label lblVatPrice;
        private Label lblPriceAnt;
        private Label lblVatAnt;
        private Button btnCalc;
        private Button btnErase;
    }
}