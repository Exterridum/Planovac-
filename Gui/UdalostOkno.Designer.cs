namespace Gui
{
    partial class UdalostOkno
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
            this.udalost_nazov_tb = new System.Windows.Forms.TextBox();
            this.udalost_cas_dtp = new System.Windows.Forms.DateTimePicker();
            this.udalost_nazov_l = new MetroFramework.Controls.MetroLabel();
            this.udalost_popisUdalosti_l = new MetroFramework.Controls.MetroLabel();
            this.udalost_popisUdalosti_tb = new System.Windows.Forms.TextBox();
            this.udalost_miesto_l = new MetroFramework.Controls.MetroLabel();
            this.udalost_cas_l = new MetroFramework.Controls.MetroLabel();
            this.udalost_miesto_tb = new System.Windows.Forms.TextBox();
            this.udalost_priorita_chb = new MetroFramework.Controls.MetroCheckBox();
            this.ok_btn = new MetroFramework.Controls.MetroButton();
            this.cancel_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // udalost_nazov_tb
            // 
            this.udalost_nazov_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.udalost_nazov_tb.Location = new System.Drawing.Point(84, 67);
            this.udalost_nazov_tb.Multiline = true;
            this.udalost_nazov_tb.Name = "udalost_nazov_tb";
            this.udalost_nazov_tb.Size = new System.Drawing.Size(280, 28);
            this.udalost_nazov_tb.TabIndex = 0;
            // 
            // udalost_cas_dtp
            // 
            this.udalost_cas_dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.udalost_cas_dtp.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.udalost_cas_dtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.udalost_cas_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.udalost_cas_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.udalost_cas_dtp.Location = new System.Drawing.Point(84, 287);
            this.udalost_cas_dtp.Margin = new System.Windows.Forms.Padding(5);
            this.udalost_cas_dtp.Name = "udalost_cas_dtp";
            this.udalost_cas_dtp.Size = new System.Drawing.Size(158, 23);
            this.udalost_cas_dtp.TabIndex = 3;
            // 
            // udalost_nazov_l
            // 
            this.udalost_nazov_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.udalost_nazov_l.Location = new System.Drawing.Point(22, 67);
            this.udalost_nazov_l.Name = "udalost_nazov_l";
            this.udalost_nazov_l.Size = new System.Drawing.Size(56, 28);
            this.udalost_nazov_l.TabIndex = 16;
            this.udalost_nazov_l.Text = "Názov";
            this.udalost_nazov_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // udalost_popisUdalosti_l
            // 
            this.udalost_popisUdalosti_l.Cursor = System.Windows.Forms.Cursors.Default;
            this.udalost_popisUdalosti_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.udalost_popisUdalosti_l.Location = new System.Drawing.Point(22, 108);
            this.udalost_popisUdalosti_l.Name = "udalost_popisUdalosti_l";
            this.udalost_popisUdalosti_l.Size = new System.Drawing.Size(104, 28);
            this.udalost_popisUdalosti_l.TabIndex = 18;
            this.udalost_popisUdalosti_l.Text = "Popis udalosti";
            this.udalost_popisUdalosti_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // udalost_popisUdalosti_tb
            // 
            this.udalost_popisUdalosti_tb.BackColor = System.Drawing.Color.White;
            this.udalost_popisUdalosti_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.udalost_popisUdalosti_tb.Location = new System.Drawing.Point(22, 138);
            this.udalost_popisUdalosti_tb.Multiline = true;
            this.udalost_popisUdalosti_tb.Name = "udalost_popisUdalosti_tb";
            this.udalost_popisUdalosti_tb.Size = new System.Drawing.Size(342, 84);
            this.udalost_popisUdalosti_tb.TabIndex = 1;
            // 
            // udalost_miesto_l
            // 
            this.udalost_miesto_l.Cursor = System.Windows.Forms.Cursors.Default;
            this.udalost_miesto_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.udalost_miesto_l.Location = new System.Drawing.Point(22, 241);
            this.udalost_miesto_l.Name = "udalost_miesto_l";
            this.udalost_miesto_l.Size = new System.Drawing.Size(63, 28);
            this.udalost_miesto_l.TabIndex = 19;
            this.udalost_miesto_l.Text = "Miesto";
            this.udalost_miesto_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // udalost_cas_l
            // 
            this.udalost_cas_l.Cursor = System.Windows.Forms.Cursors.Default;
            this.udalost_cas_l.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.udalost_cas_l.Location = new System.Drawing.Point(22, 287);
            this.udalost_cas_l.Name = "udalost_cas_l";
            this.udalost_cas_l.Size = new System.Drawing.Size(42, 28);
            this.udalost_cas_l.TabIndex = 20;
            this.udalost_cas_l.Text = "Čas";
            this.udalost_cas_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // udalost_miesto_tb
            // 
            this.udalost_miesto_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.udalost_miesto_tb.Location = new System.Drawing.Point(84, 241);
            this.udalost_miesto_tb.Multiline = true;
            this.udalost_miesto_tb.Name = "udalost_miesto_tb";
            this.udalost_miesto_tb.Size = new System.Drawing.Size(280, 28);
            this.udalost_miesto_tb.TabIndex = 2;
            // 
            // udalost_priorita_chb
            // 
            this.udalost_priorita_chb.AutoSize = true;
            this.udalost_priorita_chb.Location = new System.Drawing.Point(22, 335);
            this.udalost_priorita_chb.Name = "udalost_priorita_chb";
            this.udalost_priorita_chb.Size = new System.Drawing.Size(61, 15);
            this.udalost_priorita_chb.TabIndex = 4;
            this.udalost_priorita_chb.Text = "priorita";
            this.udalost_priorita_chb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.udalost_priorita_chb.Theme = MetroFramework.MetroThemeStyle.Light;
            this.udalost_priorita_chb.UseSelectable = true;
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ok_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok_btn.Location = new System.Drawing.Point(22, 374);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(64, 43);
            this.ok_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.ok_btn.TabIndex = 5;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseCustomBackColor = true;
            this.ok_btn.UseCustomForeColor = true;
            this.ok_btn.UseMnemonic = false;
            this.ok_btn.UseSelectable = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_btn.Location = new System.Drawing.Point(92, 374);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(73, 43);
            this.cancel_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Zrušiť";
            this.cancel_btn.UseCustomBackColor = true;
            this.cancel_btn.UseCustomForeColor = true;
            this.cancel_btn.UseMnemonic = false;
            this.cancel_btn.UseSelectable = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(22, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 25);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Vytvorenie udalosti";
            // 
            // UdalostOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(389, 438);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.udalost_priorita_chb);
            this.Controls.Add(this.udalost_miesto_tb);
            this.Controls.Add(this.udalost_cas_l);
            this.Controls.Add(this.udalost_miesto_l);
            this.Controls.Add(this.udalost_popisUdalosti_l);
            this.Controls.Add(this.udalost_nazov_l);
            this.Controls.Add(this.udalost_cas_dtp);
            this.Controls.Add(this.udalost_nazov_tb);
            this.Controls.Add(this.udalost_popisUdalosti_tb);
            this.Name = "UdalostOkno";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Udalosť";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UdalostOkno_FormClosed);
            this.Load += new System.EventHandler(this.UdalostOkno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox udalost_nazov_tb;
        private System.Windows.Forms.DateTimePicker udalost_cas_dtp;
        private MetroFramework.Controls.MetroLabel udalost_nazov_l;
        private MetroFramework.Controls.MetroLabel udalost_popisUdalosti_l;
        private System.Windows.Forms.TextBox udalost_popisUdalosti_tb;
        private MetroFramework.Controls.MetroLabel udalost_miesto_l;
        private MetroFramework.Controls.MetroLabel udalost_cas_l;
        private System.Windows.Forms.TextBox udalost_miesto_tb;
        private MetroFramework.Controls.MetroCheckBox udalost_priorita_chb;
        private MetroFramework.Controls.MetroButton ok_btn;
        private MetroFramework.Controls.MetroButton cancel_btn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}