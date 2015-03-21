// <copyright file="Program.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda Program
// </summary>
// <author>tnguyen</author>

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dao;
using Domain.Dto;

namespace Domain
{
    /// <summary>
    /// Trieda Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Tuto triedu som pouzival na skusky prece z DB
        /// </summary>
        /// <param name="args">parametre metody</param>
        public static void Main(string[] args)
        {
            // Write to console window.
            Console.WriteLine("hello");

            string connString = ConfigurationManager.ConnectionStrings["db_connection_string"].ConnectionString;
            string s = System.Environment.CurrentDirectory;

            try
            {
                /*
                using (SqlCeConnection con = new SqlCeConnection(connString))
                {
                    // otvorit spojenie s DB
                    con.Open();


                    // vytvor sql prikaz
                    string sql_query = "SELECT * FROM Kontakt";

                    using (SqlCeCommand command = new SqlCeCommand(sql_query, con))
                    {
                        // nahrad za parameter
                        //command.Parameters.Add(new SqlCeParameter("Id", id));

                        // zbehni sql prikaz
                        SqlCeDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetInt64(0));
                            Console.WriteLine(reader.GetString(1));
                        }
                    }

                }*/

                //---------------------------------------------
                //------ Udalost ------------------------------
                // SKUSKA INSERT
                /*
                UdalostDao ud = new UdalostDao();
                Udalost u = new Udalost("asus","názov udalosti", "treba kupit chleba", "v obchode", DateTime.Now, false);
                ud.Insert(u);*/

                // SKUSKA UPDATE
                /*UdalostDao ud = new UdalostDao();
                Udalost u = ud.Get(2);
                Console.WriteLine(u.ToString());

                u.User = "Asus 2";
                u.Miesto = "v Tescu";
                u.Nazov = "Nazov udalosti 2";
                u.Priorita = false;
                u.Cas = DateTime.Now;
                u.PopisUdalosti = "Iný popis udalosti";

                ud.Update(u);

                ud = new UdalostDao();
                u = ud.Get(2);
                Console.WriteLine(u.ToString());*/

                // SKUSKA DELETE
                /*UdalostDao ud = new UdalostDao();
                Udalost u = ud.Get(2);
                ud.Delete(u);*/

                //---------------------------------------------
                //---------------------------------------------

                //---------------------------------------------
                //------ Kontakt ------------------------------
                // SKUSKA INSERT                
                /*KontaktDao dao = new KontaktDao();
                Kontakt o = new Kontakt("asus5", "Tomáš", "Nguyen", "Generála asmolova 2006/84", "tomasu600@gmail.com", "0902689555");
                dao.Insert(o);*/

                // SKUSKA UPDATE
                /*KontaktDao dao = new KontaktDao();
                Kontakt o = dao.Get(12);
                Console.WriteLine(o.ToString());

                o.User = "Asus 2";
                o.Meno = "John";
                o.Priezvisko = "Long";
                o.Adresa = "ina adresa";
                o.Email = "mail@mail.ph";
                o.Telc = "0908555";

                dao.Update(o);
                
                o = dao.Get(12);
                Console.WriteLine(o.ToString());*/

                // SKUSKA DELETE
                /*KontaktDao dao = new KontaktDao();
                Kontakt o = dao.Get(12);
                dao.Delete(o);*/

                //---------------------------------------------
                //---------------------------------------------

                //---------------------------------------------
                //------ Poznamka -----------------------------
                // SKUSKA INSERT
                /*PoznamkaDao dao = new PoznamkaDao();
                Poznamka o = new Poznamka("asua", "Dlhý názov poznámky", "obsah poznámky");
                dao.Insert(o);*/

                // SKUSKA UPDATE
                /*PoznamkaDao dao = new PoznamkaDao();
                Poznamka o = dao.Get(2);
                Console.WriteLine(o.ToString());
                o.User = "iny user";
                o.Nazov = "iny nazov";
                o.Obsah = "iny obsah";
                dao.Update(o);*/

                // SKUSKA DELETE
                /*PoznamkaDao dao = new PoznamkaDao();
                Poznamka o = dao.Get(2);
                dao.Delete(o);*/

                //---------------------------------------------
                //---------------------------------------------
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadLine();
        }
    }
}
