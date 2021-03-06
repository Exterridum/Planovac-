﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain.Dto;
using Gui.Properties;

namespace Gui
{
    public partial class KontaktOkno : Form
    {

        /// <summary>
        /// Dto objekt
        /// </summary>
        private Kontakt dto;

        private KontaktBusiness kb;

        private bool isUpdate;
        
        public KontaktOkno()
        {
            InitializeComponent();
            kb = new KontaktBusiness();
        }

        public KontaktOkno(long id)
        {
            InitializeComponent();
            kb = new KontaktBusiness();
            dto = kb.ZiskajZaznam(id);


            string stringAddress = dto.Adresa;
            string[] address = stringAddress.Split(' ');

            this.kontakt_meno_tb.Text = dto.Meno;
            this.kontakt_priezvisko_tb.Text = dto.Priezvisko;
            this.kontakt_adresa_obec_tb.Text = address[0];
            this.kontakt_adresa_ulica_tb.Text = address[1];
            this.kontakt_adresa_cislo_tb.Text = address[2];
            this.kontakt_adresa_psc_tb.Text = address[3];
            this.kontakt_email_tb.Text = dto.Email;
            this.kontakt_telc_tb.Text = dto.Telc;

            isUpdate = true;
        }

        private void KontaktOkno_Load(object sender, EventArgs e)
        {
            this.kontakt_meno_l.Text = Resources.Kontakt_meno_l + " :";
            this.kontakt_priezvisko_l.Text = Resources.Kontakt_priezvisko_l + " :";
            this.kontakt_adresa_obec_l.Text = Resources.Kontakt_adresa_obec_l;
            this.kontakt_adresa_obec_l.Text = Resources.Kontakt_adresa_obec_l + " :";
            this.kontakt_adresa_ulica_l.Text = Resources.Kontakt_adresa_ulica_l + " :";
            this.kontakt_adresa_cislo_l.Text = Resources.Kontakt_adresa_cislo_l + " :";
            this.kontakt_adresa_psc_l.Text = Resources.Kontakt_adresa_psc_l + " :";
            this.kontakt_email_l.Text = Resources.Kontakt_email_l + " :";
            this.kontakt_telc_l.Text = Resources.Kontakt_telc_l + " :";
            this.ok_btn.Text = Resources.OkBtn;
            this.cancel_btn.Text = Resources.ZrusitBtn;

            this.AcceptButton = this.ok_btn;
        }

        private void ok_btn_click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(kontakt_meno_tb.Text) && !String.IsNullOrEmpty(kontakt_priezvisko_tb.Text))
            {
                var sb = new StringBuilder();
                sb.Append(kontakt_adresa_obec_tb.Text);
                sb.Append(" ");
                sb.Append(kontakt_adresa_ulica_tb.Text);
                sb.Append(" ");
                sb.Append(kontakt_adresa_cislo_tb.Text);
                sb.Append(" ");
                sb.Append(kontakt_adresa_psc_tb.Text);

                if (isUpdate)
                {
                    dto.Meno = kontakt_meno_tb.Text;
                    dto.Priezvisko = kontakt_priezvisko_tb.Text;
                    dto.Adresa = sb.ToString();
                    dto.Email = kontakt_email_tb.Text;
                    dto.Telc = kontakt_telc_tb.Text;

                    kb.ZmenZaznamVDB(dto);
                    this.Close();
                }
                else
                {
                    dto = new Kontakt
                    {
                        User = Environment.UserName,
                        Meno = kontakt_meno_tb.Text,
                        Priezvisko = kontakt_priezvisko_tb.Text,
                        Adresa = sb.ToString(),
                        Email = kontakt_email_tb.Text,
                        Telc = kontakt_telc_tb.Text,
                    };

                    dto.Id = kb.ZapisZaznamDoDB(dto);

                    this.Close();
                }
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine("   " + Resources.TrebaVypPolia + " :");
                sb.AppendLine("");
                //sb.AppendLine("      - " + Resources.Nazov);
                if (String.IsNullOrEmpty(kontakt_meno_tb.Text)) sb.AppendLine(" - meno");
                if (String.IsNullOrEmpty(kontakt_priezvisko_tb.Text)) sb.AppendLine(" - priezvisko");
                MessageBox.Show(sb.ToString(), Resources.Info, MessageBoxButtons.OK, MessageBoxIcon.Information);         
            }
        }

        private void cancel_btn_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KontaktOkno_FormClosed(object sender, EventArgs e)
        {
            if (dto != null)
            {
                var parent = (HlavneOkno) this.Owner;
                parent.RefreshDataGrid<Kontakt>(parent.KontaktyDataGridView, kb);

                int row_index = parent.OznacZaznamSIdVDataGride<Kontakt>(parent.KontaktyDataGridView, dto.Id);

                parent.ScrollujDataGridKZaznamu(parent.KontaktyDataGridView, row_index);
            }
        }

    }
}
