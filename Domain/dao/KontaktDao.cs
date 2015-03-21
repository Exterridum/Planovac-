// <copyright file="KontaktDao.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda KontaktDao
// </summary>
// <author>tnguyen</author>

namespace Domain.Dao
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Domain.Dto;

    /// <summary>
    /// Trieda KontaktDao
    /// </summary>
    public class KontaktDao : BaseDao<Kontakt>
    {
        /*
        /// <summary>
        /// Metoda vrati zaznam z DB podla zadanej hodnoty v stlpci Meno a Priezvisko pre prihlaseneho pouzivatela (user)
        /// </summary>
        /// <param name="meno">string meno</param>
        /// <param name="priezvisko">string priezvisko</param> 
        /// <param name="user">string user</param>
        /// <returns>Dto objekt ak zaznam najde alebo null ak taky zaznam neexistuje</returns>
        public Kontakt GetByMenoPriezvisko(string meno, string priezvisko, string user)
        {
            try
            {
                List<Kontakt> zoznam;
                Kontakt result = null;

                zoznam = this.GetAll(
                    "WHERE Meno = @Meno AND Priezvisko = @Priezvisko AND [User] = @User", 
                    new List<SqlParameter> { new SqlParameter("@Meno", meno), new SqlParameter("@Priezvisko", priezvisko), new SqlParameter("@User", user) });
                
                // ak naslo zaznam
                if (zoznam.Count != 0)
                {
                    result = zoznam[0];
                }

                return result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.StackTrace);
                throw;
            }
        }     */   
    }
}
