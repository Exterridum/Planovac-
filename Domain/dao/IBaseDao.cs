// <copyright file="IBaseDao.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Rozhranie IBaseDao
// </summary>
// <author>tnguyen</author>

namespace Domain.Dao
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data.SqlServerCe;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Rozhranie IBaseDao musi ho implementovat kazde Dao
    /// </summary>
    /// <typeparam name="T">typ Dto</typeparam>
    public interface IBaseDao<T>
    {
        /// <summary>
        /// Metoda ktora vrati zaznam z DB podla id
        /// </summary>
        /// <param name="id">id zaznamu</param>
        /// <returns>Dto objekt ak zaznam najde alebo null ak taky zaznam neexistuje</returns>
        T Get(long id);

        /// <summary>
        /// Implementovana metoda ktora vrati vsetky zaznamy v prislusnej tabulke ktore splnaju WHERE cast a su zoradene podla ORDER BY daneho stlpca/stlpcov vzostupne/zostupne. 
        /// <para></para>
        /// Priklad volania 1 : List|Pripomienka| dao = dao.GetAll("", null) , ziska vsetky zaznamy
        /// <para></para>
        /// Priklad volania 2 : List|Pripomienka| dao = dao.GetAll("WHERE [User] = @User", new List|SqlCeParameter|{ new SqlCeParameter("@User", "Asus3") });                                         
        /// <para></para>
        /// Priklad volania 3 : List|Pripomienka| dao = dao.GetAll("WHERE [User] = @User ORDER BY Nazov DESC", new List|SqlCeParameter|{ new SqlCeParameter("@User", "Asus3") });                                  
        /// <para></para>
        /// Priklad volania 4 : List|Pripomienka| dao = dao.GetAll("WHERE [User] = @User AND Miesto = @Miesto ORDER BY Nazov DESC", new List|SqlCeParameter|{ new SqlCeParameter("@User", "Asus3"), new SqlCeParameter("@Miesto", "Mesiac") });               
        /// <para></para>
        /// pod zatvorkou | sa mysli ostra zatvorka
        /// </summary>
        /// <param name="where_orderBy">
        /// string v ktorom je WHERE .. ORDER BY cast sql prikazu s parametrami
        /// Priklad : "WHERE [User] = @User AND Miesto = @Miesto ORDER BY Nazov DESC"
        /// </param>
        /// <param name="sql_params">
        /// Zoznam sql parametrov do sql prikazu
        /// Priklad : new List|SqlCeParameter| { new SqlCeParameter("@User", "Asus3"), new SqlCeParameter("@Miesto", "Mesiac") }
        /// </param>
        /// <returns>zoznam Dto objektov alebo prazdny zoznam Dto objektov ak niesu ziadne zaznamy</returns>
        List<T> GetAll(string where_orderBy, List<SqlCeParameter> sql_params);

        /// <summary>
        /// Metoda ktora zapise objekt do DB ako zaznam
        /// </summary>
        /// <param name="obj">Dto objekt</param>
        /// <returns>id noveho zaznamu</returns>
        long Insert(T obj);

        /// <summary>
        /// Metoda updatuje dany zaznam v DB
        /// </summary>
        /// <param name="obj">Dto objekt</param>
        void Update(T obj);

        /// <summary>
        /// Metoda vymaze zaznam z DB
        /// </summary>
        /// <param name="obj">Dto objekt</param>
        void Delete(T obj);   
    }
}
