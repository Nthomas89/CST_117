namespace Programming_Project_3
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
            this.button1_OpenFile = new System.Windows.Forms.Button();
            this.listBox1_Results = new System.Windows.Forms.ListBox();
            this.button1_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open a text file\r\n    to Analyze\r\n   Characters";
            // 
            // button1_OpenFile
            // 
            this.button1_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_OpenFile.ForeColor = System.Drawing.Color.DarkRed;
            this.button1_OpenFile.Location = new System.Drawing.Point(134, 163);
            this.button1_OpenFile.Name = "button1_OpenFile";
            this.button1_OpenFile.Size = new System.Drawing.Size(117, 53);
            this.button1_OpenFile.TabIndex = 1;
            this.button1_OpenFile.Text = "Open File";
            this.button1_OpenFile.UseVisualStyleBackColor = true;
            this.button1_OpenFile.Click += new System.EventHandler(this.button1_OpenFile_Click);
            // 
            // listBox1_Results
            // 
            this.listBox1_Results.FormattingEnabled = true;
            this.listBox1_Results.Location = new System.Drawing.Point(33, 258);
            this.listBox1_Results.Name = "listBox1_Results";
            this.listBox1_Results.Size = new System.Drawing.Size(325, 95);
            this.listBox1_Results.TabIndex = 2;
            // 
            // button1_Close
            // 
            this.button1_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Close.ForeColor = System.Drawing.Color.DarkRed;
            this.button1_Close.Location = new System.Drawing.Point(134, 401);
            this.button1_Close.Name = "button1_Close";
            this.button1_Close.Size = new System.Drawing.Size(117, 37);
            this.button1_Close.TabIndex = 3;
            this.button1_Close.Text = "Close";
            this.button1_Close.UseVisualStyleBackColor = true;
            this.button1_Close.Click += new System.EventHandler(this.button1_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.button1_Close);
            this.Controls.Add(this.listBox1_Results);
            this.Controls.Add(this.button1_OpenFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Programming Project 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_OpenFile;
        private System.Windows.Forms.ListBox listBox1_Results;
        private System.Windows.Forms.Button button1_Close;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

