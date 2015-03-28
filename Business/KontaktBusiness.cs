using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dao;
using Domain.Dto;

namespace Business
{
    public class KontaktBusiness : IBusiness<Kontakt>
    {
        /// <summary>
        /// Dao objekt 
        /// </summary>
        private KontaktDao dao;

        /// <summary>
        /// Default konštruktor triedy
        /// </summary>
        public KontaktBusiness()
        {
            this.dao = new KontaktDao();
        }

        /// <summary>
        /// Zapíše kontakt do DB
        /// </summary>
        /// <param name="dto">objekt dto</param>
        /// <returns>id zaznamu</returns>
        public long ZapisZaznamDoDB(Kontakt dto)
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
        /// Edituje kontakt v DB
        /// </summary>
        /// <param name="dto">objekt dto</param>
        public void ZmenZaznamVDB(Kontakt dto)
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
        /// Vymaže kontakt v DB
        /// </summary>
        /// <param name="dto">objekt dto</param>
        public void VymazZaznamZDB(Kontakt dto)
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
        /// Vráti List všetkých kontaktov patriacich danému užívateľovi
        /// </summary>
        /// <param name="user">meno pouzivatela</param>
        /// <returns>Vracia zoznam kontaktov</returns>
        public List<Kontakt> ZiskajVsetkyZaznamyUzivatela(string user)
        {
            try
            {
                List<Kontakt> kontakty = this.dao.GetAll("WHERE [User] = @User ORDER BY [Priezvisko] ASC",
                    new List<SqlCeParameter> {new SqlCeParameter("@User", user)});
                return kontakty;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        /// <summary>
        /// Vráti konkrétny kontakt z DB podľa id
        /// </summary>
        /// <param name="id">Id záznamu</param>
        /// <returns>Kontakt z DB</returns>
        public Kontakt ZiskajZaznam(long id)
        {
            try
            {
                return this.dao.Get(id);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
