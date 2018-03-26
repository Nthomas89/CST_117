namespace Exercise_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_InputTerms = new System.Windows.Forms.TextBox();
            this.button1_Calculate = new System.Windows.Forms.Button();
            this.label2_Results = new System.Windows.Forms.Label();
            this.label2_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number of terms:";
            // 
            // textBox1_InputTerms
            // 
            this.textBox1_InputTerms.Location = new System.Drawing.Point(293, 38);
            this.textBox1_InputTerms.Name = "textBox1_InputTerms";
            this.textBox1_InputTerms.Size = new System.Drawing.Size(165, 20);
            this.textBox1_InputTerms.TabIndex = 1;
            // 
            // button1_Calculate
            // 
            this.button1_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Calculate.Location = new System.Drawing.Point(142, 124);
            this.button1_Calculate.Name = "button1_Calculate";
            this.button1_Calculate.Size = new System.Drawing.Size(208, 74);
            this.button1_Calculate.TabIndex = 2;
            this.button1_Calculate.Text = "Calculate";
            this.button1_Calculate.UseVisualStyleBackColor = true;
            this.button1_Calculate.Click += new System.EventHandler(this.button1_Calculate_Click);
            // 
            // label2_Results
            // 
            this.label2_Results.AutoSize = true;
            this.label2_Results.Location = new System.Drawing.Point(213, 366);
            this.label2_Results.Name = "label2_Results";
            this.label2_Results.Size = new System.Drawing.Size(52, 13);
            this.label2_Results.TabIndex = 3;
            this.label2_Results.Text = "...............";
            // 
            // label2_Text
            // 
            this.label2_Text.AutoSize = true;
            this.label2_Text.Location = new System.Drawing.Point(152, 291);
            this.label2_Text.Name = "label2_Text";
            this.label2_Text.Size = new System.Drawing.Size(0, 13);
            this.label2_Text.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.label2_Text);
            this.Controls.Add(this.label2_Results);
            this.Controls.Add(this.button1_Calculate);
            this.Controls.Add(this.textBox1_InputTerms);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PI Approximation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_InputTerms;
        private System.Windows.Forms.Button button1_Calculate;
        private System.Windows.Forms.Label label2_Results;
        private System.Windows.Forms.Label label2_Text;
    }
}

