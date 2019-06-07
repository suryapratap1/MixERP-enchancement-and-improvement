// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICostOfSalesAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ICostOfSalesAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICostOfSalesAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CostOfSalesAccountSelectorView" class from ICostOfSalesAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CostOfSalesAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CostOfSalesAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICostOfSalesAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICostOfSalesAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICostOfSalesAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CostOfSalesAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CostOfSalesAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICostOfSalesAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CostOfSalesAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CostOfSalesAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICostOfSalesAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CostOfSalesAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICostOfSalesAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CostOfSalesAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CostOfSalesAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICostOfSalesAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CostOfSalesAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICostOfSalesAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CostOfSalesAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CostOfSalesAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}