// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTeamScrudViewRepository
    {
        /// <summary>
        /// Performs count on ISalesTeamScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesTeamScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesTeamScrudView" class from ISalesTeamScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesTeamScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeamScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesTeamScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesTeamScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTeamScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesTeamScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeamScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTeamScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesTeamScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeamScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTeamScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesTeamScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesTeamScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesTeamScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeamScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTeamScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesTeamScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesTeamScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesTeamScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeamScrudView> GetFiltered(long pageNumber, string filterName);


    }
}