// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPartyViewRepository
    {
        /// <summary>
        /// Performs count on IPartyViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPartyViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PartyView" class from IPartyViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PartyView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPartyViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPartyViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PartyView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PartyView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPartyViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PartyView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPartyViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PartyView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPartyViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PartyView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPartyViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PartyView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyView> GetFiltered(long pageNumber, string filterName);


    }
}