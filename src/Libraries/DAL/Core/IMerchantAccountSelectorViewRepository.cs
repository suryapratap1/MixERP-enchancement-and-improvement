// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IMerchantAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IMerchantAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IMerchantAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "MerchantAccountSelectorView" class from IMerchantAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "MerchantAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IMerchantAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IMerchantAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IMerchantAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "MerchantAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IMerchantAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "MerchantAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IMerchantAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "MerchantAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IMerchantAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "MerchantAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IMerchantAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "MerchantAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IMerchantAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "MerchantAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}