// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemGroupScrudViewRepository
    {
        /// <summary>
        /// Performs count on IItemGroupScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IItemGroupScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ItemGroupScrudView" class from IItemGroupScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ItemGroupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroupScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IItemGroupScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IItemGroupScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemGroupScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ItemGroupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroupScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemGroupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ItemGroupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroupScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemGroupScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ItemGroupScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IItemGroupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ItemGroupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroupScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemGroupScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ItemGroupScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IItemGroupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ItemGroupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemGroupScrudView> GetFiltered(long pageNumber, string filterName);


    }
}