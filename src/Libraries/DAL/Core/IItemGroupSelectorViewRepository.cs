// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemGroupSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IItemGroupSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IItemGroupSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ItemGroupSelectorView" class from IItemGroupSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ItemGroupSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroupSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IItemGroupSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IItemGroupSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemGroupSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ItemGroupSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroupSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemGroupSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ItemGroupSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroupSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemGroupSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ItemGroupSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IItemGroupSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ItemGroupSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroupSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemGroupSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ItemGroupSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IItemGroupSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ItemGroupSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroupSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}