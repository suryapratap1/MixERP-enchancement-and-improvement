// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IReceiptViewRepository
    {
        /// <summary>
        /// Performs count on IReceiptViewRepository.
        /// </summary>
        /// <returns>Returns the number of IReceiptViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ReceiptView" class from IReceiptViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ReceiptView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.ReceiptView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IReceiptViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IReceiptViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IReceiptViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ReceiptView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.ReceiptView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IReceiptViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ReceiptView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.ReceiptView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IReceiptViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ReceiptView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IReceiptViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ReceiptView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.ReceiptView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IReceiptViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ReceiptView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IReceiptViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ReceiptView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.ReceiptView> GetFiltered(long pageNumber, string filterName);


    }
}