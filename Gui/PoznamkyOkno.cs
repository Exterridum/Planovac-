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
    public partial class PoznamkyOkno : Form
    {

        /// <summary>
        /// Dto objekt
        /// </summary>
        private Poznamka dto;

        private PoznamkyBussines kb;

        private bool isUpdate;

        public PoznamkyOkno()
        {
            InitializeComponent();
            kb = new PoznamkyBussines();
        }

        public PoznamkyOkno(long id)
        {
            InitializeComponent();
            kb = new PoznamkyBussines();
            dto = kb.ZiskajZaznam(id);

            this.nazov_textBox.Text = dto.Nazov;
            this.obsah_textBox.Text = dto.Obsah;

            isUpdate = true;
        }

        private void PoznamkyOkno_Load(object sender, EventArgs e)
        {
            this.nazov_label.Text = Resources.Poznamka_Nazov_label + " :";
            this.obsah_label.Text = Resources.Poznamka_Obsah_label + " :";
            this.ok_button_poznamky.Text = Resources.Ok_button_poznamky;
            this.close_button_poznamky.Text = Resources.Close_button_poznamky;

            this.AcceptButton = this.ok_button_poznamky;
            
        }

        private void close_button_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nazov_textBox.Text))
            {
                if (isUpdate)
                {
                    dto.Nazov = nazov_textBox.Text;
                    dto.Obsah = obsah_textBox.Text;

                    kb.ZmenZaznamVDB(dto);

                    this.Close();
                }
                else
                {
                   

                    dto = new Poznamka
                    {
                        User = Environment.UserName,
                        Nazov = nazov_textBox.Text,
                        Obsah = obsah_textBox.Text,
                        
                    };

                    dto.Id = kb.ZapisZaznamDoDB(dto);

                    this.Close();
                }
            }
            else
            {//TODO
                /*var sb = new StringBuilder();
                sb.AppendLine("   " + Resources.TrebaVypPolia + " :");
                sb.AppendLine("");
                sb.AppendLine("      - " + Resources.Nazov);
                MessageBox.Show(sb.ToString(), Resources.Info, MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
        }


        private void PoznamkyOkno_FormClosed(object sender, EventArgs e)
        {
            if (dto != null)
            {
                var parent = (HlavneOkno)this.Owner;
                parent.RefreshDataGrid<Poznamka>(parent.PoznamkyDataGridView, kb);

                int row_index = parent.OznacZaznamSIdVDataGride<Poznamka>(parent.PoznamkyDataGridView, dto.Id);

                parent.ScrollujDataGridKZaznamu(parent.PoznamkyDataGridView, row_index);
            }
        }
    }
}
