using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Edituje kontakt v DB
        /// </summary>
        /// <param name="dto">objekt dto</param>
        public void ZmenZaznamVDB(Kontakt dto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Vymaže kontakt v DB
        /// </summary>
        /// <param name="dto">objekt dto</param>
        public void VymazZaznamZDB(Kontakt dto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Vráti List všetkých kontaktov patriacich danému užívateľovi
        /// </summary>
        /// <param name="user">meno pouzivatela</param>
        /// <returns>Vracia zoznam kontaktov</returns>
        public List<Kontakt> ZiskajVsetkyZaznamyUzivatela(string user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Vráti konkrétny kontakt z DB podľa id
        /// </summary>
        /// <param name="id">Id záznamu</param>
        /// <returns>Kontakt z DB</returns>
        public Kontakt ZiskajZaznam(long id)
        {
            throw new NotImplementedException();
        }
    }
}
