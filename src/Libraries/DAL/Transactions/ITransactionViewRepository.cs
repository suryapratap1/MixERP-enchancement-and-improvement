// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface ITransactionViewRepository
    {
        /// <summary>
        /// Performs count on ITransactionViewRepository.
        /// </summary>
        /// <returns>Returns the number of ITransactionViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "TransactionView" class from ITransactionViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "TransactionView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ITransactionViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ITransactionViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ITransactionViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "TransactionView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ITransactionViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "TransactionView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITransactionViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "TransactionView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ITransactionViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "TransactionView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITransactionViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "TransactionView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ITransactionViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "TransactionView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionView> GetFiltered(long pageNumber, string filterName);


    }
}