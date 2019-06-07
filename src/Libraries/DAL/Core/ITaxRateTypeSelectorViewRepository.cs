// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ITaxRateTypeSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ITaxRateTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ITaxRateTypeSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "TaxRateTypeSelectorView" class from ITaxRateTypeSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "TaxRateTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxRateTypeSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ITaxRateTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ITaxRateTypeSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ITaxRateTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "TaxRateTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxRateTypeSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ITaxRateTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "TaxRateTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxRateTypeSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITaxRateTypeSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "TaxRateTypeSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ITaxRateTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "TaxRateTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxRateTypeSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITaxRateTypeSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "TaxRateTypeSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ITaxRateTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "TaxRateTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxRateTypeSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}