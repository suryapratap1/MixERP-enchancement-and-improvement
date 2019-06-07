// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemScrudViewRepository
    {
        /// <summary>
        /// Performs count on IItemScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IItemScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ItemScrudView" class from IItemScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ItemScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IItemScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IItemScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ItemScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ItemScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ItemScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IItemScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ItemScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ItemScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IItemScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ItemScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemScrudView> GetFiltered(long pageNumber, string filterName);


    }
}