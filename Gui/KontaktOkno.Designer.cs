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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.kontakt_meno_l = new MetroFramework.Controls.MetroLabel();
            this.kontakt_meno_tb = new System.Windows.Forms.TextBox();
            this.kontakt_priezvisko_l = new MetroFramework.Controls.MetroLabel();
            this.kontakt_priezvisko_tb = new System.Windows.Forms.TextBox();
            this.kontakt_adresa_l = new MetroFramework.Controls.MetroLabel();
            this.kontakt_adresa_obec_l = new MetroFramework.Controls.MetroLabel();
            this.kontakt_adresa_obec_tb = new System.Windows.Forms.TextBox();
            this.kontakt_adresa_ulica_l = new MetroFramework.Controls.MetroLabel();
            this.kontakt_adresa_ulica_tb = new System.Windows.Forms.TextBox();
            this.kontakt_adresa_cislo_l = new MetroFramework.Controls.MetroLabel();
            this.kontakt_adresa_cislo_tb = new System.Windows.Forms.TextBox();
            this.kontakt_adresa_psc_l = new MetroFramework.Controls.MetroLabel();
            this.kontakt_adresa_psc_tb = new System.Windows.Forms.TextBox();
            this.kontakt_telc_l = new MetroFramework.Controls.MetroLabel();
            this.kontakt_telc_tb = new System.Windows.Forms.TextBox();
            this.kontakt_email_l = new MetroFramework.Controls.MetroLabel();
            this.kontakt_email_tb = new System.Windows.Forms.TextBox();
            this.cancel_btn = new MetroFramework.Controls.MetroButton();
            this.ok_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(21, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(171, 25);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Vytvorenie kontaktu";
            // 
            // kontakt_meno_l
            // 
            this.kontakt_meno_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.kontakt_meno_l.Location = new System.Drawing.Point(21, 66);
            this.kontakt_meno_l.Name = "kontakt_meno_l";
            this.kontakt_meno_l.Size = new System.Drawing.Size(56, 28);
            this.kontakt_meno_l.TabIndex = 25;
            this.kontakt_meno_l.Text = "Názov";
            this.kontakt_meno_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kontakt_meno_tb
            // 
            this.kontakt_meno_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontakt_meno_tb.Location = new System.Drawing.Point(83, 66);
            this.kontakt_meno_tb.Multiline = true;
            this.kontakt_meno_tb.Name = "kontakt_meno_tb";
            this.kontakt_meno_tb.Size = new System.Drawing.Size(280, 28);
            this.kontakt_meno_tb.TabIndex = 0;
            // 
            // kontakt_priezvisko_l
            // 
            this.kontakt_priezvisko_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.kontakt_priezvisko_l.Location = new System.Drawing.Point(21, 105);
            this.kontakt_priezvisko_l.Name = "kontakt_priezvisko_l";
            this.kontakt_priezvisko_l.Size = new System.Drawing.Size(79, 28);
            this.kontakt_priezvisko_l.TabIndex = 28;
            this.kontakt_priezvisko_l.Text = "Priezvisko";
            this.kontakt_priezvisko_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kontakt_priezvisko_tb
            // 
            this.kontakt_priezvisko_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontakt_priezvisko_tb.Location = new System.Drawing.Point(106, 105);
            this.kontakt_priezvisko_tb.Multiline = true;
            this.kontakt_priezvisko_tb.Name = "kontakt_priezvisko_tb";
            this.kontakt_priezvisko_tb.Size = new System.Drawing.Size(257, 28);
            this.kontakt_priezvisko_tb.TabIndex = 1;
            // 
            // kontakt_adresa_l
            // 
            this.kontakt_adresa_l.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.kontakt_adresa_l.Location = new System.Drawing.Point(21, 165);
            this.kontakt_adresa_l.Name = "kontakt_adresa_l";
            this.kontakt_adresa_l.Size = new System.Drawing.Size(79, 28);
            this.kontakt_adresa_l.TabIndex = 29;
            this.kontakt_adresa_l.Text = "Adresa";
            this.kontakt_adresa_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kontakt_adresa_obec_l
            // 
            this.kontakt_adresa_obec_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.kontakt_adresa_obec_l.Location = new System.Drawing.Point(21, 198);
            this.kontakt_adresa_obec_l.Name = "kontakt_adresa_obec_l";
            this.kontakt_adresa_obec_l.Size = new System.Drawing.Size(56, 28);
            this.kontakt_adresa_obec_l.TabIndex = 31;
            this.kontakt_adresa_obec_l.Text = "Obec";
            this.kontakt_adresa_obec_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kontakt_adresa_obec_tb
            // 
            this.kontakt_adresa_obec_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontakt_adresa_obec_tb.Location = new System.Drawing.Point(83, 198);
            this.kontakt_adresa_obec_tb.Multiline = true;
            this.kontakt_adresa_obec_tb.Name = "kontakt_adresa_obec_tb";
            this.kontakt_adresa_obec_tb.Size = new System.Drawing.Size(280, 28);
            this.kontakt_adresa_obec_tb.TabIndex = 2;
            // 
            // kontakt_adresa_ulica_l
            // 
            this.kontakt_adresa_ulica_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.kontakt_adresa_ulica_l.Location = new System.Drawing.Point(21, 237);
            this.kontakt_adresa_ulica_l.Name = "kontakt_adresa_ulica_l";
            this.kontakt_adresa_ulica_l.Size = new System.Drawing.Size(56, 28);
            this.kontakt_adresa_ulica_l.TabIndex = 33;
            this.kontakt_adresa_ulica_l.Text = "Ulica";
            this.kontakt_adresa_ulica_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kontakt_adresa_ulica_tb
            // 
            this.kontakt_adresa_ulica_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontakt_adresa_ulica_tb.Location = new System.Drawing.Point(83, 237);
            this.kontakt_adresa_ulica_tb.Multiline = true;
            this.kontakt_adresa_ulica_tb.Name = "kontakt_adresa_ulica_tb";
            this.kontakt_adresa_ulica_tb.Size = new System.Drawing.Size(280, 28);
            this.kontakt_adresa_ulica_tb.TabIndex = 3;
            // 
            // kontakt_adresa_cislo_l
            // 
            this.kontakt_adresa_cislo_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.kontakt_adresa_cislo_l.Location = new System.Drawing.Point(21, 276);
            this.kontakt_adresa_cislo_l.Name = "kontakt_adresa_cislo_l";
            this.kontakt_adresa_cislo_l.Size = new System.Drawing.Size(56, 28);
            this.kontakt_adresa_cislo_l.TabIndex = 35;
            this.kontakt_adresa_cislo_l.Text = "Číslo";
            this.kontakt_adresa_cislo_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kontakt_adresa_cislo_tb
            // 
            this.kontakt_adresa_cislo_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontakt_adresa_cislo_tb.Location = new System.Drawing.Point(83, 276);
            this.kontakt_adresa_cislo_tb.Multiline = true;
            this.kontakt_adresa_cislo_tb.Name = "kontakt_adresa_cislo_tb";
            this.kontakt_adresa_cislo_tb.Size = new System.Drawing.Size(109, 28);
            this.kontakt_adresa_cislo_tb.TabIndex = 4;
            // 
            // kontakt_adresa_psc_l
            // 
            this.kontakt_adresa_psc_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.kontakt_adresa_psc_l.Location = new System.Drawing.Point(21, 315);
            this.kontakt_adresa_psc_l.Name = "kontakt_adresa_psc_l";
            this.kontakt_adresa_psc_l.Size = new System.Drawing.Size(56, 28);
            this.kontakt_adresa_psc_l.TabIndex = 37;
            this.kontakt_adresa_psc_l.Text = "PSČ";
            this.kontakt_adresa_psc_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kontakt_adresa_psc_tb
            // 
            this.kontakt_adresa_psc_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontakt_adresa_psc_tb.Location = new System.Drawing.Point(83, 315);
            this.kontakt_adresa_psc_tb.Multiline = true;
            this.kontakt_adresa_psc_tb.Name = "kontakt_adresa_psc_tb";
            this.kontakt_adresa_psc_tb.Size = new System.Drawing.Size(109, 28);
            this.kontakt_adresa_psc_tb.TabIndex = 5;
            // 
            // kontakt_telc_l
            // 
            this.kontakt_telc_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.kontakt_telc_l.Location = new System.Drawing.Point(21, 393);
            this.kontakt_telc_l.Name = "kontakt_telc_l";
            this.kontakt_telc_l.Size = new System.Drawing.Size(64, 28);
            this.kontakt_telc_l.TabIndex = 41;
            this.kontakt_telc_l.Text = "Telefon";
            this.kontakt_telc_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kontakt_telc_tb
            // 
            this.kontakt_telc_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontakt_telc_tb.Location = new System.Drawing.Point(91, 393);
            this.kontakt_telc_tb.Multiline = true;
            this.kontakt_telc_tb.Name = "kontakt_telc_tb";
            this.kontakt_telc_tb.Size = new System.Drawing.Size(158, 28);
            this.kontakt_telc_tb.TabIndex = 7;
            // 
            // kontakt_email_l
            // 
            this.kontakt_email_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.kontakt_email_l.Location = new System.Drawing.Point(21, 354);
            this.kontakt_email_l.Name = "kontakt_email_l";
            this.kontakt_email_l.Size = new System.Drawing.Size(56, 28);
            this.kontakt_email_l.TabIndex = 39;
            this.kontakt_email_l.Text = "Email";
            this.kontakt_email_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kontakt_email_tb
            // 
            this.kontakt_email_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontakt_email_tb.Location = new System.Drawing.Point(83, 354);
            this.kontakt_email_tb.Multiline = true;
            this.kontakt_email_tb.Name = "kontakt_email_tb";
            this.kontakt_email_tb.Size = new System.Drawing.Size(280, 28);
            this.kontakt_email_tb.TabIndex = 6;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_btn.Location = new System.Drawing.Point(91, 450);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(73, 43);
            this.cancel_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "Zrušiť";
            this.cancel_btn.UseCustomBackColor = true;
            this.cancel_btn.UseCustomForeColor = true;
            this.cancel_btn.UseMnemonic = false;
            this.cancel_btn.UseSelectable = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_click);
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ok_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok_btn.Location = new System.Drawing.Point(21, 450);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(64, 43);
            this.ok_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.ok_btn.TabIndex = 8;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseCustomBackColor = true;
            this.ok_btn.UseCustomForeColor = true;
            this.ok_btn.UseMnemonic = false;
            this.ok_btn.UseSelectable = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_click);
            // 
            // KontaktOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(394, 516);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.kontakt_telc_l);
            this.Controls.Add(this.kontakt_telc_tb);
            this.Controls.Add(this.kontakt_email_l);
            this.Controls.Add(this.kontakt_email_tb);
            this.Controls.Add(this.kontakt_adresa_psc_l);
            this.Controls.Add(this.kontakt_adresa_psc_tb);
            this.Controls.Add(this.kontakt_adresa_cislo_l);
            this.Controls.Add(this.kontakt_adresa_cislo_tb);
            this.Controls.Add(this.kontakt_adresa_ulica_l);
            this.Controls.Add(this.kontakt_adresa_ulica_tb);
            this.Controls.Add(this.kontakt_adresa_obec_l);
            this.Controls.Add(this.kontakt_adresa_obec_tb);
            this.Controls.Add(this.kontakt_adresa_l);
            this.Controls.Add(this.kontakt_priezvisko_l);
            this.Controls.Add(this.kontakt_priezvisko_tb);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.kontakt_meno_l);
            this.Controls.Add(this.kontakt_meno_tb);
            this.Name = "KontaktOkno";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontakt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KontaktOkno_FormClosed);
            this.Load += new System.EventHandler(this.KontaktOkno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel kontakt_meno_l;
        private System.Windows.Forms.TextBox kontakt_meno_tb;
        private MetroFramework.Controls.MetroLabel kontakt_priezvisko_l;
        private System.Windows.Forms.TextBox kontakt_priezvisko_tb;
        private MetroFramework.Controls.MetroLabel kontakt_adresa_l;
        private MetroFramework.Controls.MetroLabel kontakt_adresa_obec_l;
        private System.Windows.Forms.TextBox kontakt_adresa_obec_tb;
        private MetroFramework.Controls.MetroLabel kontakt_adresa_ulica_l;
        private System.Windows.Forms.TextBox kontakt_adresa_ulica_tb;
        private MetroFramework.Controls.MetroLabel kontakt_adresa_cislo_l;
        private System.Windows.Forms.TextBox kontakt_adresa_cislo_tb;
        private MetroFramework.Controls.MetroLabel kontakt_adresa_psc_l;
        private System.Windows.Forms.TextBox kontakt_adresa_psc_tb;
        private MetroFramework.Controls.MetroLabel kontakt_telc_l;
        private System.Windows.Forms.TextBox kontakt_telc_tb;
        private MetroFramework.Controls.MetroLabel kontakt_email_l;
        private System.Windows.Forms.TextBox kontakt_email_tb;
        private MetroFramework.Controls.MetroButton cancel_btn;
        private MetroFramework.Controls.MetroButton ok_btn;
    }
}