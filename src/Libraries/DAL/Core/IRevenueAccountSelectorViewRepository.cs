// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IRevenueAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IRevenueAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IRevenueAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "RevenueAccountSelectorView" class from IRevenueAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "RevenueAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RevenueAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IRevenueAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IRevenueAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IRevenueAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "RevenueAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RevenueAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IRevenueAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "RevenueAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RevenueAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRevenueAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "RevenueAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IRevenueAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "RevenueAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RevenueAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRevenueAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "RevenueAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IRevenueAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "RevenueAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RevenueAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}