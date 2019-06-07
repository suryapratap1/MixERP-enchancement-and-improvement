// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IInventoryAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IInventoryAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IInventoryAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "InventoryAccountSelectorView" class from IInventoryAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "InventoryAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.InventoryAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IInventoryAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IInventoryAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IInventoryAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "InventoryAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.InventoryAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IInventoryAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "InventoryAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.InventoryAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IInventoryAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "InventoryAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IInventoryAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "InventoryAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.InventoryAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IInventoryAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "InventoryAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IInventoryAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "InventoryAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.InventoryAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}