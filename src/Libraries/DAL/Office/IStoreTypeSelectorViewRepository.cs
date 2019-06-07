// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IStoreTypeSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IStoreTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IStoreTypeSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "StoreTypeSelectorView" class from IStoreTypeSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "StoreTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreTypeSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IStoreTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IStoreTypeSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IStoreTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "StoreTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreTypeSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IStoreTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "StoreTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreTypeSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStoreTypeSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "StoreTypeSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IStoreTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "StoreTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreTypeSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStoreTypeSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "StoreTypeSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IStoreTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "StoreTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreTypeSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}