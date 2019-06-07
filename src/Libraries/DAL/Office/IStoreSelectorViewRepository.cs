// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IStoreSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IStoreSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IStoreSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "StoreSelectorView" class from IStoreSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "StoreSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IStoreSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IStoreSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IStoreSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "StoreSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IStoreSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "StoreSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStoreSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "StoreSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IStoreSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "StoreSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStoreSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "StoreSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IStoreSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "StoreSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}