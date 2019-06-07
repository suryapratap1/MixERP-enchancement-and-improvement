// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Public.Data
{
    public interface IDbStatRepository
    {
        /// <summary>
        /// Performs count on IDbStatRepository.
        /// </summary>
        /// <returns>Returns the number of IDbStatRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "DbStat" class from IDbStatRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "DbStat" class.</returns>
        IEnumerable<MixERP.Net.Entities.Public.DbStat> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from IDbStatRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "DbStat" class.</returns>
        IEnumerable<MixERP.Net.Entities.Public.DbStat> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IDbStatRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "DbStat" class.</returns>
        IEnumerable<MixERP.Net.Entities.Public.DbStat> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IDbStatRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "DbStat" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IDbStatRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "DbStat" class.</returns>
        IEnumerable<MixERP.Net.Entities.Public.DbStat> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IDbStatRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "DbStat" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IDbStatRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "DbStat" class.</returns>
        IEnumerable<MixERP.Net.Entities.Public.DbStat> GetFiltered(long pageNumber, string filterName);


    }
}