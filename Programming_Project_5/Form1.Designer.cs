namespace Programming_Project_5
{
    partial class Numbers
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
            this.button_Luck = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Luck
            // 
            this.button_Luck.Location = new System.Drawing.Point(158, 90);
            this.button_Luck.Name = "button_Luck";
            this.button_Luck.Size = new System.Drawing.Size(75, 40);
            this.button_Luck.TabIndex = 2;
            this.button_Luck.Text = "Feelin\' Lucky";
            this.button_Luck.UseVisualStyleBackColor = true;
            this.button_Luck.Click += new System.EventHandler(this.button_Luck_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(24, 90);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 40);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "CLOSE";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "What is your Birth Year?";
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(148, 32);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(100, 20);
            this.textBox_Year.TabIndex = 5;
            // 
            // Numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Luck);
            this.Name = "Numbers";
            this.Text = "Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Luck;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Year;
    }
}

