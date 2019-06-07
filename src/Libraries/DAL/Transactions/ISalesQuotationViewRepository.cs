// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface ISalesQuotationViewRepository
    {
        /// <summary>
        /// Performs count on ISalesQuotationViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesQuotationViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesQuotationView" class from ISalesQuotationViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesQuotationView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesQuotationView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesQuotationViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesQuotationViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesQuotationViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesQuotationView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesQuotationView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesQuotationViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesQuotationView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesQuotationView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesQuotationViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesQuotationView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesQuotationViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesQuotationView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesQuotationView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesQuotationViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesQuotationView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesQuotationViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesQuotationView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.SalesQuotationView> GetFiltered(long pageNumber, string filterName);


    }
}