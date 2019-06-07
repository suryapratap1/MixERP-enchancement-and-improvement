// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTeamSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ISalesTeamSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesTeamSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesTeamSelectorView" class from ISalesTeamSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesTeamSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeamSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesTeamSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesTeamSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTeamSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesTeamSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeamSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTeamSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesTeamSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeamSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTeamSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesTeamSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesTeamSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesTeamSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeamSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTeamSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesTeamSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesTeamSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesTeamSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTeamSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}