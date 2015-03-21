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
    public partial class KontaktOkno : Form
    {

        /// <summary>
        /// Dto objekt
        /// </summary>
        private Kontakt dto;

        private KontaktBusiness kb;
        
        public KontaktOkno()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
