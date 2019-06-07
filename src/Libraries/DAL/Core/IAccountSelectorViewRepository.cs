// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "AccountSelectorView" class from IAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "AccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "AccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "AccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "AccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "AccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "AccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "AccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}