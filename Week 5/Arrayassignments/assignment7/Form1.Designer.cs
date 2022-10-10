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
            this.btnThrow = new System.Windows.Forms.Button();
            this.lblThrows = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(121, 225);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(147, 64);
            this.btnThrow.TabIndex = 0;
            this.btnThrow.Text = "&Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // lblThrows
            // 
            this.lblThrows.AutoSize = true;
            this.lblThrows.Location = new System.Drawing.Point(70, 66);
            this.lblThrows.Name = "lblThrows";
            this.lblThrows.Size = new System.Drawing.Size(0, 20);
            this.lblThrows.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 323);
            this.Controls.Add(this.lblThrows);
            this.Controls.Add(this.btnThrow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnThrow;
        private Label lblThrows;
    }
}