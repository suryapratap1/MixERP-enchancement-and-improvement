// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPartyTypeSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IPartyTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPartyTypeSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PartyTypeSelectorView" class from IPartyTypeSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PartyTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPartyTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPartyTypeSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PartyTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PartyTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPartyTypeSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PartyTypeSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPartyTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PartyTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPartyTypeSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PartyTypeSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPartyTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PartyTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyTypeSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}