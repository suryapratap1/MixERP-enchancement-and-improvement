// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IBrandSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IBrandSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IBrandSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "BrandSelectorView" class from IBrandSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "BrandSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BrandSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IBrandSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IBrandSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IBrandSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "BrandSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BrandSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IBrandSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "BrandSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BrandSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IBrandSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "BrandSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IBrandSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "BrandSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BrandSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IBrandSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "BrandSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IBrandSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "BrandSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BrandSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}