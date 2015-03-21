// <copyright file="Poznamka.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda Poznamka
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
    /// Trieda Poznamka
    /// </summary>
    public class Poznamka : BaseDto<Poznamka>
    {
        /// <summary>
        /// Defaultny konstruktor triedy
        /// </summary>
        public Poznamka()
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
        /// <param name="obsah">param. obsah</param>
        public Poznamka(string user, string nazov, string obsah) : this()
        {
            this.User = user;         
            this.Nazov = nazov;
            this.Obsah = obsah;
        }

        /// <summary>
        /// Id zaznamu
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// User, ktoremu poznamka patri
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Nazov poznamky
        /// </summary>
        public string Nazov { get; set; }
        
        /// <summary>
        /// Obsah poznamky
        /// </summary>
        public string Obsah { get; set; }
         
        /// <summary>
        /// Naplna objekt Poznamka datami z DB
        /// </summary>
        /// <param name="row">data z DB - jeden riadok</param>
        public override void PopulateDto(SqlCeDataReader row) 
        {
            this.Id = row.GetInt64(0);
            this.User = row.GetString(1);
            this.Nazov = row.GetString(2);
            this.Obsah = row.GetString(3);
        }    

        /// <summary>
        /// Vypis vsetkych poloziek triedy
        /// </summary>
        /// <returns>String reprezentacia triedy Poznamka</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id   : " + this.Id);
            sb.AppendLine("User  : " + this.User);
            sb.AppendLine("Nazov : " + this.Nazov);
            sb.AppendLine("Obsah : " + this.Obsah);

            return sb.ToString();
        }
    }
}
