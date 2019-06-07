// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface IDbParameterScrudViewRepository
    {
        /// <summary>
        /// Performs count on IDbParameterScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IDbParameterScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "DbParameterScrudView" class from IDbParameterScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "DbParameterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.DbParameterScrudView> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from IDbParameterScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "DbParameterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.DbParameterScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IDbParameterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "DbParameterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.DbParameterScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IDbParameterScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "DbParameterScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IDbParameterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "DbParameterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.DbParameterScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IDbParameterScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "DbParameterScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IDbParameterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "DbParameterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.DbParameterScrudView> GetFiltered(long pageNumber, string filterName);


    }
}