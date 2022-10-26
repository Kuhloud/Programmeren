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
            this.rad5km = new System.Windows.Forms.RadioButton();
            this.rad10km = new System.Windows.Forms.RadioButton();
            this.rad21km = new System.Windows.Forms.RadioButton();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rad5km
            // 
            this.rad5km.AutoSize = true;
            this.rad5km.Location = new System.Drawing.Point(30, 21);
            this.rad5km.Name = "rad5km";
            this.rad5km.Size = new System.Drawing.Size(62, 24);
            this.rad5km.TabIndex = 0;
            this.rad5km.TabStop = true;
            this.rad5km.Text = "5 km";
            this.rad5km.UseVisualStyleBackColor = true;
            // 
            // rad10km
            // 
            this.rad10km.AutoSize = true;
            this.rad10km.Location = new System.Drawing.Point(140, 21);
            this.rad10km.Name = "rad10km";
            this.rad10km.Size = new System.Drawing.Size(70, 24);
            this.rad10km.TabIndex = 1;
            this.rad10km.TabStop = true;
            this.rad10km.Text = "10 km";
            this.rad10km.UseVisualStyleBackColor = true;
            // 
            // rad21km
            // 
            this.rad21km.AutoSize = true;
            this.rad21km.Location = new System.Drawing.Point(286, 21);
            this.rad21km.Name = "rad21km";
            this.rad21km.Size = new System.Drawing.Size(70, 24);
            this.rad21km.TabIndex = 2;
            this.rad21km.TabStop = true;
            this.rad21km.Text = "21 km";
            this.rad21km.UseVisualStyleBackColor = true;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(137, 77);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(50, 27);
            this.txtHours.TabIndex = 3;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(193, 80);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(50, 27);
            this.txtMinutes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "hh:mm:ss";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(249, 80);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(50, 27);
            this.txtSeconds.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(262, 174);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(94, 29);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "&Bereken";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.rad21km);
            this.Controls.Add(this.rad10km);
            this.Controls.Add(this.rad5km);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rad5km;
        private RadioButton rad10km;
        private RadioButton rad21km;
        private TextBox txtHours;
        private TextBox txtMinutes;
        private Label label1;
        private TextBox txtSeconds;
        private Button btnCalc;
    }
}