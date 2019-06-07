// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPartyUserControlViewRepository
    {
        /// <summary>
        /// Performs count on IPartyUserControlViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPartyUserControlViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PartyUserControlView" class from IPartyUserControlViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PartyUserControlView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyUserControlView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPartyUserControlViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPartyUserControlViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyUserControlViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PartyUserControlView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyUserControlView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyUserControlViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PartyUserControlView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyUserControlView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPartyUserControlViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PartyUserControlView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPartyUserControlViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PartyUserControlView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyUserControlView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPartyUserControlViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PartyUserControlView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPartyUserControlViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PartyUserControlView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyUserControlView> GetFiltered(long pageNumber, string filterName);


    }
}