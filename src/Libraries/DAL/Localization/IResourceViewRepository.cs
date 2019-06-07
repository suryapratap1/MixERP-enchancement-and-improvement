// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Localization.Data
{
    public interface IResourceViewRepository
    {
        /// <summary>
        /// Performs count on IResourceViewRepository.
        /// </summary>
        /// <returns>Returns the number of IResourceViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "ResourceView" class from IResourceViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "ResourceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.ResourceView> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from IResourceViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "ResourceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.ResourceView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IResourceViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "ResourceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.ResourceView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IResourceViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "ResourceView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IResourceViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "ResourceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.ResourceView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IResourceViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "ResourceView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IResourceViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "ResourceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.ResourceView> GetFiltered(long pageNumber, string filterName);


    }
}