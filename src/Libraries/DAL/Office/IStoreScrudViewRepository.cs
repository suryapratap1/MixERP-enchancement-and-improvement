// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IStoreScrudViewRepository
    {
        /// <summary>
        /// Performs count on IStoreScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IStoreScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "StoreScrudView" class from IStoreScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "StoreScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IStoreScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IStoreScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IStoreScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "StoreScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IStoreScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "StoreScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStoreScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "StoreScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IStoreScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "StoreScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStoreScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "StoreScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IStoreScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "StoreScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreScrudView> GetFiltered(long pageNumber, string filterName);


    }
}