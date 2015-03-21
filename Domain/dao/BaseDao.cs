// <copyright file="BaseDao.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Trieda BaseDao
// </summary>
// <author>tnguyen</author>

namespace Domain.Dao
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Data.SqlServerCe;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using Domain.Dto;

    /// <summary>
    /// Trieda BaseDao
    /// </summary>
    /// <typeparam name="T">typ Dto s ktorym Dao pracuje</typeparam>
    public class BaseDao<T> : IBaseDao<T> where T : BaseDto<T>
    {
        /// <summary>
        /// Connection string na pripojenie k databaze
        /// </summary>
        private string connString;

        /// <summary>
        /// Typ DTO s ktorym Dao pracuje
        /// </summary>
        private Type dtoType;

        /// <summary>
        /// Konstruktor triedy BaseDao
        /// </summary>
        public BaseDao()
        {
            // connection string berem s App.config kde som ho zapisal
            this.connString = ConfigurationManager.ConnectionStrings["db_connection_string"].ConnectionString;
            this.dtoType = typeof(T);
        }

        /// <summary>
        /// Property pre premennu connString (vyuziva sa pri testovani Dao)
        /// </summary>
        public string ConnString
        {
            get { return this.connString; }
            set { this.connString = value; }
        }

        /// <summary>
        /// Implementovana metoda ktora vrati zaznam z DB podla id
        /// </summary>
        /// <param name="id">id zaznamu</param>
        /// <returns>Dto objekt ak zaznam najde alebo null ak taky zaznam neexistuje</returns>
        public T Get(long id)
        {
            try
            {
                using (SqlCeConnection con = new SqlCeConnection(this.connString))
                {
                    // otvorit spojenie s DB
                    con.Open();

                    // vytvor prazdne Dto (len pre ucely pristupu k property Primary_key)
                    T obj = (T)Activator.CreateInstance(this.dtoType);

                    // zisti nazov sltpca, ktory je primarny kluc
                    string stlpec_prim_k = obj.Primary_key;

                    // vytvor sql prikaz
                    string sql_query = "SELECT * FROM " + this.dtoType.Name + " WHERE " + stlpec_prim_k + " = @Id";

                    // vynulujem
                    T dto = null;
                    using (SqlCeCommand command = new SqlCeCommand(sql_query, con))
                    {
                        // nahrad za parameter
                        command.Parameters.Add(new SqlCeParameter("Id", id));

                        // zbehni sql prikaz
                        SqlCeDataReader reader = command.ExecuteReader();
                       
                        while (reader.Read())
                        {
                            // vytvor prazdne Dto
                            dto = (T)Activator.CreateInstance(this.dtoType);

                            // napln Dto objekt
                            dto.PopulateDto(reader);
                        }               
                    }

                    // vratim Dto objekt
                    return dto;                   
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
        }

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
        public List<T> GetAll(string where_orderBy, List<SqlCeParameter> sql_params)
        {
            try
            {
                // vytvor prazdny zoznam
                List<T> zoznam = new List<T>();

                using (SqlCeConnection con = new SqlCeConnection(this.connString))
                {
                    // otvorit spojenie s DB
                    con.Open();

                    // vytvor prazdne Dto (len pre ucely pristupu k property Primary_key)
                    T obj = (T)Activator.CreateInstance(this.dtoType);

                    // zisti nazov sltpca, ktory je primarny kluc
                    string stlpec_prim_k = obj.Primary_key;

                    // vytvor sql prikaz
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM " + this.dtoType.Name);

                    // ak je pridana WHERE podmienka tak urob
                    if (!string.IsNullOrEmpty(where_orderBy))
                    {
                        sb.Append(" " + where_orderBy);
                    }                

                    string sql_query = sb.ToString();

                    using (SqlCeCommand command = new SqlCeCommand(sql_query, con))
                    {
                        // ak su dake sql parametre tak ich pridaj do prikazu
                        if (sql_params != null)
                        {
                            // nastavim parametre
                            command.Parameters.AddRange(sql_params.ToArray());
                        }

                        // zbehni sql prikaz
                        SqlCeDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {                                                     
                            // vytvor prazdne Dto
                            T dto = (T)Activator.CreateInstance(this.dtoType);

                            // napln Dto objekt
                            dto.PopulateDto(reader);

                            // pridaj Dto do zoznamu
                            zoznam.Add(dto);
                        }
                    }

                    // vratim zoznam Dto objektov
                    return zoznam;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
        }  

        /// <summary>
        /// Implementovana metoda ktora zapise objekt do DB ako zaznam
        /// </summary>
        /// <param name="obj">Dto objekt</param>
        /// <returns>id zaznamu</returns>
        public long Insert(T obj)
        {
            try
            {
                // v tejto premennej bude vygenerovane id vlozeneho zaznamu
                long id;

                using (SqlCeConnection con = new SqlCeConnection(this.connString))
                {
                    // otvorit spojenie s DB
                    con.Open();

                    // zisti nazov sltpca, ktory je primarny kluc
                    string stlpec_prim_k = obj.Primary_key;

                    // vytvor sql prikaz
                    // bude obsahovat cast Insert prikazu : INSERT INTO table_name (column1,column2,column3,...) VALUES 
                    StringBuilder sb1 = new StringBuilder();

                    // bude obsahovat cast Insert prikazu : (@column1,@column2,@column3,...)
                    StringBuilder sb2 = new StringBuilder();

                    // INSERT INTO table_name
                    sb1.Append("INSERT INTO " + this.dtoType.Name + " (");
                    sb2.Append("(");

                    // ziskam vsetky properties s Dto
                    PropertyInfo[] properties = this.dtoType.GetProperties();

                    // ziskam properties ktore sa maju vylucit s sql insert prikazu
                    List<string> excluded_properties = obj.Exluded_properties;

                    PropertyInfo pi;
                    int i = 0;
                    List<SqlCeParameter> param_list = new List<SqlCeParameter>();

                    // pridavam meno stlpca v tabulke a za tym ciarku, ([column1],[column2],[column3],...) a zaroven robim aj (@column1,@column2,@column3,...) a zaroven pridavam hodnoty parametrov do SqlCeParameterCollection
                    while (i < properties.Length)
                    {
                        pi = properties[i];

                        // ak sa property nenachadza vo vylucenych properties tak urob
                        if (!excluded_properties.Contains(pi.Name))
                        {
                            string property_name = pi.Name;
                            var property_value = pi.GetValue(obj);

                            // robi [column1], ...
                            sb1.Append("[" + property_name + "]" + ",");

                            // robi @column1, ...
                            sb2.Append("@" + property_name + ",");

                            // pridavam objekt SqlCeParameter
                            param_list.Add(new SqlCeParameter("@" + property_name, (object)property_value));
                        }

                        i++;
                    }
                   
                    // odstranim poslednu ciarku tu netreba
                    sb1.Remove(sb1.Length - 1, 1);
                    sb2.Remove(sb2.Length - 1, 1);

                    // pridam koniec zatvorky
                    sb1.Append(") VALUES ");
                    sb2.Append(")");
                 
                    // spojim oba stringy (ktory zisti vygenerovane Id) ziskam tak cely sql prikaz
                    string sql_query = sb1.ToString() + sb2.ToString();
                    
                    using (SqlCeCommand command = new SqlCeCommand(sql_query, con))
                    {
                        // nastavim parametre pre sql prikaz
                        command.Parameters.AddRange(param_list.ToArray());

                        // zbehni sql prikaz
                        command.ExecuteNonQuery();
                    }

                    // ziskaj posledne vygenerovane id
                    using (SqlCeCommand command = new SqlCeCommand("SELECT @@IDENTITY", con))
                    {       
                        // zbehni sql prikaz
                        object result = command.ExecuteScalar();

                        // ziskaj posledne vygenerovane id      
                        id = Int64.Parse(result.ToString());
                    }

                    // vraciam vygenerovane id zaznamu
                    return id;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
        }

        /// <summary>
        /// Implementovana metoda updatuje dany zaznam v DB
        /// </summary>
        /// <param name="obj">Dto objekt</param>
        public void Update(T obj)
        {
            try
            { 
                using (SqlCeConnection con = new SqlCeConnection(this.connString))
                {
                    // otvorit spojenie s DB
                    con.Open();
                    
                    // zisti nazov sltpca, ktory je primarny kluc
                    string stlpec_prim_k = obj.Primary_key;

                    // vytvor sql prikaz

                    // bude obsahovat update prikaz : UPDATE table_name SET column1=@column1,column2=@column2,... WHERE some_column=some_value  
                    StringBuilder sb = new StringBuilder();
       
                    // INSERT INTO table_name
                    sb.Append("UPDATE " + this.dtoType.Name + " SET ");

                    // ziskam vsetky properties s Dto
                    PropertyInfo[] properties = this.dtoType.GetProperties();

                    // ziskam properties ktore sa maju vylucit s sql update prikazu
                    List<string> excluded_properties = obj.Exluded_properties;

                    PropertyInfo pi;
                    int i = 0;
                    List<SqlCeParameter> param_list = new List<SqlCeParameter>();

                    // robi, column1=@column1,column2=@column2,...
                    while (i < properties.Length)
                    {
                        pi = properties[i];

                        // ak sa property nenachadza vo vylucenych properties tak urob
                        if (!excluded_properties.Contains(pi.Name))
                        {
                            string property_name = pi.Name;
                            var property_value = pi.GetValue(obj);
                            sb.Append("[" + property_name + "]" + "=" + "@" + property_name + ",");

                            // pridavam objekt SqlCeParameter
                            param_list.Add(new SqlCeParameter("@" + property_name, (object)property_value));
                        }

                        i++;
                    }

                    // odstranim poslednu ciarku tu netreba
                    sb.Remove(sb.Length - 1, 1);

                    // zistim hodnotu premennej predstavujucu primarny kluc
                    pi = this.dtoType.GetProperty(stlpec_prim_k);
                    var obj_prim_k_value = pi.GetValue(obj);

                    // pridam na koniec WHERE cast
                    sb.Append(" WHERE " + stlpec_prim_k + "=" + "@" + stlpec_prim_k);
                    param_list.Add(new SqlCeParameter("@" + stlpec_prim_k, (object)obj_prim_k_value));

                    // ziskam tak cely sql prikaz
                    string sql_query = sb.ToString();

                    using (SqlCeCommand command = new SqlCeCommand(sql_query, con))
                    {
                        // nastavim parametre pre sql prikaz
                        command.Parameters.AddRange(param_list.ToArray());

                        // zbehni sql prikaz
                        command.ExecuteNonQuery();
                    }                                 
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
        }    

        /// <summary>
        /// Implementovana metoda vymaze zaznam z DB
        /// </summary>
        /// <param name="obj">Dto objekt</param>
        public void Delete(T obj)
        {         
            try
            {
                using (SqlCeConnection con = new SqlCeConnection(this.connString))
                {
                    // otvorit spojenie s DB
                    con.Open();
                    
                    // zisti nazov sltpca, ktory je primarny kluc
                    string stlpec_prim_k = obj.Primary_key;

                    // zisti hodnotu premennej v dto objekte, ktora predstavuje primarny kluc
                    PropertyInfo pi = this.dtoType.GetProperty(stlpec_prim_k);
                    var hodn_prim_k_obj = pi.GetValue(obj);

                    // vytvor sql prikaz
                    string sql_query = "DELETE FROM " + this.dtoType.Name + " WHERE " + stlpec_prim_k + " = @Id";
                    using (SqlCeCommand command = new SqlCeCommand(sql_query, con))
                    {
                        // nahrad za parameter
                        command.Parameters.Add(new SqlCeParameter("Id", hodn_prim_k_obj));

                        // zbehni sql prikaz
                        command.ExecuteNonQuery();             
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                throw;
            }
        }
    }
}
