// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface ICashRepositorySelectorViewRepository
    {
        /// <summary>
        /// Performs count on ICashRepositorySelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICashRepositorySelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CashRepositorySelectorView" class from ICashRepositorySelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CashRepositorySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepositorySelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICashRepositorySelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICashRepositorySelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICashRepositorySelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CashRepositorySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepositorySelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICashRepositorySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CashRepositorySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepositorySelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICashRepositorySelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CashRepositorySelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICashRepositorySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CashRepositorySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepositorySelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICashRepositorySelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CashRepositorySelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICashRepositorySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CashRepositorySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepositorySelectorView> GetFiltered(long pageNumber, string filterName);


    }
}