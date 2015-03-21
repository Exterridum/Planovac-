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
            this.okbtn = new System.Windows.Forms.Button();
            this.kontakt_meno_l = new System.Windows.Forms.Label();
            this.kontakt_priezvisko_l = new System.Windows.Forms.Label();
            this.kontakt_adresa_l = new System.Windows.Forms.Label();
            this.kontakt_email_l = new System.Windows.Forms.Label();
            this.kontakt_telc_l = new System.Windows.Forms.Label();
            this.kontakt_meno_tb = new System.Windows.Forms.TextBox();
            this.kontakt_priezvisko_tb = new System.Windows.Forms.TextBox();
            this.kontakt_adresa_tb = new System.Windows.Forms.TextBox();
            this.kontakt_email_tb = new System.Windows.Forms.TextBox();
            this.kontakt_telc_tb = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(261, 22);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(75, 23);
            this.okbtn.TabIndex = 0;
            this.okbtn.Text = "button1";
            this.okbtn.UseVisualStyleBackColor = true;
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
            // kontakt_adresa_l
            // 
            this.kontakt_adresa_l.AutoSize = true;
            this.kontakt_adresa_l.Location = new System.Drawing.Point(27, 92);
            this.kontakt_adresa_l.Name = "kontakt_adresa_l";
            this.kontakt_adresa_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_adresa_l.TabIndex = 5;
            this.kontakt_adresa_l.Text = "label3";
            // 
            // kontakt_email_l
            // 
            this.kontakt_email_l.AutoSize = true;
            this.kontakt_email_l.Location = new System.Drawing.Point(27, 198);
            this.kontakt_email_l.Name = "kontakt_email_l";
            this.kontakt_email_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_email_l.TabIndex = 6;
            this.kontakt_email_l.Text = "label4";
            // 
            // kontakt_telc_l
            // 
            this.kontakt_telc_l.AutoSize = true;
            this.kontakt_telc_l.Location = new System.Drawing.Point(27, 224);
            this.kontakt_telc_l.Name = "kontakt_telc_l";
            this.kontakt_telc_l.Size = new System.Drawing.Size(35, 13);
            this.kontakt_telc_l.TabIndex = 7;
            this.kontakt_telc_l.Text = "label5";
            // 
            // kontakt_meno_tb
            // 
            this.kontakt_meno_tb.Location = new System.Drawing.Point(65, 22);
            this.kontakt_meno_tb.Name = "kontakt_meno_tb";
            this.kontakt_meno_tb.Size = new System.Drawing.Size(178, 20);
            this.kontakt_meno_tb.TabIndex = 8;
            this.kontakt_meno_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // kontakt_priezvisko_tb
            // 
            this.kontakt_priezvisko_tb.Location = new System.Drawing.Point(65, 54);
            this.kontakt_priezvisko_tb.Name = "kontakt_priezvisko_tb";
            this.kontakt_priezvisko_tb.Size = new System.Drawing.Size(178, 20);
            this.kontakt_priezvisko_tb.TabIndex = 9;
            // 
            // kontakt_adresa_tb
            // 
            this.kontakt_adresa_tb.Location = new System.Drawing.Point(65, 89);
            this.kontakt_adresa_tb.Multiline = true;
            this.kontakt_adresa_tb.Name = "kontakt_adresa_tb";
            this.kontakt_adresa_tb.Size = new System.Drawing.Size(178, 100);
            this.kontakt_adresa_tb.TabIndex = 10;
            // 
            // kontakt_email_tb
            // 
            this.kontakt_email_tb.Location = new System.Drawing.Point(65, 195);
            this.kontakt_email_tb.Name = "kontakt_email_tb";
            this.kontakt_email_tb.Size = new System.Drawing.Size(178, 20);
            this.kontakt_email_tb.TabIndex = 11;
            // 
            // kontakt_telc_tb
            // 
            this.kontakt_telc_tb.Location = new System.Drawing.Point(65, 221);
            this.kontakt_telc_tb.Name = "kontakt_telc_tb";
            this.kontakt_telc_tb.Size = new System.Drawing.Size(178, 20);
            this.kontakt_telc_tb.TabIndex = 12;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(261, 51);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 13;
            this.cancelbtn.Text = "button2";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // KontaktOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 263);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.kontakt_telc_tb);
            this.Controls.Add(this.kontakt_email_tb);
            this.Controls.Add(this.kontakt_adresa_tb);
            this.Controls.Add(this.kontakt_priezvisko_tb);
            this.Controls.Add(this.kontakt_meno_tb);
            this.Controls.Add(this.kontakt_telc_l);
            this.Controls.Add(this.kontakt_email_l);
            this.Controls.Add(this.kontakt_adresa_l);
            this.Controls.Add(this.kontakt_priezvisko_l);
            this.Controls.Add(this.kontakt_meno_l);
            this.Controls.Add(this.okbtn);
            this.Name = "KontaktOkno";
            this.Text = "KontaktOkno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Label kontakt_meno_l;
        private System.Windows.Forms.Label kontakt_priezvisko_l;
        private System.Windows.Forms.Label kontakt_adresa_l;
        private System.Windows.Forms.Label kontakt_email_l;
        private System.Windows.Forms.Label kontakt_telc_l;
        private System.Windows.Forms.TextBox kontakt_meno_tb;
        private System.Windows.Forms.TextBox kontakt_priezvisko_tb;
        private System.Windows.Forms.TextBox kontakt_adresa_tb;
        private System.Windows.Forms.TextBox kontakt_email_tb;
        private System.Windows.Forms.TextBox kontakt_telc_tb;
        private System.Windows.Forms.Button cancelbtn;
    }
}