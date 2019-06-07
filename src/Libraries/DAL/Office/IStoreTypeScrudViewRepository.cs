// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IStoreTypeScrudViewRepository
    {
        /// <summary>
        /// Performs count on IStoreTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IStoreTypeScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "StoreTypeScrudView" class from IStoreTypeScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "StoreTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreTypeScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IStoreTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IStoreTypeScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IStoreTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "StoreTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreTypeScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IStoreTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "StoreTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreTypeScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStoreTypeScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "StoreTypeScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IStoreTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "StoreTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreTypeScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStoreTypeScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "StoreTypeScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IStoreTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "StoreTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreTypeScrudView> GetFiltered(long pageNumber, string filterName);


    }
}