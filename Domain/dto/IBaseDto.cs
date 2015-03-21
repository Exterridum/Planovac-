// <copyright file="IBaseDto.cs" company="umb.sk">
//    All lefts reserved.
// </copyright>
// <summary>
//     Rozhranie IBaseDto
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
    /// Rozhranie IBaseDto musi ho implementovat kazde Dto
    /// </summary>
    /// <typeparam name="T">typ Dto</typeparam>
    public interface IBaseDto<T>
    {
        /// <summary>
        /// Tato metoda naplna objekt Dto datami z DB
        /// </summary>
        /// <param name="row">data z DB - jeden riadok</param>
        void PopulateDto(SqlCeDataReader row);
    }
}
