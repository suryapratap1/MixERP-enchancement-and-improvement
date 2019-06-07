// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface IMixerpScrudViewRepository
    {
        /// <summary>
        /// Performs count on IMixerpScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IMixerpScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "MixerpScrudView" class from IMixerpScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "MixerpScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.MixerpScrudView> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from IMixerpScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "MixerpScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.MixerpScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IMixerpScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "MixerpScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.MixerpScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IMixerpScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "MixerpScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IMixerpScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "MixerpScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.MixerpScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IMixerpScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "MixerpScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IMixerpScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "MixerpScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.MixerpScrudView> GetFiltered(long pageNumber, string filterName);


    }
}