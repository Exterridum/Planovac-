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
    public class PoznamkyBussines : IBusiness<Poznamka>
    {
        /// <summary>
        /// Dao objekt
        /// </summary>
        private PoznamkaDao dao;

        /// <summary>
        /// Default konštruktor triedy
        /// </summary>
        public PoznamkyBussines()
        {
            this.dao = new PoznamkaDao();
        }

        /// <summary>
        /// Zapíše kontakt do DB
        /// </summary>
        /// <param name="dto">objekt dto</param>
        /// <returns>id zaznamu</returns>
        public long ZapisZaznamDoDB(Poznamka dto)
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
        public void ZmenZaznamVDB(Poznamka dto)
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
        public void VymazZaznamZDB(Poznamka dto)
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
        public List<Poznamka> ZiskajVsetkyZaznamyUzivatela(string user)
        {//TODO
            try
            {
                List<Poznamka> poznamky = this.dao.GetAll("WHERE [User] = @User ORDER BY [Nazov] ASC",
                   new List<SqlCeParameter> {new SqlCeParameter("@User", user)});
                return poznamky;
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
        public Poznamka ZiskajZaznam(long id)
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
