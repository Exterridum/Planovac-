// <copyright file="Udalost.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda Udalost
// </summary>
// <author>tnguyen</author>

namespace Domain.Dto
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data.SqlServerCe;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Trieda Udalost
    /// </summary>
    public class Udalost : BaseDto<Udalost>
    {
        /// <summary>
        /// Defaultny konstruktor triedy
        /// </summary>
        public Udalost() 
        {
            // Treba povedat ktory stlpec tabulky je primarny kluc
            this.Primary_key = "Id";

            // Pridam do zoznamu na vylucenie z Insert a Update prikazu v Dao
            this.Exluded_properties.Add("Id");
        }

        /// <summary>
        /// Konstruktor triedy
        /// </summary>
        /// <param name="user">param. pouzivatel</param>
        /// <param name="nazov">param. nazov</param>
        /// <param name="popisUdalosti">param. popis udalosti</param>
        /// <param name="miesto">param. miesto</param>
        /// <param name="cas">param. cas</param>
        /// <param name="priorita">param. priorita</param>
        public Udalost(string user, string nazov, string popisUdalosti, string miesto, DateTime cas, bool priorita) : this()
        {
            this.User = user;
            this.Nazov = nazov;
            this.PopisUdalosti = popisUdalosti;
            this.Miesto = miesto;
            this.Cas = cas;
            this.Priorita = priorita;
        }

        /// <summary>
        /// Id zaznamu
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Pouzivatel, ktoremu udalost patri
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Nazov udalosti
        /// </summary>
        public string Nazov { get; set; }
        
        /// <summary>
        /// Popis udalosti
        /// </summary>
        public string PopisUdalosti { get; set; }

        /// <summary>
        /// Miesto zadane v udalosti
        /// </summary>
        public string Miesto { get; set; }

        /// <summary>
        /// Cas zadany v udalosti
        /// </summary>
        public DateTime Cas { get; set; }

        /// <summary>
        /// Priorita zadana v udalosti
        /// </summary>
        public bool Priorita { get; set; }

        /// <summary>
        /// Naplna objekt Udalost datami z DB
        /// </summary>
        /// <param name="row">data z DB</param>
        public override void PopulateDto(SqlCeDataReader row)
        {
            this.Id = row.GetInt64(0);
            this.User = row.GetString(1);
            this.Nazov = row.GetString(2);
            this.PopisUdalosti = row.GetString(3);
            this.Miesto = row.GetString(4);
            this.Cas = row.GetDateTime(5);
            this.Priorita = row.GetBoolean(6);
        }

        /// <summary>
        /// Vypis vsetkych poloziek triedy
        /// </summary>
        /// <returns>String reprezentacia triedy Udalost</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id   : " + this.Id);
            sb.AppendLine("User    : " + this.User);
            sb.AppendLine("Nazov   : " + this.Nazov);
            sb.AppendLine("Popis udalosti : " + this.PopisUdalosti);
            sb.AppendLine("Miesto  : " + this.Miesto);
            sb.AppendLine("Cas     : " + this.Cas.ToString());
            sb.AppendLine("Priorita     : " + this.Priorita.ToString());

            return sb.ToString();
        }
    }
}
