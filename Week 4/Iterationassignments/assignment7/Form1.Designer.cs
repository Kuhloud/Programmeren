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
            this.lblSide = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(41, 15);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(38, 20);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Side";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(182, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 27);
            this.txtInput.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(41, 58);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(266, 29);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "&Create square";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblX.Location = new System.Drawing.Point(166, 215);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 27);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 431);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblSide);
            this.Name = "Form1";
            this.Text = "Iteration assignment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSide;
        private TextBox txtInput;
        private Button btnCreate;
        private Label lblX;
    }
}