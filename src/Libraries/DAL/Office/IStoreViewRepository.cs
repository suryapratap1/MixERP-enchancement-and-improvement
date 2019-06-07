// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IStoreViewRepository
    {
        /// <summary>
        /// Performs count on IStoreViewRepository.
        /// </summary>
        /// <returns>Returns the number of IStoreViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "StoreView" class from IStoreViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "StoreView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IStoreViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IStoreViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IStoreViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "StoreView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IStoreViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "StoreView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStoreViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "StoreView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IStoreViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "StoreView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStoreViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "StoreView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IStoreViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "StoreView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreView> GetFiltered(long pageNumber, string filterName);


    }
}