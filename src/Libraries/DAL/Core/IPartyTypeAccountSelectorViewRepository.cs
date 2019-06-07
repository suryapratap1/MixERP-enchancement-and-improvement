// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPartyTypeAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IPartyTypeAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPartyTypeAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PartyTypeAccountSelectorView" class from IPartyTypeAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PartyTypeAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPartyTypeAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPartyTypeAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyTypeAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PartyTypeAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyTypeAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PartyTypeAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPartyTypeAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PartyTypeAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPartyTypeAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PartyTypeAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPartyTypeAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PartyTypeAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPartyTypeAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PartyTypeAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}