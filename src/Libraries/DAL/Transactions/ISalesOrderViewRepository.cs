// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface ISalesOrderViewRepository
    {
        /// <summary>
        /// Performs count on ISalesOrderViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesOrderViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesOrderView" class from ISalesOrderViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesOrderView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesOrderView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesOrderViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesOrderViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesOrderViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesOrderView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesOrderView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesOrderViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesOrderView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesOrderView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesOrderViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesOrderView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesOrderViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesOrderView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesOrderView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesOrderViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesOrderView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesOrderViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesOrderView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesOrderView> GetFiltered(long pageNumber, string filterName);


    }
}