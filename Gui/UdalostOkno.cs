// <copyright file="UdalostOkno.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda UdalostOkno
// </summary>
// <author>tnguyen</author>

using System;
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
    /// <summary>
    /// Parcialna trieda UdalostOkno
    /// </summary>
    public partial class UdalostOkno : Form
    {
        /// <summary>
        /// Udalost dto
        /// </summary>
        private Udalost dto;

        /// <summary>
        /// Udalost business objekt
        /// </summary>
        private UdalostBusiness ub;

        /// <summary>
        /// Boolean ktory naznacuje ci sa okno otvorilo pre Update alebo Insert
        /// </summary>
        private bool isUpdate;

        /// <summary>
        /// Tento konstruktor sa vola ked sa bude vytvarat nova Udalost
        /// </summary>
        public UdalostOkno()
        {
            InitializeComponent();
            ub = new UdalostBusiness();

            // nastavim date time picker na teraz
            this.udalost_cas_dtp.Value = DateTime.Now;    
        }

        /// <summary>
        /// Tento konstruktor sa vola ked sa bude len menit uz existujuca udalost
        /// </summary>
        /// <param name="id">id zaznamu</param>
        public UdalostOkno(long id)
        {
            InitializeComponent();
            ub = new UdalostBusiness();

            // ziskam zaznam s danym id
            dto = ub.ZiskajZaznam(id);

            // nasetujem hodnoty text boxov
            this.udalost_nazov_tb.Text = dto.Nazov;
            this.udalost_popisUdalosti_tb.Text = dto.PopisUdalosti;
            this.udalost_miesto_tb.Text = dto.Miesto;
            this.udalost_cas_dtp.Value = dto.Cas;
            this.udalost_priorita_chb.Checked = dto.Priorita;

            // okno bolo otvorene pre Update
            isUpdate = true;
        }

        /// <summary>
        /// Event handler - nacitanie formulara
        /// Nacitanie formulara
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void UdalostOkno_Load(object sender, EventArgs e)
        {
            // nastavujem meno okna a label-y stringami z resources
            this.Text = Resources.UdalostOknoNazov;
            this.udalost_nazov_l.Text = Resources.Udalost_nazov_l + " :";
            this.udalost_popisUdalosti_l.Text = Resources.Udalost_popisUdalosti_l + " :";
            this.udalost_miesto_l.Text = Resources.Udalost_miesto_l + " :";
            this.udalost_cas_l.Text = Resources.Udalost_cas_l + " :";
            this.udalost_priorita_chb.Text = Resources.Udalost_priorita_chb;
            this.ok_btn.Text = Resources.OkBtn;
            this.cancel_btn.Text = Resources.ZrusitBtn;

            // po stlaceni enter sa ma stlacit tlac ok
            this.AcceptButton = this.ok_btn;

            // vynimka - nastavenie multiline textboxu aby po stlaceni Enter isiel na novy riadok (nie automatikcy stlacik Ok)
            this.udalost_popisUdalosti_tb.AcceptsReturn = true;       
        }

        /// <summary>
        /// Event handler - kliknutie na tlacitko OK
        /// Zapisuje zaznam do DB
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void ok_btn_Click(object sender, EventArgs e)
        {
            // kontrola ci su povinne polia vyplnene
            if ( !String.IsNullOrEmpty(udalost_nazov_tb.Text) && (udalost_cas_dtp.Value != null) ) 
            {
                if (isUpdate)
                {
                    // Udate
                    dto.Nazov = udalost_nazov_tb.Text;
                    dto.PopisUdalosti = udalost_popisUdalosti_tb.Text;
                    dto.Miesto = udalost_miesto_tb.Text;
                    dto.Cas = udalost_cas_dtp.Value;
                    dto.Priorita = udalost_priorita_chb.Checked;

                    // zmenim zaznam v DB
                    ub.ZmenZaznamVDB(dto);

                    // zatvor formular
                    this.Close();
                }
                else
                {
                    // Insert
                    dto = new Udalost();
                    dto.User = Environment.UserName;
                    dto.Nazov = udalost_nazov_tb.Text;
                    dto.PopisUdalosti = udalost_popisUdalosti_tb.Text;
                    dto.Miesto = udalost_miesto_tb.Text;
                    dto.Cas = udalost_cas_dtp.Value;
                    dto.Priorita = udalost_priorita_chb.Checked;

                    // zapisem do DB a ulozim si nove id
                    dto.Id = ub.ZapisZaznamDoDB(dto);

                    // zatvor formular
                    this.Close();
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("   " + Resources.TrebaVypPolia + " :");
                sb.AppendLine("");
                sb.AppendLine("      - " + Resources.Nazov);
                MessageBox.Show(sb.ToString(), Resources.Info, MessageBoxButtons.OK, MessageBoxIcon.Information);         
            }                   
        }

        /// <summary>
        /// Event handler - kliknutie na tlacitko Zrusit
        /// Zatvori formular
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler - zatvorenie formulara
        /// Vykona sa pred zatvorenim okna
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void UdalostOkno_FormClosed(object sender, FormClosedEventArgs e)
        {         
            if (dto != null)
            {
                HlavneOkno rodic = (HlavneOkno)this.Owner;
                            
                // updatuj hlavne okno (po refreshe vyskoci scrollbar uplne na vrch datagridview)
                rodic.RefreshDataGrid<Udalost>(rodic.UdalostiDataGridView, ub);

                // oznac zaznam
                int row_index = rodic.OznacZaznamSIdVDataGride(rodic.UdalostiDataGridView, dto.Id);

                // scrolluj k danemu zaznamu
                rodic.ScrollujDataGridKZaznamu(rodic.UdalostiDataGridView, row_index);           
            }          
        }   
    }
}
