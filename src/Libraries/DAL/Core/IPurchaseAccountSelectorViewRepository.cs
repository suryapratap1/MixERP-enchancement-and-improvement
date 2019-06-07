// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPurchaseAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IPurchaseAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPurchaseAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PurchaseAccountSelectorView" class from IPurchaseAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PurchaseAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurchaseAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPurchaseAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPurchaseAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPurchaseAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PurchaseAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurchaseAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPurchaseAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PurchaseAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurchaseAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPurchaseAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PurchaseAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPurchaseAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PurchaseAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurchaseAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPurchaseAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PurchaseAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPurchaseAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PurchaseAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurchaseAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}