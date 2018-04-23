namespace Milestone_1
{
    partial class converter
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
            this.button_BKC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AddC = new System.Windows.Forms.Button();
            this.textBox_NameC = new System.Windows.Forms.TextBox();
            this.textBox_NumberC = new System.Windows.Forms.TextBox();
            this.textBox_QuantityC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.ListBox();
            this.button_Inventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_BKC
            // 
            this.button_BKC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_BKC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BKC.ForeColor = System.Drawing.Color.Indigo;
            this.button_BKC.Location = new System.Drawing.Point(292, 380);
            this.button_BKC.Name = "button_BKC";
            this.button_BKC.Size = new System.Drawing.Size(97, 48);
            this.button_BKC.TabIndex = 0;
            this.button_BKC.Text = "BACK";
            this.button_BKC.UseVisualStyleBackColor = false;
            this.button_BKC.Click += new System.EventHandler(this.button_BKC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(50, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Part Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(31, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Part Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(25, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Quantity";
            // 
            // button_AddC
            // 
            this.button_AddC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_AddC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddC.ForeColor = System.Drawing.Color.Indigo;
            this.button_AddC.Location = new System.Drawing.Point(58, 380);
            this.button_AddC.Name = "button_AddC";
            this.button_AddC.Size = new System.Drawing.Size(105, 48);
            this.button_AddC.TabIndex = 4;
            this.button_AddC.Text = "ADD";
            this.button_AddC.UseVisualStyleBackColor = false;
            this.button_AddC.Click += new System.EventHandler(this.button_AddC_Click);
            // 
            // textBox_NameC
            // 
            this.textBox_NameC.Location = new System.Drawing.Point(229, 77);
            this.textBox_NameC.Name = "textBox_NameC";
            this.textBox_NameC.Size = new System.Drawing.Size(160, 20);
            this.textBox_NameC.TabIndex = 5;
            // 
            // textBox_NumberC
            // 
            this.textBox_NumberC.Location = new System.Drawing.Point(229, 135);
            this.textBox_NumberC.Name = "textBox_NumberC";
            this.textBox_NumberC.Size = new System.Drawing.Size(160, 20);
            this.textBox_NumberC.TabIndex = 6;
            // 
            // textBox_QuantityC
            // 
            this.textBox_QuantityC.Location = new System.Drawing.Point(229, 187);
            this.textBox_QuantityC.Name = "textBox_QuantityC";
            this.textBox_QuantityC.Size = new System.Drawing.Size(160, 20);
            this.textBox_QuantityC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(144, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "CONVERTER";
            // 
            // Display
            // 
            this.Display.FormattingEnabled = true;
            this.Display.Location = new System.Drawing.Point(46, 248);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(359, 95);
            this.Display.TabIndex = 9;
            this.Display.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_Inventory
            // 
            this.button_Inventory.Location = new System.Drawing.Point(181, 380);
            this.button_Inventory.Name = "button_Inventory";
            this.button_Inventory.Size = new System.Drawing.Size(92, 48);
            this.button_Inventory.TabIndex = 10;
            this.button_Inventory.Text = "INVENTORY";
            this.button_Inventory.UseVisualStyleBackColor = true;
            this.button_Inventory.Click += new System.EventHandler(this.button_Inventory_Click);
            // 
            // converter
            // 
            this.AcceptButton = this.button_AddC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Milestone_1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 440);
            this.Controls.Add(this.button_Inventory);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_QuantityC);
            this.Controls.Add(this.textBox_NumberC);
            this.Controls.Add(this.textBox_NameC);
            this.Controls.Add(this.button_AddC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_BKC);
            this.Name = "converter";
            this.Text = "converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_BKC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AddC;
        private System.Windows.Forms.TextBox textBox_NameC;
        private System.Windows.Forms.TextBox textBox_NumberC;
        private System.Windows.Forms.TextBox textBox_QuantityC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Inventory;
        private System.Windows.Forms.ListBox Display;
    }
}