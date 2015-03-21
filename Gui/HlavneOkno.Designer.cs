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
            this.username_tb = new System.Windows.Forms.Label();
            this.udalostiDataGridView = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.vytvorit_udalost_btn = new System.Windows.Forms.Button();
            this.zmazat_udalost_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udalostiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(1124, 226);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(100, 23);
            this.username_tb.TabIndex = 0;
            this.username_tb.Text = "label1";
            // 
            // udalostiDataGridView
            // 
            this.udalostiDataGridView.AllowUserToAddRows = false;
            this.udalostiDataGridView.AllowUserToDeleteRows = false;
            this.udalostiDataGridView.AllowUserToResizeColumns = false;
            this.udalostiDataGridView.AllowUserToResizeRows = false;
            this.udalostiDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.udalostiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.udalostiDataGridView.Location = new System.Drawing.Point(32, 70);
            this.udalostiDataGridView.MultiSelect = false;
            this.udalostiDataGridView.Name = "udalostiDataGridView";
            this.udalostiDataGridView.RowHeadersVisible = false;
            this.udalostiDataGridView.RowTemplate.Height = 50;
            this.udalostiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.udalostiDataGridView.Size = new System.Drawing.Size(300, 450);
            this.udalostiDataGridView.TabIndex = 1;
            this.udalostiDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.udalostiDataGridView_CellClick);
            this.udalostiDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.udalostiDataGridView_CellFormatting);
            this.udalostiDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.udalostiDataGridView_CellMouseEnter);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1127, 25);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // vytvorit_udalost_btn
            // 
            this.vytvorit_udalost_btn.Location = new System.Drawing.Point(32, 23);
            this.vytvorit_udalost_btn.Name = "vytvorit_udalost_btn";
            this.vytvorit_udalost_btn.Size = new System.Drawing.Size(139, 31);
            this.vytvorit_udalost_btn.TabIndex = 3;
            this.vytvorit_udalost_btn.Text = "button1";
            this.vytvorit_udalost_btn.UseVisualStyleBackColor = true;
            this.vytvorit_udalost_btn.Click += new System.EventHandler(this.vytvorit_udalost_btn_Click);
            // 
            // zmazat_udalost_btn
            // 
            this.zmazat_udalost_btn.Location = new System.Drawing.Point(32, 535);
            this.zmazat_udalost_btn.Name = "zmazat_udalost_btn";
            this.zmazat_udalost_btn.Size = new System.Drawing.Size(139, 31);
            this.zmazat_udalost_btn.TabIndex = 4;
            this.zmazat_udalost_btn.Text = "button2";
            this.zmazat_udalost_btn.UseVisualStyleBackColor = true;
            this.zmazat_udalost_btn.Click += new System.EventHandler(this.zmazat_udalost_btn_Click);
            // 
            // HlavneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1324, 592);
            this.Controls.Add(this.zmazat_udalost_btn);
            this.Controls.Add(this.vytvorit_udalost_btn);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.udalostiDataGridView);
            this.Controls.Add(this.username_tb);
            this.DoubleBuffered = true;
            this.Name = "HlavneOkno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HlavneOkno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udalostiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label username_tb;
        private System.Windows.Forms.DataGridView udalostiDataGridView;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button vytvorit_udalost_btn;
        private System.Windows.Forms.Button zmazat_udalost_btn;

    }
}

