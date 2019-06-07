// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ITaxBaseAmountTypeSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ITaxBaseAmountTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ITaxBaseAmountTypeSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "TaxBaseAmountTypeSelectorView" class from ITaxBaseAmountTypeSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "TaxBaseAmountTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountTypeSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ITaxBaseAmountTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ITaxBaseAmountTypeSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ITaxBaseAmountTypeSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "TaxBaseAmountTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountTypeSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ITaxBaseAmountTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "TaxBaseAmountTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountTypeSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITaxBaseAmountTypeSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "TaxBaseAmountTypeSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ITaxBaseAmountTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "TaxBaseAmountTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountTypeSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITaxBaseAmountTypeSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "TaxBaseAmountTypeSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ITaxBaseAmountTypeSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "TaxBaseAmountTypeSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountTypeSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}