namespace Gui
{
    partial class PoznamkyOkno
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
            this.nazov_textBox = new System.Windows.Forms.TextBox();
            this.nazov_label = new System.Windows.Forms.Label();
            this.obsah_textBox = new System.Windows.Forms.TextBox();
            this.obsah_label = new System.Windows.Forms.Label();
            this.ok_button_poznamky = new System.Windows.Forms.Button();
            this.close_button_poznamky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazov_textBox
            // 
            this.nazov_textBox.Location = new System.Drawing.Point(12, 47);
            this.nazov_textBox.Name = "nazov_textBox";
            this.nazov_textBox.Size = new System.Drawing.Size(313, 20);
            this.nazov_textBox.TabIndex = 0;
            //this.nazov_textBox.TextChanged += new System.EventHandler(this.nazov_textBox_TextChanged);
            // 
            // nazov_label
            // 
            this.nazov_label.AutoSize = true;
            this.nazov_label.Location = new System.Drawing.Point(12, 31);
            this.nazov_label.Name = "nazov_label";
            this.nazov_label.Size = new System.Drawing.Size(35, 13);
            this.nazov_label.TabIndex = 1;
            this.nazov_label.Text = "label1";
            //this.nazov_label.Click += new System.EventHandler(this.nazov_label_Click);
            // 
            // obsah_textBox
            // 
            this.obsah_textBox.Location = new System.Drawing.Point(15, 97);
            this.obsah_textBox.Multiline = true;
            this.obsah_textBox.Name = "obsah_textBox";
            this.obsah_textBox.Size = new System.Drawing.Size(310, 139);
            this.obsah_textBox.TabIndex = 2;
            // 
            // obsah_label
            // 
            this.obsah_label.AutoSize = true;
            this.obsah_label.Location = new System.Drawing.Point(12, 81);
            this.obsah_label.Name = "obsah_label";
            this.obsah_label.Size = new System.Drawing.Size(35, 13);
            this.obsah_label.TabIndex = 3;
            this.obsah_label.Text = "label1";
            // 
            // ok_button_poznamky
            // 
            this.ok_button_poznamky.Location = new System.Drawing.Point(15, 253);
            this.ok_button_poznamky.Name = "ok_button_poznamky";
            this.ok_button_poznamky.Size = new System.Drawing.Size(125, 30);
            this.ok_button_poznamky.TabIndex = 4;
            this.ok_button_poznamky.Text = "button1";
            this.ok_button_poznamky.UseVisualStyleBackColor = true;
            this.close_button_poznamky.Click += new System.EventHandler(this.ok_button_click);
            
            // 
            // close_button_poznamky
            // 
            this.close_button_poznamky.Location = new System.Drawing.Point(200, 253);
            this.close_button_poznamky.Name = "close_button_poznamky";
            this.close_button_poznamky.Size = new System.Drawing.Size(125, 30);
            this.close_button_poznamky.TabIndex = 5;
            this.close_button_poznamky.Text = "button2";
            this.close_button_poznamky.UseVisualStyleBackColor = true;
            this.close_button_poznamky.Click += new System.EventHandler(this.close_button_click);
            // 
            // PoznamkyOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 310);
            this.Controls.Add(this.close_button_poznamky);
            this.Controls.Add(this.ok_button_poznamky);
            this.Controls.Add(this.obsah_label);
            this.Controls.Add(this.obsah_textBox);
            this.Controls.Add(this.nazov_label);
            this.Controls.Add(this.nazov_textBox);
            this.Name = "PoznamkyOkno";
            this.Text = "PoznamkyOkno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.TextBox nazov_textBox;
        private System.Windows.Forms.Label nazov_label;
        private System.Windows.Forms.TextBox obsah_textBox;
        private System.Windows.Forms.Label obsah_label;
        private System.Windows.Forms.Button ok_button_poznamky;
        private System.Windows.Forms.Button close_button_poznamky;
    }
}