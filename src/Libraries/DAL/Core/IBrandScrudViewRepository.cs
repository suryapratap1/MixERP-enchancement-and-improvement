// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IBrandScrudViewRepository
    {
        /// <summary>
        /// Performs count on IBrandScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IBrandScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "BrandScrudView" class from IBrandScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "BrandScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BrandScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IBrandScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IBrandScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IBrandScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "BrandScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BrandScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IBrandScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "BrandScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BrandScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IBrandScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "BrandScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IBrandScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "BrandScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BrandScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IBrandScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "BrandScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IBrandScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "BrandScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BrandScrudView> GetFiltered(long pageNumber, string filterName);


    }
}