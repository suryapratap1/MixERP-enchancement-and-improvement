// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ILateFeeAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ILateFeeAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ILateFeeAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "LateFeeAccountSelectorView" class from ILateFeeAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "LateFeeAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFeeAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ILateFeeAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ILateFeeAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ILateFeeAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "LateFeeAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFeeAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ILateFeeAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "LateFeeAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFeeAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILateFeeAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "LateFeeAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ILateFeeAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "LateFeeAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFeeAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILateFeeAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "LateFeeAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ILateFeeAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "LateFeeAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFeeAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}