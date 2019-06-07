// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IItemSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IItemSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ItemSelectorView" class from IItemSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ItemSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IItemSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IItemSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ItemSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ItemSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ItemSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IItemSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ItemSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ItemSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IItemSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ItemSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}