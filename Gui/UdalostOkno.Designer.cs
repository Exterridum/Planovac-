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
            this.udalost_popisUdalosti_tb = new System.Windows.Forms.TextBox();
            this.udalost_miesto_tb = new System.Windows.Forms.TextBox();
            this.udalost_cas_dtp = new System.Windows.Forms.DateTimePicker();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.udalost_priorita_chb = new System.Windows.Forms.CheckBox();
            this.udalost_nazov_l = new System.Windows.Forms.Label();
            this.udalost_popisUdalosti_l = new System.Windows.Forms.Label();
            this.udalost_miesto_l = new System.Windows.Forms.Label();
            this.udalost_cas_l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // udalost_nazov_tb
            // 
            this.udalost_nazov_tb.Location = new System.Drawing.Point(21, 45);
            this.udalost_nazov_tb.Name = "udalost_nazov_tb";
            this.udalost_nazov_tb.Size = new System.Drawing.Size(482, 20);
            this.udalost_nazov_tb.TabIndex = 0;
            // 
            // udalost_popisUdalosti_tb
            // 
            this.udalost_popisUdalosti_tb.Location = new System.Drawing.Point(21, 107);
            this.udalost_popisUdalosti_tb.Multiline = true;
            this.udalost_popisUdalosti_tb.Name = "udalost_popisUdalosti_tb";
            this.udalost_popisUdalosti_tb.Size = new System.Drawing.Size(482, 84);
            this.udalost_popisUdalosti_tb.TabIndex = 1;
            // 
            // udalost_miesto_tb
            // 
            this.udalost_miesto_tb.Location = new System.Drawing.Point(21, 234);
            this.udalost_miesto_tb.Name = "udalost_miesto_tb";
            this.udalost_miesto_tb.Size = new System.Drawing.Size(482, 20);
            this.udalost_miesto_tb.TabIndex = 2;
            // 
            // udalost_cas_dtp
            // 
            this.udalost_cas_dtp.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.udalost_cas_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.udalost_cas_dtp.Location = new System.Drawing.Point(21, 304);
            this.udalost_cas_dtp.Name = "udalost_cas_dtp";
            this.udalost_cas_dtp.Size = new System.Drawing.Size(200, 20);
            this.udalost_cas_dtp.TabIndex = 3;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(329, 407);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 5;
            this.ok_btn.Text = "button1";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(428, 407);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "button2";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // udalost_priorita_chb
            // 
            this.udalost_priorita_chb.AutoSize = true;
            this.udalost_priorita_chb.Location = new System.Drawing.Point(21, 354);
            this.udalost_priorita_chb.Name = "udalost_priorita_chb";
            this.udalost_priorita_chb.Size = new System.Drawing.Size(80, 17);
            this.udalost_priorita_chb.TabIndex = 4;
            this.udalost_priorita_chb.Text = "checkBox1";
            this.udalost_priorita_chb.UseVisualStyleBackColor = true;
            // 
            // udalost_nazov_l
            // 
            this.udalost_nazov_l.AutoSize = true;
            this.udalost_nazov_l.Location = new System.Drawing.Point(18, 18);
            this.udalost_nazov_l.Name = "udalost_nazov_l";
            this.udalost_nazov_l.Size = new System.Drawing.Size(35, 13);
            this.udalost_nazov_l.TabIndex = 7;
            this.udalost_nazov_l.Text = "label1";
            // 
            // udalost_popisUdalosti_l
            // 
            this.udalost_popisUdalosti_l.AutoSize = true;
            this.udalost_popisUdalosti_l.Location = new System.Drawing.Point(18, 81);
            this.udalost_popisUdalosti_l.Name = "udalost_popisUdalosti_l";
            this.udalost_popisUdalosti_l.Size = new System.Drawing.Size(35, 13);
            this.udalost_popisUdalosti_l.TabIndex = 8;
            this.udalost_popisUdalosti_l.Text = "label2";
            // 
            // udalost_miesto_l
            // 
            this.udalost_miesto_l.AutoSize = true;
            this.udalost_miesto_l.Location = new System.Drawing.Point(18, 206);
            this.udalost_miesto_l.Name = "udalost_miesto_l";
            this.udalost_miesto_l.Size = new System.Drawing.Size(35, 13);
            this.udalost_miesto_l.TabIndex = 9;
            this.udalost_miesto_l.Text = "label3";
            // 
            // udalost_cas_l
            // 
            this.udalost_cas_l.AutoSize = true;
            this.udalost_cas_l.Location = new System.Drawing.Point(18, 278);
            this.udalost_cas_l.Name = "udalost_cas_l";
            this.udalost_cas_l.Size = new System.Drawing.Size(35, 13);
            this.udalost_cas_l.TabIndex = 10;
            this.udalost_cas_l.Text = "label4";
            // 
            // UdalostOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 462);
            this.Controls.Add(this.udalost_cas_l);
            this.Controls.Add(this.udalost_miesto_l);
            this.Controls.Add(this.udalost_popisUdalosti_l);
            this.Controls.Add(this.udalost_nazov_l);
            this.Controls.Add(this.udalost_priorita_chb);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.udalost_cas_dtp);
            this.Controls.Add(this.udalost_miesto_tb);
            this.Controls.Add(this.udalost_popisUdalosti_tb);
            this.Controls.Add(this.udalost_nazov_tb);
            this.Name = "UdalostOkno";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UdalostOkno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UdalostOkno_FormClosed);
            this.Load += new System.EventHandler(this.UdalostOkno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox udalost_nazov_tb;
        private System.Windows.Forms.TextBox udalost_popisUdalosti_tb;
        private System.Windows.Forms.TextBox udalost_miesto_tb;
        private System.Windows.Forms.DateTimePicker udalost_cas_dtp;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.CheckBox udalost_priorita_chb;
        private System.Windows.Forms.Label udalost_nazov_l;
        private System.Windows.Forms.Label udalost_popisUdalosti_l;
        private System.Windows.Forms.Label udalost_miesto_l;
        private System.Windows.Forms.Label udalost_cas_l;
    }
}