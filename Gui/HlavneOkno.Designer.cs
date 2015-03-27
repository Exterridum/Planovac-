namespace Gui
{
    partial class HlavneOkno
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
            this.username_t = new System.Windows.Forms.Label();
            this.udalostiDataGridView1 = new System.Windows.Forms.DataGridView();
            this.kontaktyDataGridView = new System.Windows.Forms.DataGridView();
            this.poznamkyDataGridView = new System.Windows.Forms.DataGridView();
            this.vytvorit_udalost_btn = new MetroFramework.Controls.MetroButton();
            this.zmazat_udalost_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.vytvorit_kontakt_btn = new MetroFramework.Controls.MetroButton();
            this.zmazat_kontakt_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.vytvorit_poznamku_btn = new MetroFramework.Controls.MetroButton();
            this.zmazat_poznamku_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.udalostiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poznamkyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // username_t
            // 
            this.username_t.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username_t.Location = new System.Drawing.Point(1114, 286);
            this.username_t.Name = "username_t";
            this.username_t.Size = new System.Drawing.Size(150, 29);
            this.username_t.TabIndex = 0;
            this.username_t.Text = "label1";
            this.username_t.Click += new System.EventHandler(this.username_t_Click);
            // 
            // udalostiDataGridView1
            // 
            this.udalostiDataGridView1.AllowUserToAddRows = false;
            this.udalostiDataGridView1.AllowUserToDeleteRows = false;
            this.udalostiDataGridView1.AllowUserToResizeColumns = false;
            this.udalostiDataGridView1.AllowUserToResizeRows = false;
            this.udalostiDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.udalostiDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.udalostiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.udalostiDataGridView1.Location = new System.Drawing.Point(23, 115);
            this.udalostiDataGridView1.MultiSelect = false;
            this.udalostiDataGridView1.Name = "udalostiDataGridView1";
            this.udalostiDataGridView1.RowHeadersVisible = false;
            this.udalostiDataGridView1.RowTemplate.Height = 50;
            this.udalostiDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.udalostiDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.udalostiDataGridView1.Size = new System.Drawing.Size(300, 389);
            this.udalostiDataGridView1.TabIndex = 0;
            this.udalostiDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.udalostiDataGridView_CellClick);
            this.udalostiDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.udalostiDataGridView_CellFormatting);
            this.udalostiDataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.udalostiDataGridView_CellMouseEnter);
            // 
            // kontaktyDataGridView
            // 
            this.kontaktyDataGridView.AllowUserToAddRows = false;
            this.kontaktyDataGridView.AllowUserToDeleteRows = false;
            this.kontaktyDataGridView.AllowUserToResizeColumns = false;
            this.kontaktyDataGridView.AllowUserToResizeRows = false;
            this.kontaktyDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.kontaktyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.kontaktyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kontaktyDataGridView.Location = new System.Drawing.Point(389, 115);
            this.kontaktyDataGridView.MultiSelect = false;
            this.kontaktyDataGridView.Name = "kontaktyDataGridView";
            this.kontaktyDataGridView.RowHeadersVisible = false;
            this.kontaktyDataGridView.RowTemplate.Height = 50;
            this.kontaktyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kontaktyDataGridView.Size = new System.Drawing.Size(300, 389);
            this.kontaktyDataGridView.TabIndex = 0;
            this.kontaktyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kontaktyDataGridView_CellClick);
            this.kontaktyDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.kontaktyDataGridView_CellFormatting);
            this.kontaktyDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.kontaktyDataGridView_CellMouseEnter);
            // 
            // poznamkyDataGridView
            // 
            this.poznamkyDataGridView.AllowUserToAddRows = false;
            this.poznamkyDataGridView.AllowUserToDeleteRows = false;
            this.poznamkyDataGridView.AllowUserToResizeColumns = false;
            this.poznamkyDataGridView.AllowUserToResizeRows = false;
            this.poznamkyDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.poznamkyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.poznamkyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poznamkyDataGridView.Location = new System.Drawing.Point(739, 115);
            this.poznamkyDataGridView.MultiSelect = false;
            this.poznamkyDataGridView.Name = "poznamkyDataGridView";
            this.poznamkyDataGridView.RowHeadersVisible = false;
            this.poznamkyDataGridView.RowTemplate.Height = 50;
            this.poznamkyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
