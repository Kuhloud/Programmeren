namespace Opgave5
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
            this.lblClass = new System.Windows.Forms.Label();
            this.lblAmountOfPassengers = new System.Windows.Forms.Label();
            this.lblAmountOfRailrunners = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.radSecondClass = new System.Windows.Forms.RadioButton();
            this.radFirstClass = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtInputAmount = new System.Windows.Forms.TextBox();
            this.txtInputRailrunners = new System.Windows.Forms.TextBox();
            this.txtOutputPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(12, 9);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(53, 20);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Klasse:";
            // 
            // lblAmountOfPassengers
            // 
            this.lblAmountOfPassengers.AutoSize = true;
            this.lblAmountOfPassengers.Location = new System.Drawing.Point(12, 40);
            this.lblAmountOfPassengers.Name = "lblAmountOfPassengers";
            this.lblAmountOfPassengers.Size = new System.Drawing.Size(55, 20);
            this.lblAmountOfPassengers.TabIndex = 1;
            this.lblAmountOfPassengers.Text = "Aantal:";
            // 
            // lblAmountOfRailrunners
            // 
            this.lblAmountOfRailrunners.AutoSize = true;
            this.lblAmountOfRailrunners.Location = new System.Drawing.Point(12, 85);
            this.lblAmountOfRailrunners.Name = "lblAmountOfRailrunners";
            this.lblAmountOfRailrunners.Size = new System.Drawing.Size(79, 20);
            this.lblAmountOfRailrunners.TabIndex = 2;
            this.lblAmountOfRailrunners.Text = "Railrunner:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 196);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Prijs";
            // 
            // radSecondClass
            // 
            this.radSecondClass.AutoSize = true;
            this.radSecondClass.Location = new System.Drawing.Point(150, 5);
            this.radSecondClass.Name = "radSecondClass";
            this.radSecondClass.Size = new System.Drawing.Size(89, 24);
            this.radSecondClass.TabIndex = 4;
            this.radSecondClass.TabStop = true;
            this.radSecondClass.Text = "2e klasse";
            this.radSecondClass.UseVisualStyleBackColor = true;
            // 
            // radFirstClass
            // 
            this.radFirstClass.AutoSize = true;
            this.radFirstClass.Location = new System.Drawing.Point(274, 5);
            this.radFirstClass.Name = "radFirstClass";
            this.radFirstClass.Size = new System.Drawing.Size(89, 24);
            this.radFirstClass.TabIndex = 5;
            this.radFirstClass.TabStop = true;
            this.radFirstClass.Text = "1e klasse";
            this.radFirstClass.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(150, 154);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 29);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Bereken";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtInputAmount
            // 
            this.txtInputAmount.Location = new System.Drawing.Point(150, 40);
            this.txtInputAmount.Name = "txtInputAmount";
            this.txtInputAmount.Size = new System.Drawing.Size(125, 27);
            this.txtInputAmount.TabIndex = 7;
            // 
            // txtInputRailrunners
            // 
            this.txtInputRailrunners.Location = new System.Drawing.Point(150, 82);
            this.txtInputRailrunners.Name = "txtInputRailrunners";
            this.txtInputRailrunners.Size = new System.Drawing.Size(125, 27);
            this.txtInputRailrunners.TabIndex = 8;
            // 
            // txtOutputPrice
            // 
            this.txtOutputPrice.Location = new System.Drawing.Point(150, 189);
            this.txtOutputPrice.Name = "txtOutputPrice";
            this.txtOutputPrice.Size = new System.Drawing.Size(125, 27);
            this.txtOutputPrice.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 242);
            this.Controls.Add(this.txtOutputPrice);
            this.Controls.Add(this.txtInputRailrunners);
            this.Controls.Add(this.txtInputAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.radFirstClass);
            this.Controls.Add(this.radSecondClass);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAmountOfRailrunners);
            this.Controls.Add(this.lblAmountOfPassengers);
            this.Controls.Add(this.lblClass);
            this.Name = "Form1";
            this.Text = "NS Dagkaart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblClass;
        private Label lblAmountOfPassengers;
        private Label lblAmountOfRailrunners;
        private Label lblPrice;
        private RadioButton radSecondClass;
        private RadioButton radFirstClass;
        private Button btnCalculate;
        private TextBox txtInputAmount;
        private TextBox txtInputRailrunners;
        private TextBox txtOutputPrice;
    }
}