// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IVerifiedStockDetailsViewRepository
    {
        /// <summary>
        /// Performs count on IVerifiedStockDetailsViewRepository.
        /// </summary>
        /// <returns>Returns the number of IVerifiedStockDetailsViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "VerifiedStockDetailsView" class from IVerifiedStockDetailsViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "VerifiedStockDetailsView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.VerifiedStockDetailsView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IVerifiedStockDetailsViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IVerifiedStockDetailsViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IVerifiedStockDetailsViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "VerifiedStockDetailsView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.VerifiedStockDetailsView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IVerifiedStockDetailsViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "VerifiedStockDetailsView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.VerifiedStockDetailsView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IVerifiedStockDetailsViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "VerifiedStockDetailsView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IVerifiedStockDetailsViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "VerifiedStockDetailsView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.VerifiedStockDetailsView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IVerifiedStockDetailsViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "VerifiedStockDetailsView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IVerifiedStockDetailsViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "VerifiedStockDetailsView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.VerifiedStockDetailsView> GetFiltered(long pageNumber, string filterName);


    }
}