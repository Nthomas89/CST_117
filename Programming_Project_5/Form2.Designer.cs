namespace Programming_Project_5
{
    partial class Lucky_Numbers
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
            this.text_Numbers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_Numbers
            // 
            this.text_Numbers.Location = new System.Drawing.Point(264, 107);
            this.text_Numbers.Name = "text_Numbers";
            this.text_Numbers.Size = new System.Drawing.Size(100, 20);
            this.text_Numbers.TabIndex = 0;
            this.text_Numbers.TextChanged += new System.EventHandler(this.text_Numbers_TextChanged);
            // 
            // Lucky_Numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_Numbers);
            this.Name = "Lucky_Numbers";
            this.Text = "Lucky_Numbers";
            this.Load += new System.EventHandler(this.Lucky_Numbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Numbers;
    }
}