namespace Gui
{
    partial class PoznamkyOkno
    {
        /// <summary>
        /// Required designer Test variable.
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.obsah_label = new MetroFramework.Controls.MetroLabel();
            this.nazov_label = new MetroFramework.Controls.MetroLabel();
            this.nazov_textBox = new System.Windows.Forms.TextBox();
            this.obsah_textBox = new System.Windows.Forms.TextBox();
            this.close_button_poznamky = new MetroFramework.Controls.MetroButton();
            this.ok_button_poznamky = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(184, 25);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Vytvorenie poznamky";
            // 
            // obsah_label
            // 
            this.obsah_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.obsah_label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.obsah_label.Location = new System.Drawing.Point(23, 108);
            this.obsah_label.Name = "obsah_label";
            this.obsah_label.Size = new System.Drawing.Size(111, 28);
            this.obsah_label.TabIndex = 27;
            this.obsah_label.Text = "Popis poznamky";
            this.obsah_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nazov_label
            // 
            this.nazov_label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nazov_label.Location = new System.Drawing.Point(23, 67);
            this.nazov_label.Name = "nazov_label";
            this.nazov_label.Size = new System.Drawing.Size(56, 28);
            this.nazov_label.TabIndex = 26;
            this.nazov_label.Text = "Názov";
            this.nazov_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nazov_textBox
            // 
            this.nazov_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazov_textBox.Location = new System.Drawing.Point(85, 67);
            this.nazov_textBox.Name = "nazov_textBox";
            this.nazov_textBox.Size = new System.Drawing.Size(280, 23);
            this.nazov_textBox.TabIndex = 0;
            // 
            // obsah_textBox
            // 
            this.obsah_textBox.BackColor = System.Drawing.Color.White;
            this.obsah_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.obsah_textBox.Location = new System.Drawing.Point(23, 138);
            this.obsah_textBox.Multiline = true;
            this.obsah_textBox.Name = "obsah_textBox";
            this.obsah_textBox.Size = new System.Drawing.Size(342, 133);
            this.obsah_textBox.TabIndex = 1;
            // 
            // close_button_poznamky
            // 
            this.close_button_poznamky.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.close_button_poznamky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button_poznamky.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.close_button_poznamky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close_button_poznamky.Location = new System.Drawing.Point(93, 292);
            this.close_button_poznamky.Name = "close_button_poznamky";
            this.close_button_poznamky.Size = new System.Drawing.Size(73, 43);
            this.close_button_poznamky.Style = MetroFramework.MetroColorStyle.Blue;
            this.close_button_poznamky.TabIndex = 3;
            this.close_button_poznamky.Text = "Zrušiť";
            this.close_button_poznamky.UseCustomBackColor = true;
            this.close_button_poznamky.UseCustomForeColor = true;
            this.close_button_poznamky.UseMnemonic = false;
            this.close_button_poznamky.UseSelectable = true;
            this.close_button_poznamky.Click += new System.EventHandler(this.close_button_click);
            // 
            // ok_button_poznamky
            // 
            this.ok_button_poznamky.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ok_button_poznamky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_button_poznamky.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ok_button_poznamky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok_button_poznamky.Location = new System.Drawing.Point(23, 292);
            this.ok_button_poznamky.Name = "ok_button_poznamky";
            this.ok_button_poznamky.Size = new System.Drawing.Size(64, 43);
            this.ok_button_poznamky.Style = MetroFramework.MetroColorStyle.Blue;
            this.ok_button_poznamky.TabIndex = 2;
            this.ok_button_poznamky.Text = "OK";
            this.ok_button_poznamky.UseCustomBackColor = true;
            this.ok_button_poznamky.UseCustomForeColor = true;
            this.ok_button_poznamky.UseMnemonic = false;
            this.ok_button_poznamky.UseSelectable = true;
            this.ok_button_poznamky.Click += new System.EventHandler(this.ok_button_click);
            // 
            // PoznamkyOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(390, 355);
            this.Controls.Add(this.close_button_poznamky);
            this.Controls.Add(this.ok_button_poznamky);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.obsah_label);
            this.Controls.Add(this.nazov_label);
            this.Controls.Add(this.nazov_textBox);
            this.Controls.Add(this.obsah_textBox);
            this.Name = "PoznamkyOkno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poznamka";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PoznamkyOkno_FormClosed);
            this.Load += new System.EventHandler(this.PoznamkyOkno_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel obsah_label;
        private MetroFramework.Controls.MetroLabel nazov_label;
        private System.Windows.Forms.TextBox nazov_textBox;
        private System.Windows.Forms.TextBox obsah_textBox;
        private MetroFramework.Controls.MetroButton close_button_poznamky;
        private MetroFramework.Controls.MetroButton ok_button_poznamky;
    }
}