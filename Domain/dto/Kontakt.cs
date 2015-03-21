// <copyright file="Kontakt.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda Kontakt
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
    /// Trieda Kontakt
    /// </summary>
    public class Kontakt : BaseDto<Kontakt>
    {
        /// <summary>
        /// Defaultny konstruktor triedy
        /// </summary>
        public Kontakt()
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
        /// <param name="meno">param. meno</param>
        /// <param name="priezvisko">param. priezvisko</param>
        /// <param name="adresa">param. adresa</param>
        /// <param name="email">param. email</param>
        /// <param name="telc">param. telefone cislo</param>     
        public Kontakt(string user, string meno, string priezvisko, string adresa, string email, string telc) : this()
        {
            this.User = user;
            this.Meno = meno;
            this.Priezvisko = priezvisko;
            this.Adresa = adresa;
            this.Email = email;
            this.Telc = telc;
        }

        /// <summary>
        /// Id zaznamu
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// User, ktoremu kontakt patri
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Meno osoby
        /// </summary>
        public string Meno { get; set; }

        /// <summary>
        /// Priezvisko osoby
        /// </summary>
        public string Priezvisko { get; set; }

        /// <summary>
        /// Adresa osoby
        /// </summary>
        public string Adresa { get; set; }

        /// <summary>
        /// Email osoby
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Tel.c. osoby
        /// </summary>
        public string Telc { get; set; }

        /// <summary>
        /// Naplna objekt Kontakt datami z DB
        /// </summary>
        /// <param name="row">data z DB</param>
        public override void PopulateDto(SqlCeDataReader row)
        {
            this.Id = row.GetInt64(0);
            this.User = row.GetString(1);
            this.Meno = row.GetString(2);
            this.Priezvisko = row.GetString(3);
            this.Adresa = row.GetString(4);
            this.Email = row.GetString(5);
            this.Telc = row.GetString(6);
        }

        /// <summary>
        /// Vypis vsetkych poloziek triedy
        /// </summary>
        /// <returns>String reprezentacia triedy Kontakt</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id   : " + this.Id);
            sb.AppendLine("User  : " + this.User);
            sb.AppendLine("Meno : " + this.Meno);
            sb.AppendLine("Priezvisko : " + this.Priezvisko);
            sb.AppendLine("Adresa : " + this.Adresa);
            sb.AppendLine("Email : " + this.Email);
            sb.AppendLine("Tel. c. : " + this.Telc);

            return sb.ToString();
        }
    }
}
