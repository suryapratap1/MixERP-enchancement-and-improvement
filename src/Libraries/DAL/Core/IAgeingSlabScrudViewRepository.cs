// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAgeingSlabScrudViewRepository
    {
        /// <summary>
        /// Performs count on IAgeingSlabScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IAgeingSlabScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "AgeingSlabScrudView" class from IAgeingSlabScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "AgeingSlabScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AgeingSlabScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IAgeingSlabScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IAgeingSlabScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IAgeingSlabScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "AgeingSlabScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AgeingSlabScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IAgeingSlabScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "AgeingSlabScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AgeingSlabScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAgeingSlabScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "AgeingSlabScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IAgeingSlabScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "AgeingSlabScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AgeingSlabScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAgeingSlabScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "AgeingSlabScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IAgeingSlabScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "AgeingSlabScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AgeingSlabScrudView> GetFiltered(long pageNumber, string filterName);


    }
}