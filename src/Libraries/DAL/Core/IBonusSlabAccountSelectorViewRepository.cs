// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IBonusSlabAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IBonusSlabAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IBonusSlabAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "BonusSlabAccountSelectorView" class from IBonusSlabAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "BonusSlabAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IBonusSlabAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IBonusSlabAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IBonusSlabAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "BonusSlabAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IBonusSlabAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "BonusSlabAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IBonusSlabAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "BonusSlabAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IBonusSlabAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "BonusSlabAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IBonusSlabAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "BonusSlabAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IBonusSlabAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "BonusSlabAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}