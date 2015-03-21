// <copyright file="Program.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda Program
// </summary>
// <author>tnguyen</author>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gui.Properties;

namespace Gui
{
    /// <summary>
    /// Trieda spusta Gui
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new HlavneOkno());
            }
            catch (Exception ex)
            {
                /* ------------------------------------------------------- */
                /* !!! Tu je posledny zachytny bod Vynimiek (Exception) !!!*/
                /* ------------------------------------------------------- */

                // vypis do Output okna
                Debug.WriteLine(ex.ToString());

                // message box zo spravou
                MessageBox.Show(Resources.NastChyba + " : " + ex.Message, Resources.Chyba, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }      
        }
    }
}
