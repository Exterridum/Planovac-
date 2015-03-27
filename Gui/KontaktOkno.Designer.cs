using Microsoft.Win32;

namespace Gui
{
    partial class KontaktOkno
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
            this.ok_btn = new System.Windows.Forms.Button();
            this.kontakt_meno_l = new System.Windows.Forms.Label();
            this.kontakt_priezvisko_l = new System.Windows.Forms.Label();
            this.kontakt_adresa_obec_l = new System.Windows.Forms.Label();
            this.kontakt_email_l = new System.Windows.Forms.Label();
            this.kontakt_telc_l = new System.Windows.Forms.Label();
            this.kontakt_meno_tb = new System.Windows.Forms.TextBox();
            this.kontakt_priezvisko_tb = new System.Windows.Forms.TextBox();
            this.kontakt_adresa_obec_tb = new System.Windows.Forms.TextBox();
            this.kontakt_email_tb = new System.Windows.Forms.TextBox();
            this.kontakt_telc_tb = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.kontakt_adresa_ulica_l = new System.Windows.Forms.Label();
            this.kontakt_adresa_cislo_l = new System.Windows.Forms.Label();
            this.kontakt_adresa_ulica_tb = new System.Windows.Forms.TextBox();
            this.kontakt_adresa_cislo_tb = new System.Windows.Forms.TextBox();
            this.kontakt_adresa_psc_tb = new System.Windows.Forms.TextBox();
            this.kontakt_adresa_psc_l = new System.Windows.Forms.Label();
            this.kontakt_adresa_l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(261, 22);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "button1";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_click);
            // 
            // kontakt_meno_l
            // 
            this.kontakt_meno_l.AutoSize = true;
            this.kontakt_meno_l.Location = new System.Drawing.Point(27, 25);
            this.kontakt_meno_l.Name = "kontakt_meno_l";
            this.kontakt_meno_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_meno_l.TabIndex = 3;
            this.kontakt_meno_l.Text = "label1";
            // 
            // kontakt_priezvisko_l
            // 
            this.kontakt_priezvisko_l.AutoSize = true;
            this.kontakt_priezvisko_l.Location = new System.Drawing.Point(27, 57);
            this.kontakt_priezvisko_l.Name = "kontakt_priezvisko_l";
            this.kontakt_priezvisko_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_priezvisko_l.TabIndex = 4;
            this.kontakt_priezvisko_l.Text = "label2";
            // 
            // kontakt_adresa_obec_l
            // 
            this.kontakt_adresa_obec_l.AutoSize = true;
            this.kontakt_adresa_obec_l.Location = new System.Drawing.Point(27, 122);
            this.kontakt_adresa_obec_l.Name = "kontakt_adresa_obec_l";
            this.kontakt_adresa_obec_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_adresa_obec_l.TabIndex = 5;
            this.kontakt_adresa_obec_l.Text = "label3";
            // 
            // kontakt_email_l
            // 
            this.kontakt_email_l.AutoSize = true;
            this.kontakt_email_l.Location = new System.Drawing.Point(27, 212);
            this.kontakt_email_l.Name = "kontakt_email_l";
            this.kontakt_email_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_email_l.TabIndex = 6;
            this.kontakt_email_l.Text = "label7";
            // 
            // kontakt_telc_l
            // 
            this.kontakt_telc_l.AutoSize = true;
            this.kontakt_telc_l.Location = new System.Drawing.Point(27, 238);
            this.kontakt_telc_l.Name = "kontakt_telc_l";
            this.kontakt_telc_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_telc_l.TabIndex = 7;
            this.kontakt_telc_l.Text = "label8";
            // 
            // kontakt_meno_tb
            // 
            this.kontakt_meno_tb.Location = new System.Drawing.Point(65, 22);
            this.kontakt_meno_tb.Name = "kontakt_meno_tb";
            this.kontakt_meno_tb.Size = new System.Drawing.Size(178, 20);
            this.kontakt_meno_tb.TabIndex = 8;
            // 
            // kontakt_priezvisko_tb
            // 
            this.kontakt_priezvisko_tb.Location = new System.Drawing.Point(65, 54);
            this.kontakt_priezvisko_tb.Name = "kontakt_priezvisko_tb";
            this.kontakt_priezvisko_tb.Size = new System.Drawing.Size(178, 20);
            this.kontakt_priezvisko_tb.TabIndex = 9;
            // 
            // kontakt_adresa_obec_tb
            // 
            this.kontakt_adresa_obec_tb.Location = new System.Drawing.Point(65, 119);
            this.kontakt_adresa_obec_tb.Name = "kontakt_adresa_obec_tb";
            this.kontakt_adresa_obec_tb.Size = new System.Drawing.Size(178, 20);
            this.kontakt_adresa_obec_tb.TabIndex = 10;
            // 
            // kontakt_email_tb
            // 
            this.kontakt_email_tb.Location = new System.Drawing.Point(65, 209);
            this.kontakt_email_tb.Name = "kontakt_email_tb";
            this.kontakt_email_tb.Size = new System.Drawing.Size(178, 20);
            this.kontakt_email_tb.TabIndex = 11;
            // 
            // kontakt_telc_tb
            // 
            this.kontakt_telc_tb.Location = new System.Drawing.Point(65, 235);
            this.kontakt_telc_tb.Name = "kontakt_telc_tb";
            this.kontakt_telc_tb.Size = new System.Drawing.Size(178, 20);
            this.kontakt_telc_tb.TabIndex = 12;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(261, 51);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 13;
            this.cancel_btn.Text = "button2";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_click);
            // 
            // kontakt_adresa_ulica_l
            // 
            this.kontakt_adresa_ulica_l.AutoSize = true;
            this.kontakt_adresa_ulica_l.Location = new System.Drawing.Point(27, 148);
            this.kontakt_adresa_ulica_l.Name = "kontakt_adresa_ulica_l";
            this.kontakt_adresa_ulica_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_adresa_ulica_l.TabIndex = 14;
            this.kontakt_adresa_ulica_l.Text = "label4";
            // 
            // kontakt_adresa_cislo_l
            // 
            this.kontakt_adresa_cislo_l.AutoSize = true;
            this.kontakt_adresa_cislo_l.Location = new System.Drawing.Point(27, 174);
            this.kontakt_adresa_cislo_l.Name = "kontakt_adresa_cislo_l";
            this.kontakt_adresa_cislo_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_adresa_cislo_l.TabIndex = 15;
            this.kontakt_adresa_cislo_l.Text = "label5";
            // 
            // kontakt_adresa_ulica_tb
            // 
            this.kontakt_adresa_ulica_tb.Location = new System.Drawing.Point(65, 145);
            this.kontakt_adresa_ulica_tb.Name = "kontakt_adresa_ulica_tb";
            this.kontakt_adresa_ulica_tb.Size = new System.Drawing.Size(178, 20);
            this.kontakt_adresa_ulica_tb.TabIndex = 16;
            // 
            // kontakt_adresa_cislo_tb
            // 
            this.kontakt_adresa_cislo_tb.Location = new System.Drawing.Point(65, 171);
            this.kontakt_adresa_cislo_tb.Name = "kontakt_adresa_cislo_tb";
            this.kontakt_adresa_cislo_tb.Size = new System.Drawing.Size(50, 20);
            this.kontakt_adresa_cislo_tb.TabIndex = 17;
           
            // 
            // kontakt_adresa_psc_tb
            // 
            this.kontakt_adresa_psc_tb.Location = new System.Drawing.Point(162, 171);
            this.kontakt_adresa_psc_tb.Name = "kontakt_adresa_psc_tb";
            this.kontakt_adresa_psc_tb.Size = new System.Drawing.Size(81, 20);
            this.kontakt_adresa_psc_tb.TabIndex = 18;
            // 
            // kontakt_adresa_psc_l
            // 
            this.kontakt_adresa_psc_l.AutoSize = true;
            this.kontakt_adresa_psc_l.Location = new System.Drawing.Point(121, 174);
            this.kontakt_adresa_psc_l.Name = "kontakt_adresa_psc_l";
            this.kontakt_adresa_psc_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_adresa_psc_l.TabIndex = 19;
            this.kontakt_adresa_psc_l.Text = "label6";
            // 
            // kontakt_adresa_l
            // 
            this.kontakt_adresa_l.AutoSize = true;
            this.kontakt_adresa_l.Location = new System.Drawing.Point(27, 94);
            this.kontakt_adresa_l.Name = "kontakt_adresa_l";
            this.kontakt_adresa_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_adresa_l.TabIndex = 20;
            this.kontakt_adresa_l.Text = "label9";
            this.kontakt_adresa_l.Text = Gui.Properties.Resources.Kontakt_adresa_l;
            // 
            // KontaktOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 294);
            this.Controls.Add(this.kontakt_adresa_l);
            this.Controls.Add(this.kontakt_adresa_psc_l);
            this.Controls.Add(this.kontakt_adresa_psc_tb);
            this.Controls.Add(this.kontakt_adresa_cislo_tb);
            this.Controls.Add(this.kontakt_adresa_ulica_tb);
            this.Controls.Add(this.kontakt_adresa_cislo_l);
            this.Controls.Add(this.kontakt_adresa_ulica_l);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.kontakt_telc_tb);
            this.Controls.Add(this.kontakt_email_tb);
            this.Controls.Add(this.kontakt_adresa_obec_tb);
            this.Controls.Add(this.kontakt_priezvisko_tb);
            this.Controls.Add(this.kontakt_meno_tb);
            this.Controls.Add(this.kontakt_telc_l);
            this.Controls.Add(this.kontakt_email_l);
            this.Controls.Add(this.kontakt_adresa_obec_l);
            this.Controls.Add(this.kontakt_priezvisko_l);
            this.Controls.Add(this.kontakt_meno_l);
            this.Controls.Add(this.ok_btn);
            this.Name = "KontaktOkno";
            this.Text = "Kontakt udalosť";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KontaktOkno_FormClosed);
            this.Load += new System.EventHandler(this.KontaktOkno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label kontakt_meno_l;
        private System.Windows.Forms.Label kontakt_priezvisko_l;
        private System.Windows.Forms.Label kontakt_adresa_obec_l;
        private System.Windows.Forms.Label kontakt_email_l;
        private System.Windows.Forms.Label kontakt_telc_l;
        private System.Windows.Forms.TextBox kontakt_meno_tb;
        private System.Windows.Forms.TextBox kontakt_priezvisko_tb;
        private System.Windows.Forms.TextBox kontakt_adresa_obec_tb;
        private System.Windows.Forms.TextBox kontakt_email_tb;
        private System.Windows.Forms.TextBox kontakt_telc_tb;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label kontakt_adresa_ulica_l;
        private System.Windows.Forms.Label kontakt_adresa_cislo_l;
        private System.Windows.Forms.TextBox kontakt_adresa_ulica_tb;
        private System.Windows.Forms.TextBox kontakt_adresa_cislo_tb;
        private System.Windows.Forms.TextBox kontakt_adresa_psc_tb;
        private System.Windows.Forms.Label kontakt_adresa_psc_l;
        private System.Windows.Forms.Label kontakt_adresa_l;
    }
}