// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemViewRepository
    {
        /// <summary>
        /// Performs count on IItemViewRepository.
        /// </summary>
        /// <returns>Returns the number of IItemViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ItemView" class from IItemViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ItemView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IItemViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IItemViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ItemView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IItemViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ItemView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ItemView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IItemViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ItemView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ItemView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IItemViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ItemView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemView> GetFiltered(long pageNumber, string filterName);


    }
}