// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IBonusSlabDetailScrudViewRepository
    {
        /// <summary>
        /// Performs count on IBonusSlabDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IBonusSlabDetailScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "BonusSlabDetailScrudView" class from IBonusSlabDetailScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "BonusSlabDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetailScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IBonusSlabDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IBonusSlabDetailScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IBonusSlabDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "BonusSlabDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetailScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IBonusSlabDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "BonusSlabDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetailScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IBonusSlabDetailScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "BonusSlabDetailScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IBonusSlabDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "BonusSlabDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetailScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IBonusSlabDetailScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "BonusSlabDetailScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IBonusSlabDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "BonusSlabDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetailScrudView> GetFiltered(long pageNumber, string filterName);


    }
}