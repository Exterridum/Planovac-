﻿// <copyright file="HlavneOkno.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda HlavneOkno
// </summary>
// <author>tnguyen</author>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain.Dao;
using Domain.Dto;
using Gui.Properties;

namespace Gui
{
    /// <summary>
    /// Hlavne okno
    /// </summary>
    public partial class HlavneOkno : Form
    {
        /// <summary>
        /// Property UdalostiDataGridView
        /// </summary>
        public DataGridView UdalostiDataGridView
        {
            get { return udalostiDataGridView; }
        }

        /// <summary>
        /// Meno pouzivatela Windows
        /// </summary>
        private String Username { get; set; }

        /// <summary>
        /// Defaultny konstruktor
        /// </summary>
        public HlavneOkno()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler - nacitanie formulara
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void HlavneOkno_Load(object sender, EventArgs e)
        {
            // Zistim meno pouzivatela Windows
            this.Username = Environment.UserName;
            this.username_tb.Text = Resources.Uzivatel + ":  " + Username;

            // Nastavim nazvy z resources
            this.Text = Resources.HlavneOknoNazov;
            this.zmazat_udalost_btn.Text = Resources.TlacZmazUdalost;
            this.vytvorit_udalost_btn.Text = Resources.TlacVytvUdalost;

            // Inicializujem data gridy
            InicializujUdalostiDgv();
        }

        /* ****************************************************************************************** */
        /* **** 1. Udalosti DataGridView ************************************************************ */        
        /* ****************************************************************************************** */

        /// <summary>
        /// Inicializuje DataGridView Udalosti
        /// </summary>
        private void InicializujUdalostiDgv() 
        {
            //---------------------------------------------------------------------
            // 1. Nastavujem DataGridView                                    
            //---------------------------------------------------------------------
            udalostiDataGridView.AutoSize = false;
            udalostiDataGridView.Width = 340;
            udalostiDataGridView.AutoGenerateColumns = false;

            //---------------------------------------------------------------------
            // 2. Pridam rucne stplce do DataGridView
            //---------------------------------------------------------------------
            // stlpec s farebnym oznacovanim udalosti
            DataGridViewColumn column_0 = new DataGridViewTextBoxColumn();
            column_0.Width = 15;
            column_0.ReadOnly = true;
            udalostiDataGridView.Columns.Add(column_0);

            // checkbox column na mazanie
            DataGridViewCheckBoxColumn column_1 = new DataGridViewCheckBoxColumn();
            column_1.ValueType = typeof(bool);
            column_1.Width = 20;
            column_1.ReadOnly = false;
            udalostiDataGridView.Columns.Add(column_1);

            // stlpec nazov
            DataGridViewColumn column_2 = new DataGridViewTextBoxColumn();
            column_2.DataPropertyName = "Nazov";
            column_2.Name = "Názov";
            column_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column_2.MinimumWidth = 170;
            column_2.FillWeight = 100;
            column_2.ReadOnly = true;
            udalostiDataGridView.Columns.Add(column_2);

            // stlpec Cas
            DataGridViewColumn column_3 = new DataGridViewTextBoxColumn();
            column_3.DataPropertyName = "Cas";
            column_3.Name = "Dátum a čas";           
            column_3.Width = 99;
            column_3.ReadOnly = true;
            column_3.DefaultCellStyle.Format = "dd.MM.yyyy   HH:mm";
            udalostiDataGridView.Columns.Add(column_3);

            // stlpec priorita
            DataGridViewColumn column_4 = new DataGridViewTextBoxColumn();
            column_4.Width = 2;
            column_4.ReadOnly = true;
            udalostiDataGridView.Columns.Add(column_4);

            // Header check box na oznacenie vsetkych zaznamov
            CheckBox h_chBox = new CheckBox();
            h_chBox.Name = "header_checkbox";

            // ziskam zobrazovaci obdlznik header bunky
            Rectangle rect = this.udalostiDataGridView.GetCellDisplayRectangle(1, -1, true);
            h_chBox.Size = new Size(13, 13);

            // nastavim poziciu check boxu napevno
            h_chBox.Location = new Point(rect.Location.X + 3, rect.Location.Y + 3);

            // pridam event handler
            h_chBox.CheckedChanged += new EventHandler(h_chBox_CheckedChanged);

            // pridam check box do datagrid view
            this.udalostiDataGridView.Controls.Add(h_chBox);

            //---------------------------------------------------------------------
            // 3. Vytvorim binding source a pripojim k data source DataGridView
            //---------------------------------------------------------------------
            RefreshDataGrid<Udalost>(udalostiDataGridView, new UdalostBusiness());          
        }

