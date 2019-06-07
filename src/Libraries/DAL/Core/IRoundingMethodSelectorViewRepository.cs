// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IRoundingMethodSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IRoundingMethodSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IRoundingMethodSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "RoundingMethodSelectorView" class from IRoundingMethodSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "RoundingMethodSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RoundingMethodSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IRoundingMethodSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IRoundingMethodSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IRoundingMethodSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "RoundingMethodSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RoundingMethodSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IRoundingMethodSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "RoundingMethodSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RoundingMethodSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRoundingMethodSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "RoundingMethodSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IRoundingMethodSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "RoundingMethodSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RoundingMethodSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRoundingMethodSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "RoundingMethodSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IRoundingMethodSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "RoundingMethodSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RoundingMethodSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}