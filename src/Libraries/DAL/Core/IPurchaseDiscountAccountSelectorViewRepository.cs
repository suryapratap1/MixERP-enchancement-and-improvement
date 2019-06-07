// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPurchaseDiscountAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IPurchaseDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPurchaseDiscountAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PurchaseDiscountAccountSelectorView" class from IPurchaseDiscountAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PurchaseDiscountAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurchaseDiscountAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPurchaseDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPurchaseDiscountAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPurchaseDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PurchaseDiscountAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurchaseDiscountAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPurchaseDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PurchaseDiscountAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurchaseDiscountAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPurchaseDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PurchaseDiscountAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPurchaseDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PurchaseDiscountAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurchaseDiscountAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPurchaseDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PurchaseDiscountAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPurchaseDiscountAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PurchaseDiscountAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PurchaseDiscountAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}