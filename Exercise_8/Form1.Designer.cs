namespace Exercise_8
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fatInputBox = new System.Windows.Forms.TextBox();
            this.carbsInputBox = new System.Windows.Forms.TextBox();
            this.calFatBox = new System.Windows.Forms.TextBox();
            this.calCarbsBox = new System.Windows.Forms.TextBox();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calories from Fat and Carbohydrates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fat (grams)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carbohydrates (grams)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calories from Fat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Calories from Carbs";
            // 
            // fatInputBox
            // 
            this.fatInputBox.Location = new System.Drawing.Point(222, 81);
            this.fatInputBox.Name = "fatInputBox";
            this.fatInputBox.Size = new System.Drawing.Size(100, 20);
            this.fatInputBox.TabIndex = 5;
            // 
            // carbsInputBox
            // 
            this.carbsInputBox.Location = new System.Drawing.Point(222, 120);
            this.carbsInputBox.Name = "carbsInputBox";
            this.carbsInputBox.Size = new System.Drawing.Size(100, 20);
            this.carbsInputBox.TabIndex = 6;
            // 
            // calFatBox
            // 
            this.calFatBox.Location = new System.Drawing.Point(222, 159);
            this.calFatBox.Name = "calFatBox";
            this.calFatBox.Size = new System.Drawing.Size(100, 20);
            this.calFatBox.TabIndex = 7;
            // 
            // calCarbsBox
            // 
            this.calCarbsBox.Location = new System.Drawing.Point(222, 202);
            this.calCarbsBox.Name = "calCarbsBox";
            this.calCarbsBox.Size = new System.Drawing.Size(100, 20);
            this.calCarbsBox.TabIndex = 8;
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(70, 257);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(75, 23);
            this.button_Calculate.TabIndex = 9;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(222, 257);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 10;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 321);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.calCarbsBox);
            this.Controls.Add(this.calFatBox);
            this.Controls.Add(this.carbsInputBox);
            this.Controls.Add(this.fatInputBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calories from Fat and Carbohydrates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fatInputBox;
        private System.Windows.Forms.TextBox carbsInputBox;
        private System.Windows.Forms.TextBox calFatBox;
        private System.Windows.Forms.TextBox calCarbsBox;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.Button button_Clear;
    }
}

