// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalesTaxSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ISalesTaxSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalesTaxSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalesTaxSelectorView" class from ISalesTaxSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalesTaxSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalesTaxSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalesTaxSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalesTaxSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalesTaxSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalesTaxSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalesTaxSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalesTaxSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalesTaxSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalesTaxSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalesTaxSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalesTaxSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalesTaxSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalesTaxSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalesTaxSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}