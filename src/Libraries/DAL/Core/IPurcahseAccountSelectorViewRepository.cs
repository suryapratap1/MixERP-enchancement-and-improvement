// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPurcahseAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IPurcahseAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPurcahseAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PurcahseAccountSelectorView" class from IPurcahseAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PurcahseAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurcahseAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPurcahseAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPurcahseAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPurcahseAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PurcahseAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurcahseAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPurcahseAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PurcahseAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurcahseAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPurcahseAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PurcahseAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPurcahseAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PurcahseAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurcahseAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPurcahseAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PurcahseAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPurcahseAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PurcahseAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurcahseAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}