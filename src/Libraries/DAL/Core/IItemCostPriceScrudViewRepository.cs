// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemCostPriceScrudViewRepository
    {
        /// <summary>
        /// Performs count on IItemCostPriceScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IItemCostPriceScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ItemCostPriceScrudView" class from IItemCostPriceScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ItemCostPriceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemCostPriceScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IItemCostPriceScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IItemCostPriceScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemCostPriceScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ItemCostPriceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemCostPriceScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemCostPriceScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ItemCostPriceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemCostPriceScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemCostPriceScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ItemCostPriceScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IItemCostPriceScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ItemCostPriceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemCostPriceScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemCostPriceScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ItemCostPriceScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IItemCostPriceScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ItemCostPriceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemCostPriceScrudView> GetFiltered(long pageNumber, string filterName);


    }
}