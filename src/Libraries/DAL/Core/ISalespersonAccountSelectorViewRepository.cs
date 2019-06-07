// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalespersonAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ISalespersonAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalespersonAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalespersonAccountSelectorView" class from ISalespersonAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalespersonAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalespersonAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalespersonAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalespersonAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalespersonAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalespersonAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalespersonAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalespersonAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalespersonAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalespersonAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalespersonAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalespersonAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalespersonAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalespersonAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalespersonAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}