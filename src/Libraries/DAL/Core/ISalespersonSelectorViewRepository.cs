// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISalespersonSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ISalespersonSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ISalespersonSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "SalespersonSelectorView" class from ISalespersonSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "SalespersonSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ISalespersonSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ISalespersonSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalespersonSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "SalespersonSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ISalespersonSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "SalespersonSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISalespersonSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "SalespersonSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ISalespersonSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "SalespersonSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISalespersonSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "SalespersonSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ISalespersonSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "SalespersonSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SalespersonSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}