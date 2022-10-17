namespace assignment7
{
    partial class cheConversion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radFah2Cel = new System.Windows.Forms.RadioButton();
            this.radCel2Kel = new System.Windows.Forms.RadioButton();
            this.radCel2Fah = new System.Windows.Forms.RadioButton();
            this.lblDegrees = new System.Windows.Forms.Label();
            this.lblConverted = new System.Windows.Forms.Label();
            this.lblConvertedAns = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFah2Cel);
            this.groupBox1.Controls.Add(this.radCel2Kel);
            this.groupBox1.Controls.Add(this.radCel2Fah);
            this.groupBox1.Location = new System.Drawing.Point(35, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // radFah2Cel
            // 
            this.radFah2Cel.AutoSize = true;
            this.radFah2Cel.Location = new System.Drawing.Point(26, 86);
            this.radFah2Cel.Name = "radFah2Cel";
            this.radFah2Cel.Size = new System.Drawing.Size(165, 24);
            this.radFah2Cel.TabIndex = 7;
            this.radFah2Cel.TabStop = true;
            this.radFah2Cel.Text = "Fahrenheit to Celsius";
            this.radFah2Cel.UseVisualStyleBackColor = true;
            // 
            // radCel2Kel
            // 
            this.radCel2Kel.AutoSize = true;
            this.radCel2Kel.Location = new System.Drawing.Point(26, 26);
            this.radCel2Kel.Name = "radCel2Kel";
            this.radCel2Kel.Size = new System.Drawing.Size(137, 24);
            this.radCel2Kel.TabIndex = 5;
            this.radCel2Kel.TabStop = true;
            this.radCel2Kel.Text = "Celsius to Kelvin";
            this.radCel2Kel.UseVisualStyleBackColor = true;
            // 
            // radCel2Fah
            // 
            this.radCel2Fah.AutoSize = true;
            this.radCel2Fah.Location = new System.Drawing.Point(26, 56);
            this.radCel2Fah.Name = "radCel2Fah";
            this.radCel2Fah.Size = new System.Drawing.Size(165, 24);
            this.radCel2Fah.TabIndex = 6;
            this.radCel2Fah.TabStop = true;
            this.radCel2Fah.Text = "Celsius to Fahrenheit";
            this.radCel2Fah.UseVisualStyleBackColor = true;
            // 
            // lblDegrees
            // 
            this.lblDegrees.AutoSize = true;
            this.lblDegrees.Location = new System.Drawing.Point(35, 32);
            this.lblDegrees.Name = "lblDegrees";
            this.lblDegrees.Size = new System.Drawing.Size(64, 20);
            this.lblDegrees.TabIndex = 1;
            this.lblDegrees.Text = "Degrees";
            // 
            // lblConverted
            // 
            this.lblConverted.AutoSize = true;
            this.lblConverted.Location = new System.Drawing.Point(35, 301);
            this.lblConverted.Name = "lblConverted";
            this.lblConverted.Size = new System.Drawing.Size(134, 20);
            this.lblConverted.TabIndex = 2;
            this.lblConverted.Text = "Converted degrees";
            // 
            // lblConvertedAns
            // 
            this.lblConvertedAns.AutoSize = true;
            this.lblConvertedAns.Location = new System.Drawing.Point(228, 301);
            this.lblConvertedAns.Name = "lblConvertedAns";
            this.lblConvertedAns.Size = new System.Drawing.Size(36, 20);
            this.lblConvertedAns.TabIndex = 3;
            this.lblConvertedAns.Text = "0,00";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(228, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 27);
            this.txtInput.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(35, 235);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(318, 54);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // cheConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 348);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblConvertedAns);
            this.Controls.Add(this.lblConverted);
            this.Controls.Add(this.lblDegrees);
            this.Controls.Add(this.groupBox1);
            this.Name = "cheConversion";
            this.Text = "Methods assignment 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblDegrees;
        private Label lblConverted;
        private Label lblConvertedAns;
        private TextBox txtInput;
        private Button btnCalc;
        private RadioButton radFah2Cel;
        private RadioButton radCel2Kel;
        private RadioButton radCel2Fah;
    }
}