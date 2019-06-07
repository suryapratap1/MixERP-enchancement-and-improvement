// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Localization.Data
{
    public interface ILocalizedResourceViewRepository
    {
        /// <summary>
        /// Performs count on ILocalizedResourceViewRepository.
        /// </summary>
        /// <returns>Returns the number of ILocalizedResourceViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "LocalizedResourceView" class from ILocalizedResourceViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "LocalizedResourceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.LocalizedResourceView> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from ILocalizedResourceViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "LocalizedResourceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.LocalizedResourceView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ILocalizedResourceViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "LocalizedResourceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.LocalizedResourceView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILocalizedResourceViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "LocalizedResourceView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ILocalizedResourceViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "LocalizedResourceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.LocalizedResourceView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILocalizedResourceViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "LocalizedResourceView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ILocalizedResourceViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "LocalizedResourceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.LocalizedResourceView> GetFiltered(long pageNumber, string filterName);


    }
}