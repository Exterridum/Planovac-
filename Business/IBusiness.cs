// <copyright file="IBusiness.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda IBusiness
// </summary>
// <author>tnguyen</author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    /// <summary>
    /// Interface Business tried
    /// </summary>
    /// <typeparam name="T">typ Dto</typeparam>
    public interface IBusiness<T>
    {
        /// <summary>
        /// Implementovna metoda zapise zaznam do DB
        /// </summary>
        /// <param name="dto">typ dto</param>
        /// <returns>id zaznamu</returns>
        long ZapisZaznamDoDB(T dto);

        /// <summary>
        /// Implementovana metoda zmeni zaznam v DB
        /// </summary>
        /// <param name="dto">typ dto</param>
        void ZmenZaznamVDB(T dto);

        /// <summary>
        /// Implementovana metoda vymaze zaznam z DB
        /// </summary>
        /// <param name="dto">typ dto</param>
        void VymazZaznamZDB(T dto);

        /// <summary>
        /// Implementovana metoda ziska vsetky zaznamy daneho uzivatela
        /// </summary>
        /// <param name="user">mane pouzivatela</param>
        /// <returns>zoznam dto</returns>
        List<T> ZiskajVsetkyZaznamyUzivatela(string user);

        /// <summary>
        /// Implementovana metoda ziska zaznam podla daneho id
        /// </summary>
        /// <param name="id">id zaznamu</param>
        /// <returns>dto objekt</returns>
        T ZiskajZaznam(long id);
    }
}
