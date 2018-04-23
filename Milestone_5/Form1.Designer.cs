namespace Milestone_1
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
            this.converter_Label = new System.Windows.Forms.Label();
            this.transmission_Label = new System.Windows.Forms.Label();
            this.title_Label = new System.Windows.Forms.Label();
            this.transmission_Picture = new System.Windows.Forms.PictureBox();
            this.converter_Picture = new System.Windows.Forms.PictureBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Inventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transmission_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.converter_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // converter_Label
            // 
            this.converter_Label.AutoSize = true;
            this.converter_Label.BackColor = System.Drawing.Color.Transparent;
            this.converter_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converter_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.converter_Label.Location = new System.Drawing.Point(9, 128);
            this.converter_Label.Name = "converter_Label";
            this.converter_Label.Size = new System.Drawing.Size(192, 84);
            this.converter_Label.TabIndex = 2;
            this.converter_Label.Text = "Converter \r\n    Parts";
            // 
            // transmission_Label
            // 
            this.transmission_Label.AutoSize = true;
            this.transmission_Label.BackColor = System.Drawing.Color.Transparent;
            this.transmission_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmission_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.transmission_Label.Location = new System.Drawing.Point(8, 310);
            this.transmission_Label.Name = "transmission_Label";
            this.transmission_Label.Size = new System.Drawing.Size(199, 66);
            this.transmission_Label.TabIndex = 3;
            this.transmission_Label.Text = "Transmission \r\n       Parts";
            // 
            // title_Label
            // 
            this.title_Label.AutoSize = true;
            this.title_Label.BackColor = System.Drawing.Color.Transparent;
            this.title_Label.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title_Label.Location = new System.Drawing.Point(50, 9);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(370, 57);
            this.title_Label.TabIndex = 4;
            this.title_Label.Text = "Hughes Performance";
            // 
            // transmission_Picture
            // 
            this.transmission_Picture.BackColor = System.Drawing.SystemColors.Control;
            this.transmission_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.transmission_Picture.Image = ((System.Drawing.Image)(resources.GetObject("transmission_Picture.Image")));
            this.transmission_Picture.Location = new System.Drawing.Point(213, 275);
            this.transmission_Picture.Name = "transmission_Picture";
            this.transmission_Picture.Size = new System.Drawing.Size(245, 153);
            this.transmission_Picture.TabIndex = 1;
            this.transmission_Picture.TabStop = false;
            this.transmission_Picture.Click += new System.EventHandler(this.transmission_Picture_Click);
            // 
            // converter_Picture
            // 
            this.converter_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.converter_Picture.Image = global::Milestone_1.Properties.Resources.Converter;
            this.converter_Picture.Location = new System.Drawing.Point(213, 84);
            this.converter_Picture.Name = "converter_Picture";
            this.converter_Picture.Size = new System.Drawing.Size(245, 153);
            this.converter_Picture.TabIndex = 0;
            this.converter_Picture.TabStop = false;
            this.converter_Picture.Click += new System.EventHandler(this.converter_Picture_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.Color.Indigo;
            this.button_Close.Location = new System.Drawing.Point(60, 450);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(109, 43);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Inventory
            // 
            this.button_Inventory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inventory.ForeColor = System.Drawing.Color.Indigo;
            this.button_Inventory.Location = new System.Drawing.Point(299, 451);
            this.button_Inventory.Name = "button_Inventory";
            this.button_Inventory.Size = new System.Drawing.Size(109, 43);
            this.button_Inventory.TabIndex = 6;
            this.button_Inventory.Text = "Inventory";
            this.button_Inventory.UseVisualStyleBackColor = false;
            this.button_Inventory.Click += new System.EventHandler(this.button_Inventory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 506);
            this.Controls.Add(this.button_Inventory);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.title_Label);
            this.Controls.Add(this.transmission_Label);
            this.Controls.Add(this.converter_Label);
            this.Controls.Add(this.transmission_Picture);
            this.Controls.Add(this.converter_Picture);
            this.Name = "Form1";
            this.Text = "Hughes Performance";
            ((System.ComponentModel.ISupportInitialize)(this.transmission_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.converter_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox converter_Picture;
        private System.Windows.Forms.PictureBox transmission_Picture;
        private System.Windows.Forms.Label converter_Label;
        private System.Windows.Forms.Label transmission_Label;
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Inventory;
    }
}

