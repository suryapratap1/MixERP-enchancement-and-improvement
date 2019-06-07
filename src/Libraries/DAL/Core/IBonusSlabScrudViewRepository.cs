// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IBonusSlabScrudViewRepository
    {
        /// <summary>
        /// Performs count on IBonusSlabScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IBonusSlabScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "BonusSlabScrudView" class from IBonusSlabScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "BonusSlabScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IBonusSlabScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IBonusSlabScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IBonusSlabScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "BonusSlabScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IBonusSlabScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "BonusSlabScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IBonusSlabScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "BonusSlabScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IBonusSlabScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "BonusSlabScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IBonusSlabScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "BonusSlabScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IBonusSlabScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "BonusSlabScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BonusSlabScrudView> GetFiltered(long pageNumber, string filterName);


    }
}