<<<<<<< HEAD
            this.poznamkyDataGridView.Size = new System.Drawing.Size(300, 450);
            this.poznamkyDataGridView.TabIndex = 1;
=======
            this.poznamkyDataGridView.Size = new System.Drawing.Size(300, 389);
            this.poznamkyDataGridView.TabIndex = 0;
>>>>>>> parent of 3ce4e61... Revert "GUI Upravý"
            this.poznamkyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poznamkyDataGridView_CellClick);
            this.poznamkyDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.poznamkyDataGridView_CellFormatting);
            this.poznamkyDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.poznamkyDataGridView_CellMouseEnter);
            // 
            // vytvorit_udalost_btn
            // 
            this.vytvorit_udalost_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.vytvorit_udalost_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vytvorit_udalost_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.vytvorit_udalost_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vytvorit_udalost_btn.Location = new System.Drawing.Point(23, 516);
            this.vytvorit_udalost_btn.Name = "vytvorit_udalost_btn";
            this.vytvorit_udalost_btn.Size = new System.Drawing.Size(133, 43);
            this.vytvorit_udalost_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.vytvorit_udalost_btn.TabIndex = 0;
            this.vytvorit_udalost_btn.Text = "metroButton1";
            this.vytvorit_udalost_btn.UseCustomBackColor = true;
            this.vytvorit_udalost_btn.UseCustomForeColor = true;
            this.vytvorit_udalost_btn.UseMnemonic = false;
            this.vytvorit_udalost_btn.UseSelectable = true;
            this.vytvorit_udalost_btn.Click += new System.EventHandler(this.vytvorit_udalost_btn_Click);
            // 
            // zmazat_udalost_btn
            // 
            this.zmazat_udalost_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.zmazat_udalost_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zmazat_udalost_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.zmazat_udalost_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zmazat_udalost_btn.Location = new System.Drawing.Point(162, 516);
            this.zmazat_udalost_btn.Name = "zmazat_udalost_btn";
            this.zmazat_udalost_btn.Size = new System.Drawing.Size(133, 43);
            this.zmazat_udalost_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.zmazat_udalost_btn.TabIndex = 1;
            this.zmazat_udalost_btn.Text = "metroButton1";
            this.zmazat_udalost_btn.UseCustomBackColor = true;
            this.zmazat_udalost_btn.UseCustomForeColor = true;
            this.zmazat_udalost_btn.UseMnemonic = false;
            this.zmazat_udalost_btn.UseSelectable = true;
            this.zmazat_udalost_btn.Click += new System.EventHandler(this.zmazat_udalost_btn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(144, 25);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Zoznam udalosti";
            // 
            // vytvorit_kontakt_btn
            // 
            this.vytvorit_kontakt_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.vytvorit_kontakt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vytvorit_kontakt_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.vytvorit_kontakt_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vytvorit_kontakt_btn.Location = new System.Drawing.Point(389, 516);
            this.vytvorit_kontakt_btn.Name = "vytvorit_kontakt_btn";
            this.vytvorit_kontakt_btn.Size = new System.Drawing.Size(133, 43);
            this.vytvorit_kontakt_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.vytvorit_kontakt_btn.TabIndex = 2;
            this.vytvorit_kontakt_btn.Text = "metroButton1";
            this.vytvorit_kontakt_btn.UseCustomBackColor = true;
            this.vytvorit_kontakt_btn.UseCustomForeColor = true;
            this.vytvorit_kontakt_btn.UseMnemonic = false;
            this.vytvorit_kontakt_btn.UseSelectable = true;
            this.vytvorit_kontakt_btn.Click += new System.EventHandler(this.vytvorit_kontakt_btn_Click);
            // 
            // zmazat_kontakt_btn
            // 
            this.zmazat_kontakt_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.zmazat_kontakt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zmazat_kontakt_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.zmazat_kontakt_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zmazat_kontakt_btn.Location = new System.Drawing.Point(528, 516);
            this.zmazat_kontakt_btn.Name = "zmazat_kontakt_btn";
            this.zmazat_kontakt_btn.Size = new System.Drawing.Size(133, 43);
            this.zmazat_kontakt_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.zmazat_kontakt_btn.TabIndex = 3;
            this.zmazat_kontakt_btn.Text = "metroButton1";
            this.zmazat_kontakt_btn.UseCustomBackColor = true;
            this.zmazat_kontakt_btn.UseCustomForeColor = true;
            this.zmazat_kontakt_btn.UseMnemonic = false;
            this.zmazat_kontakt_btn.UseSelectable = true;
            this.zmazat_kontakt_btn.Click += new System.EventHandler(this.zmazat_kontakt_btn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(389, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(161, 25);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Zoznam kontaktov";
            // 
            // vytvorit_poznamku_btn
            // 
            this.vytvorit_poznamku_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.vytvorit_poznamku_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vytvorit_poznamku_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.vytvorit_poznamku_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vytvorit_poznamku_btn.Location = new System.Drawing.Point(739, 516);
            this.vytvorit_poznamku_btn.Name = "vytvorit_poznamku_btn";
            this.vytvorit_poznamku_btn.Size = new System.Drawing.Size(133, 43);
            this.vytvorit_poznamku_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.vytvorit_poznamku_btn.TabIndex = 4;
            this.vytvorit_poznamku_btn.Text = "metroButton1";
            this.vytvorit_poznamku_btn.UseCustomBackColor = true;
            this.vytvorit_poznamku_btn.UseCustomForeColor = true;
            this.vytvorit_poznamku_btn.UseMnemonic = false;
            this.vytvorit_poznamku_btn.UseSelectable = true;
            this.vytvorit_poznamku_btn.Click += new System.EventHandler(this.vytvorit_poznamku_btn_Click);
            // 
            // zmazat_poznamku_btn
            // 
            this.zmazat_poznamku_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.zmazat_poznamku_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zmazat_poznamku_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.zmazat_poznamku_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zmazat_poznamku_btn.Location = new System.Drawing.Point(878, 516);
            this.zmazat_poznamku_btn.Name = "zmazat_poznamku_btn";
            this.zmazat_poznamku_btn.Size = new System.Drawing.Size(133, 43);
            this.zmazat_poznamku_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.zmazat_poznamku_btn.TabIndex = 5;
            this.zmazat_poznamku_btn.Text = "metroButton1";
            this.zmazat_poznamku_btn.UseCustomBackColor = true;
            this.zmazat_poznamku_btn.UseCustomForeColor = true;
            this.zmazat_poznamku_btn.UseMnemonic = false;
            this.zmazat_poznamku_btn.UseSelectable = true;
            this.zmazat_poznamku_btn.Click += new System.EventHandler(this.zmazat_poznamku_btn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(739, 85);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(166, 25);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Zoznam poznámok";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1114, 115);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            // 
            // HlavneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 582);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.zmazat_poznamku_btn);
            this.Controls.Add(this.vytvorit_poznamku_btn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.zmazat_kontakt_btn);
            this.Controls.Add(this.vytvorit_kontakt_btn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.zmazat_udalost_btn);
            this.Controls.Add(this.vytvorit_udalost_btn);
            this.Controls.Add(this.poznamkyDataGridView);
            this.Controls.Add(this.kontaktyDataGridView);
            this.Controls.Add(this.udalostiDataGridView1);
            this.Controls.Add(this.username_t);
            this.Name = "HlavneOkno";
            this.Text = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.RoyalBlue;
            this.Load += new System.EventHandler(this.HlavneOkno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udalostiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontaktyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poznamkyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_t;
        private System.Windows.Forms.DataGridView udalostiDataGridView1;
        private System.Windows.Forms.DataGridView kontaktyDataGridView;
        private System.Windows.Forms.DataGridView poznamkyDataGridView;
        private MetroFramework.Controls.MetroButton vytvorit_udalost_btn;
        private MetroFramework.Controls.MetroButton zmazat_udalost_btn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton vytvorit_kontakt_btn;
        private MetroFramework.Controls.MetroButton zmazat_kontakt_btn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton vytvorit_poznamku_btn;
        private MetroFramework.Controls.MetroButton zmazat_poznamku_btn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;

    }
}

