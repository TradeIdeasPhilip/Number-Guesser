namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "I\'m thinking of a number between";
            // 
            // lowTextBox
            // 
            this.lowTextBox.Location = new System.Drawing.Point(344, 12);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(100, 31);
            this.lowTextBox.TabIndex = 1;
            this.lowTextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "and";
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(504, 12);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(100, 31);
            this.highTextBox.TabIndex = 3;
            this.highTextBox.Text = "1000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "guess what im thinking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "number guesser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox highTextBox;
        private System.Windows.Forms.Button button1;
    }
}

