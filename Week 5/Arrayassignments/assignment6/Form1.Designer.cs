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
            this.lblTableBefore = new System.Windows.Forms.Label();
            this.lblTableAfter = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.lblBefore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnComp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTableBefore
            // 
            this.lblTableBefore.AutoSize = true;
            this.lblTableBefore.Location = new System.Drawing.Point(24, 37);
            this.lblTableBefore.Name = "lblTableBefore";
            this.lblTableBefore.Size = new System.Drawing.Size(157, 20);
            this.lblTableBefore.TabIndex = 0;
            this.lblTableBefore.Text = "Content table (before)";
            // 
            // lblTableAfter
            // 
            this.lblTableAfter.AutoSize = true;
            this.lblTableAfter.Location = new System.Drawing.Point(248, 37);
            this.lblTableAfter.Name = "lblTableAfter";
            this.lblTableAfter.Size = new System.Drawing.Size(144, 20);
            this.lblTableAfter.TabIndex = 1;
            this.lblTableAfter.Text = "Content table (after)";
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Location = new System.Drawing.Point(248, 69);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(18, 20);
            this.lblAfter.TabIndex = 3;
            this.lblAfter.Text = "...";
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Location = new System.Drawing.Point(24, 69);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(18, 20);
            this.lblBefore.TabIndex = 4;
            this.lblBefore.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comparison number";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(189, 482);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(58, 27);
            this.txtInput.TabIndex = 6;
            // 
            // btnComp
            // 
            this.btnComp.Location = new System.Drawing.Point(270, 481);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(94, 29);
            this.btnComp.TabIndex = 7;
            this.btnComp.Text = "&Compare";
            this.btnComp.UseVisualStyleBackColor = true;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBefore);
            this.Controls.Add(this.lblAfter);
            this.Controls.Add(this.lblTableAfter);
            this.Controls.Add(this.lblTableBefore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTableBefore;
        private Label lblTableAfter;
        private Label lblAfter;
        private Label lblBefore;
        private Label label1;
        private TextBox txtInput;
        private Button btnComp;
    }
}