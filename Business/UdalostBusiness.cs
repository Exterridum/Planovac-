// <copyright file="UdalostBusiness.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda UdalostBusiness
// </summary>
// <author>tnguyen</author>

using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dao;
using Domain.Dto;

namespace Business
{
    /// <summary>
    /// Business trieda
    /// </summary>
    public class UdalostBusiness : IBusiness<Udalost>
    {
        /// <summary>
        /// Dao na pracu z DB
        /// </summary>
        private UdalostDao dao;

        /// <summary>
        /// Defaultny konstruktor
        /// </summary>
        public UdalostBusiness() 
        {
            this.dao = new UdalostDao();
        }

        /// <summary>
        /// Metoda zapise zaznam do DB
        /// </summary>
        /// <param name="dto">objekt dto</param>
        /// <returns>id zaznamu</returns>
        public long ZapisZaznamDoDB(Udalost dto)
        {
            try
            {
                long id = this.dao.Insert(dto);

                return id;
            }
            catch (Exception)
            {
                throw;
            }  
        }

        /// <summary>
        /// Metoda zmeni zaznam v DB
        /// </summary>
        /// <param name="dto">objekt dto</param>
        public void ZmenZaznamVDB(Udalost dto)
        {
            try
            {
                this.dao.Update(dto);
            }
            catch (Exception)
            {
                throw;
            }   
        }

        /// <summary>
        /// Metoda vymaze zaznam z DB
        /// </summary>
        /// <param name="dto">objekt dto</param>
        public void VymazZaznamZDB(Udalost dto)
        {
            try
            {
                this.dao.Delete(dto);
            }
            catch (Exception)
            {
                throw;
            }    
        }

        /// <summary>
        /// Metoda ziska vsetky zaznamy daneho uzivatela
        /// </summary>
        /// <param name="user">meno pouzivatela</param>
        /// <returns>zoznam objektov dto</returns>
        public List<Udalost> ZiskajVsetkyZaznamyUzivatela(string user)
        {
            try
            {
                List<Udalost> zoznam = this.dao.GetAll( "WHERE [User] = @User ORDER BY [Cas] ASC", new List<SqlCeParameter>{ new SqlCeParameter("@User", user) } );
                
                return zoznam;
            }
            catch (Exception)
            {
                throw;
            }           
        }

        /// <summary>
        /// Metoda ziska zaznam podla daneho id
        /// </summary>
        /// <param name="id">id zaznamu</param>
        /// <returns>objekt dto</returns>
        public Udalost ZiskajZaznam(long id)
        {
            try
            {
                Udalost u = this.dao.Get(id);
                
                return u;
            }
            catch (Exception)
            {
                throw;
            }  
        }
    }
}
