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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultAns = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSquareByReference = new System.Windows.Forms.Button();
            this.btnSquareByReferenceOut = new System.Windows.Forms.Button();
            this.btnSquareByValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(21, 19);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(63, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(21, 210);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(49, 20);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // lblResultAns
            // 
            this.lblResultAns.AutoSize = true;
            this.lblResultAns.Location = new System.Drawing.Point(169, 210);
            this.lblResultAns.Name = "lblResultAns";
            this.lblResultAns.Size = new System.Drawing.Size(17, 20);
            this.lblResultAns.TabIndex = 2;
            this.lblResultAns.Text = "0";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(169, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 27);
            this.txtInput.TabIndex = 3;
            // 
            // btnSquareByReference
            // 
            this.btnSquareByReference.Location = new System.Drawing.Point(21, 75);
            this.btnSquareByReference.Name = "btnSquareByReference";
            this.btnSquareByReference.Size = new System.Drawing.Size(273, 29);
            this.btnSquareByReference.TabIndex = 4;
            this.btnSquareByReference.Text = "Square By &Reference";
            this.btnSquareByReference.UseVisualStyleBackColor = true;
            this.btnSquareByReference.Click += new System.EventHandler(this.btnSquareByReference_Click);
            // 
            // btnSquareByReferenceOut
            // 
            this.btnSquareByReferenceOut.Location = new System.Drawing.Point(21, 110);
            this.btnSquareByReferenceOut.Name = "btnSquareByReferenceOut";
            this.btnSquareByReferenceOut.Size = new System.Drawing.Size(273, 29);
            this.btnSquareByReferenceOut.TabIndex = 5;
            this.btnSquareByReferenceOut.Text = "Square By Reference &Out";
            this.btnSquareByReferenceOut.UseVisualStyleBackColor = true;
            this.btnSquareByReferenceOut.Click += new System.EventHandler(this.btnSquareByReferenceOut_Click);
            // 
            // btnSquareByValue
            // 
            this.btnSquareByValue.Location = new System.Drawing.Point(21, 145);
            this.btnSquareByValue.Name = "btnSquareByValue";
            this.btnSquareByValue.Size = new System.Drawing.Size(273, 29);
            this.btnSquareByValue.TabIndex = 6;
            this.btnSquareByValue.Text = "Square By &Value";
            this.btnSquareByValue.UseVisualStyleBackColor = true;
            this.btnSquareByValue.Click += new System.EventHandler(this.btnSquareByValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 252);
            this.Controls.Add(this.btnSquareByValue);
            this.Controls.Add(this.btnSquareByReferenceOut);
            this.Controls.Add(this.btnSquareByReference);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblResultAns);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumber);
            this.Name = "Form1";
            this.Text = "Methods assignment 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumber;
        private Label lblResult;
        private Label lblResultAns;
        private TextBox txtInput;
        private Button btnSquareByReference;
        private Button btnSquareByReferenceOut;
        private Button btnSquareByValue;
    }
}