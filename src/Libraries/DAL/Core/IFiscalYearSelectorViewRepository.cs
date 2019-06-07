// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IFiscalYearSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IFiscalYearSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IFiscalYearSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "FiscalYearSelectorView" class from IFiscalYearSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "FiscalYearSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYearSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IFiscalYearSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IFiscalYearSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IFiscalYearSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "FiscalYearSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYearSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IFiscalYearSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "FiscalYearSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYearSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFiscalYearSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "FiscalYearSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IFiscalYearSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "FiscalYearSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYearSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFiscalYearSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "FiscalYearSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IFiscalYearSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "FiscalYearSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYearSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}