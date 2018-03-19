namespace Exercise_4
{
    partial class Exercise_4
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
            this.label1_Text = new System.Windows.Forms.Label();
            this.textBox1_Number = new System.Windows.Forms.TextBox();
            this.textBox2_DiplaySeconds = new System.Windows.Forms.TextBox();
            this.textBox3_DisplayHours = new System.Windows.Forms.TextBox();
            this.textBox4_DisplayDays = new System.Windows.Forms.TextBox();
            this.label1_Input = new System.Windows.Forms.Label();
            this.label2_Seconds = new System.Windows.Forms.Label();
            this.label3_Hours = new System.Windows.Forms.Label();
            this.label4_Days = new System.Windows.Forms.Label();
            this.button1_Calculate = new System.Windows.Forms.Button();
            this.button2_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_Text
            // 
            this.label1_Text.AutoSize = true;
            this.label1_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Text.Location = new System.Drawing.Point(28, 21);
            this.label1_Text.Name = "label1_Text";
            this.label1_Text.Size = new System.Drawing.Size(287, 40);
            this.label1_Text.TabIndex = 0;
            this.label1_Text.Text = "Please enter any number amount to be \r\nconverted into appropriate time form!!";
            // 
            // textBox1_Number
            // 
            this.textBox1_Number.Location = new System.Drawing.Point(177, 106);
            this.textBox1_Number.Name = "textBox1_Number";
            this.textBox1_Number.Size = new System.Drawing.Size(100, 20);
            this.textBox1_Number.TabIndex = 1;
            // 
            // textBox2_DiplaySeconds
            // 
            this.textBox2_DiplaySeconds.Location = new System.Drawing.Point(177, 162);
            this.textBox2_DiplaySeconds.Name = "textBox2_DiplaySeconds";
            this.textBox2_DiplaySeconds.Size = new System.Drawing.Size(100, 20);
            this.textBox2_DiplaySeconds.TabIndex = 2;
            // 
            // textBox3_DisplayHours
            // 
            this.textBox3_DisplayHours.Location = new System.Drawing.Point(177, 219);
            this.textBox3_DisplayHours.Name = "textBox3_DisplayHours";
            this.textBox3_DisplayHours.Size = new System.Drawing.Size(100, 20);
            this.textBox3_DisplayHours.TabIndex = 3;
            // 
            // textBox4_DisplayDays
            // 
            this.textBox4_DisplayDays.Location = new System.Drawing.Point(177, 285);
            this.textBox4_DisplayDays.Name = "textBox4_DisplayDays";
            this.textBox4_DisplayDays.Size = new System.Drawing.Size(100, 20);
            this.textBox4_DisplayDays.TabIndex = 4;
            // 
            // label1_Input
            // 
            this.label1_Input.AutoSize = true;
            this.label1_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Input.Location = new System.Drawing.Point(29, 113);
            this.label1_Input.Name = "label1_Input";
            this.label1_Input.Size = new System.Drawing.Size(102, 16);
            this.label1_Input.TabIndex = 5;
            this.label1_Input.Text = "Original number";
            // 
            // label2_Seconds
            // 
            this.label2_Seconds.AutoSize = true;
            this.label2_Seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_Seconds.Location = new System.Drawing.Point(29, 169);
            this.label2_Seconds.Name = "label2_Seconds";
            this.label2_Seconds.Size = new System.Drawing.Size(62, 16);
            this.label2_Seconds.TabIndex = 6;
            this.label2_Seconds.Text = "Seconds";
            // 
            // label3_Hours
            // 
            this.label3_Hours.AutoSize = true;
            this.label3_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_Hours.Location = new System.Drawing.Point(29, 226);
            this.label3_Hours.Name = "label3_Hours";
            this.label3_Hours.Size = new System.Drawing.Size(44, 16);
            this.label3_Hours.TabIndex = 7;
            this.label3_Hours.Text = "Hours";
            // 
            // label4_Days
            // 
            this.label4_Days.AutoSize = true;
            this.label4_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_Days.Location = new System.Drawing.Point(29, 293);
            this.label4_Days.Name = "label4_Days";
            this.label4_Days.Size = new System.Drawing.Size(40, 16);
            this.label4_Days.TabIndex = 8;
            this.label4_Days.Text = "Days";
            // 
            // button1_Calculate
            // 
            this.button1_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Calculate.Location = new System.Drawing.Point(32, 369);
            this.button1_Calculate.Name = "button1_Calculate";
            this.button1_Calculate.Size = new System.Drawing.Size(75, 23);
            this.button1_Calculate.TabIndex = 9;
            this.button1_Calculate.Text = "Calculate";
            this.button1_Calculate.UseVisualStyleBackColor = true;
            this.button1_Calculate.Click += new System.EventHandler(this.button1_Calculate_Click);
            // 
            // button2_Reset
            // 
            this.button2_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_Reset.Location = new System.Drawing.Point(202, 369);
            this.button2_Reset.Name = "button2_Reset";
            this.button2_Reset.Size = new System.Drawing.Size(75, 23);
            this.button2_Reset.TabIndex = 10;
            this.button2_Reset.Text = "Reset";
            this.button2_Reset.UseVisualStyleBackColor = true;
            this.button2_Reset.Click += new System.EventHandler(this.button2_Reset_Click);
            // 
            // Exercise_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.button2_Reset);
            this.Controls.Add(this.button1_Calculate);
            this.Controls.Add(this.label4_Days);
            this.Controls.Add(this.label3_Hours);
            this.Controls.Add(this.label2_Seconds);
            this.Controls.Add(this.label1_Input);
            this.Controls.Add(this.textBox4_DisplayDays);
            this.Controls.Add(this.textBox3_DisplayHours);
            this.Controls.Add(this.textBox2_DiplaySeconds);
            this.Controls.Add(this.textBox1_Number);
            this.Controls.Add(this.label1_Text);
            this.Name = "Exercise_4";
            this.Text = "Exercise_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Text;
        private System.Windows.Forms.TextBox textBox1_Number;
        private System.Windows.Forms.TextBox textBox2_DiplaySeconds;
        private System.Windows.Forms.TextBox textBox3_DisplayHours;
        private System.Windows.Forms.TextBox textBox4_DisplayDays;
        private System.Windows.Forms.Label label1_Input;
        private System.Windows.Forms.Label label2_Seconds;
        private System.Windows.Forms.Label label3_Hours;
        private System.Windows.Forms.Label label4_Days;
        private System.Windows.Forms.Button button1_Calculate;
        private System.Windows.Forms.Button button2_Reset;
    }
}