        /// <summary>
        /// Event handler - zvolenie datumu
        /// Ked uzivatel zvoli datum v kalendari - prikazem refresh datagridu
        /// CellFormatting event sa postara aby sa pri zmenenom datume zafarbili udalosti inou farbou !!!
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // refresh data grid view
            udalostiDataGridView.Invalidate();
            udalostiDataGridView.Refresh();
        }

        /// <summary>
        /// Event handler - zmena zaskrtnutia checkboxu
        /// Oznacenie vsetkych checkboxov v data gride pre ucely mazania
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void h_chBox_CheckedChanged(object sender, EventArgs e)
        {
            ZaskrtniOdskrtniVsetkyCheckBoxy(udalostiDataGridView, (CheckBox) sender);
        }        

        /// <summary>
        /// Event handler - formatovanie bunky
        /// --------------------------------------------------------------------------------------------
        /// ----!!!!!! Formatovanie buniek data gridu !!!!!!--------------------------------------------
        /// --------------------------------------------------------------------------------------------
        /// zabezpecuje farebne odlisenie udalosti, farebne oznacenie priority
        /// event sa spusta vzdy pred vykreslenim bunky, urobil som to tak preto aby som mal kompletnu kontrolu nad formatovanim buniek
        /// (mozem dynamicky menit farbu pozadia bunky, farbu pozadia ked sa bunka oznaci (selected) atd...)
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void udalostiDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // ! defaultne nastavenie zafarbenia bunky dalej v kode mozem ovveride-nut defaultne nastavenie !
            this.udalostiDataGridView.DefaultCellStyle.BackColor = Color.White;
            this.udalostiDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            this.udalostiDataGridView.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            this.udalostiDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            
            // ovveride-y
            if (e.ColumnIndex == 0)
            {
                // pre stlpec 0 - stlpec na farebne odlisenie udalosti

                // ziskam oznaceny datum v kalendari
                DateTime selDate = this.monthCalendar1.SelectionRange.Start;

                // ziskam objekt Dto na ktory je naviazany riadok
                Udalost o = (Udalost)this.udalostiDataGridView.Rows[e.RowIndex].DataBoundItem;

                // 1. BackColor
                if (o.Cas.Date == selDate.Date)
                {
                    // farba dnesnej udalosti
                    e.CellStyle.BackColor = Color.LightBlue;
                }
                else if (o.Cas < selDate)
                {
                    // farba starej udalosti
                    e.CellStyle.BackColor = Color.LightCoral;
                }
                else
                {
                    // farba buducej udalosti
                    e.CellStyle.BackColor = Color.LightGreen;
                }

                // 2. SelectionBackColor
                e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
            }          
            else if (e.ColumnIndex == 4)
            {
                // pre stlpec 4 - stlpec ktory naznacuje ci ma udalost prioritu

                // ziskam objekt Dto na ktory je naviazany riadok
                Udalost o = (Udalost)this.udalostiDataGridView.Rows[e.RowIndex].DataBoundItem;
                
                if (o.Priorita)
                {
                    // 1. BackColor
                    e.CellStyle.BackColor = Color.Yellow;

                    // 2. SelectionBackColor
                    e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
                }                        
            }       
        }

        /// <summary>
        /// Event handler - vstup kurzora mysi do datagridview
        /// Ked kurzor vojde do data gridu - focus na data grid
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void udalostiDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.udalostiDataGridView.Focus();
        }

        /// <summary>
        /// Event handler - kliknutie na bunku
        /// Kliknutie na riadok - upravit Udalost (zobrazenie detailu udalosti)
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void udalostiDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ak nebolo kliknute na column header ani na stplec 0 a 1
            if (e.RowIndex != -1 && e.ColumnIndex != 0 && e.ColumnIndex != 1)
            {
                // ziskam objekt
                Udalost u = (Udalost)udalostiDataGridView.SelectedRows[0].DataBoundItem;

                UdalostOkno okno = new UdalostOkno(u.Id);

                // odznacim header check box ak bol zaskrtnuty
                if (((CheckBox)this.udalostiDataGridView.Controls["header_checkbox"]).Checked) 
                {
                    ((CheckBox)this.udalostiDataGridView.Controls["header_checkbox"]).Checked = false;
                }
                
                // otvorim detail
                okno.ShowDialog(this);
            }
        }
        
        /// <summary>
        /// Event handler - kliknutie na tlacitko
        /// Kliknutie na tlacitko zmazat udalost
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void zmazat_udalost_btn_Click(object sender, EventArgs e)
        {
            ZmazVybraneZaznamyVDataGride<Udalost>(udalostiDataGridView, new UdalostBusiness());

            // odznacim header check box
            ((CheckBox)this.udalostiDataGridView.Controls["header_checkbox"]).Checked = false;
        }

        /// <summary>
        /// Event handler - kliknutie na tlacitko
        /// Kliknutie na tlacitko vytvorit udalost
        /// </summary>
        /// <param name="sender">odosielatel event-u</param>
        /// <param name="e">event parameter</param>
        private void vytvorit_udalost_btn_Click(object sender, EventArgs e)
        {
            UdalostOkno okno = new UdalostOkno();

            // odznacim header check box ak bol zaskrtnuty
            if (((CheckBox)this.udalostiDataGridView.Controls["header_checkbox"]).Checked)
            {
                ((CheckBox)this.udalostiDataGridView.Controls["header_checkbox"]).Checked = false;
            }

            okno.ShowDialog(this);
        }            

        /* ****************************************************************************************** */
        /* ****************************************************************************************** */
        /* ****************************************************************************************** */

        /* ****************************************************************************************** */
        /* **** Spolocne metody pre DataGridy ******************************************************* */
        /* ****************************************************************************************** */

        /// <summary>
        /// Tato metoda refreshuje dany data grid (dotiahne data nanovo)
        /// </summary>
        /// <typeparam name="T">genericky typ</typeparam>
        /// <param name="dgv">objekt DataGridView</param>
        /// <param name="bo">spravny business objekt na pracu z DB</param>
        public void RefreshDataGrid<T>(DataGridView dgv, IBusiness<T> bo)
        {
            // dotiahnem si uzivatelove zaznamy z DB 
            List<T> dtoList = bo.ZiskajVsetkyZaznamyUzivatela(Username);

            // novy binding source
            BindingSource bs = new BindingSource();
            foreach (T dto in dtoList)
            {
                bs.Add(dto);
            }

            // pripojim novy binding source (DataGridView sa sam refreshne)
            dgv.DataSource = bs;
        }

        /// <summary>
        /// Oznaci zaznam (riadok) s danym id v danom datagride
        /// </summary>
        /// <param name="dgv">vybrany datagridview</param>
        /// <param name="id">id zaznamu</param>
        /// <returns>index riadku zaznamu v datagridview</returns>
        public int OznacZaznamSIdVDataGride(DataGridView dgv, long id)
        {
            // index riadku v datagride oznaceneho zaznamu
            int row_index = -1;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (((Udalost)row.DataBoundItem).Id == id)
                {
                    // oznac riadok
                    dgv.Rows[row.Index].Selected = true;

                    // zapametaj si index riadka v dgv
                    row_index = row.Index;

                    break;
                }
            }

            return row_index;
        }

        /// <summary>
        /// Scrolluje dany datagridview k zaznamu (riadku) s danym indexom
        /// </summary>
        /// <param name="dgv">vybrany datagridview</param>
        /// <param name="row_index">index riadku v datagride</param>
        public void ScrollujDataGridKZaznamu(DataGridView dgv, int row_index)
        {
            dgv.FirstDisplayedScrollingRowIndex = row_index;
        }

        /// <summary>
        /// Zmaze vybrane riadky z daneho datagridu
        /// </summary>
        /// <typeparam name="T">genericky typ Dto</typeparam>
        /// <param name="dgv">objekt DataGridView</param>
        /// <param name="bo">spravny business objekt na pracu z DB</param>
        private void ZmazVybraneZaznamyVDataGride<T>(DataGridView dgv, IBusiness<T> bo)
        {
            // ak je co mazat
            if ( ((BindingSource)dgv.DataSource).Count != 0 )
            {
                // -------------------------------------------------------------------------------------- 
                // 1. Mazaznie zaznamov v DB
                // -------------------------------------------------------------------------------------- 

                // prejdem vsetky riadky a pozriem check box ci je oznaceny ak ano zaznam z DB zmazem
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    DataGridViewCheckBoxCell chbCell = (DataGridViewCheckBoxCell)row.Cells[1];

                    // ak je v danom riadku oznaceny checkbox na mazanie
                    if (Convert.ToBoolean(chbCell.Value))
                    {
                        // ziskam objekt Udalost na ktory je riadok naviazany a vymazem zaznam z databazy
                        T o = (T)row.DataBoundItem;

                        // mazem zaznam v DB
                        bo.VymazZaznamZDB(o);
                    }
                }

                // -------------------------------------------------------------------------------------- 
                // 2. Updatujem datagrid a zabezpecim stav scroll baru (aby nevykocil na zaciatok)
                // -------------------------------------------------------------------------------------- 

                // ulozim si index riadku ktory je ako prvy viditelny v datagride (maintain state of scrollbar)
                int index = dgv.FirstDisplayedScrollingRowIndex;

                // refreshnem datagrid
                RefreshDataGrid<T>(dgv, bo);

                // musim skontrolovat ci este ten index existuje (mohli sme vymazat zaznamy a zaznam ktory bol ako prvy viditelny v scroll bare by uz nemusel byt)
                // kontrolujem ci pocet zaznamov >= poctu zaznamov ktore predstavuje index (ci mam dostatocny pocet zaznamov aby som mohol index dat ako prvy v scrollbare)
                // pozn. zaznamy v datagride (riadky) su cislovane od 0 
                if ( (((BindingSource)dgv.DataSource).Count - 1) >= index )
                {
                    // ak mam dost zaznamov v datagride
                    ScrollujDataGridKZaznamu(dgv, index);
                }
                else if ( ((BindingSource)dgv.DataSource).Count != 0 )
                {
                    // ak nieje 0 zaznamov
     
                    // ak nemam dost zaznamov v datagride bude ako prvy v scrollbare, ten kolko mam zaznamov (index posledneho zaznamu)
                    ScrollujDataGridKZaznamu(dgv, ((BindingSource)dgv.DataSource).Count - 1);                      
                }
            }
        }

        /// <summary>
        /// Pozrie sa hodnota header checkboxu v danom datagride a podla toho sa zaskrtnu alebo odskrtnu check boxy
        /// </summary>
        /// <param name="dgv">dany datagrid</param>
        /// <param name="headerCheckBox">objekt CheckBox - header check box datagridu</param>
        private void ZaskrtniOdskrtniVsetkyCheckBoxy(DataGridView dgv, CheckBox headerCheckBox)
        {
            if (((BindingSource)dgv.DataSource).Count != 0)
            {
                /* nastavenie oznaceneho riadka v datagride ako Readonly false 
                * bez tochto nastavenia sa stavalo ze sa oznacili/odznacili vsetky chack boxy 
                * okrem toho vo vyznacenom riadku */
                udalostiDataGridView.SelectedRows[0].ReadOnly = false;

                if (headerCheckBox.Checked)
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        ((DataGridViewCheckBoxCell)row.Cells[1]).Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        ((DataGridViewCheckBoxCell)row.Cells[1]).Value = false;
                    }
                }
            }
        }

        /* ****************************************************************************************** */
        /* ****************************************************************************************** */
        /* ****************************************************************************************** */
    }
}
