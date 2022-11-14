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
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblSpeedAns = new System.Windows.Forms.Label();
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
            this.rad10km.Location = new System.Drawing.Point(105, 21);
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
            this.rad21km.Location = new System.Drawing.Point(197, 21);
            this.rad21km.Name = "rad21km";
            this.rad21km.Size = new System.Drawing.Size(70, 24);
            this.rad21km.TabIndex = 2;
            this.rad21km.TabStop = true;
            this.rad21km.Text = "21 km";
            this.rad21km.UseVisualStyleBackColor = true;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(105, 77);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(50, 27);
            this.txtHours.TabIndex = 3;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(161, 77);
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
            this.txtSeconds.Location = new System.Drawing.Point(217, 77);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(50, 27);
            this.txtSeconds.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(30, 128);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(237, 29);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "&Bereken";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(30, 185);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(127, 20);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Snelheid (km/uur)";
            // 
            // lblSpeedAns
            // 
            this.lblSpeedAns.AutoSize = true;
            this.lblSpeedAns.Location = new System.Drawing.Point(197, 185);
            this.lblSpeedAns.Name = "lblSpeedAns";
            this.lblSpeedAns.Size = new System.Drawing.Size(44, 20);
            this.lblSpeedAns.TabIndex = 9;
            this.lblSpeedAns.Text = "0.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 246);
            this.Controls.Add(this.lblSpeedAns);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.rad21km);
            this.Controls.Add(this.rad10km);
            this.Controls.Add(this.rad5km);
            this.Name = "Form1";
            this.Text = "Opgave 5";
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
        private Label lblSpeed;
        private Label lblSpeedAns;
    }
}