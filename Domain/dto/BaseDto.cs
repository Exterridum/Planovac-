// <copyright file="BaseDto.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda BaseDto
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
    /// Trieda BaseDto
    /// </summary>
    /// <typeparam name="T">typ Dto</typeparam>
    public abstract class BaseDto<T> : IBaseDto<T>
    {
        /// <summary>
        /// Konstruktor triedy
        /// </summary>
        public BaseDto() 
        {
            // treba oznacit properties, ktore sa nemaju zahrnut pri pouziti prikazu sql Insert a Update, v Dao
            this.Exluded_properties = new List<string>();
            this.Exluded_properties.Add("Primary_key");
            this.Exluded_properties.Add("Exluded_properties");
        }

        /// <summary>
        /// Nazov stlpca v DB ktory je primarnym klucom, treba zabezpecit aby v danom Dto bola premenna predstavujuca primarny kluc typu nullable
        /// </summary> 
        public string Primary_key { get; set; }

        /// <summary>
        /// Zoznam properties ktore sa nemaju zahrnut pri pouziti prikazu sql Insert a Update, v Dao
        /// </summary>
        public List<string> Exluded_properties { get; set; }

        /// <summary>
        /// Abstraktna metoda populate
        /// </summary>
        /// <param name="row">data z DB - jeden riadok</param>
        public abstract void PopulateDto(SqlCeDataReader row);

        /// <summary>
        /// Id zaznamu
        /// </summary>
        public long Id { get; set; }
    }
}
