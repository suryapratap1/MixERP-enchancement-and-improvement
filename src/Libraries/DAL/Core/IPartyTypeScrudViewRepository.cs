// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPartyTypeScrudViewRepository
    {
        /// <summary>
        /// Performs count on IPartyTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPartyTypeScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PartyTypeScrudView" class from IPartyTypeScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PartyTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPartyTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPartyTypeScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PartyTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PartyTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPartyTypeScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PartyTypeScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPartyTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PartyTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPartyTypeScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PartyTypeScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPartyTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PartyTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeScrudView> GetFiltered(long pageNumber, string filterName);


    }
}