// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IMerchantFeeSetupAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IMerchantFeeSetupAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IMerchantFeeSetupAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "MerchantFeeSetupAccountSelectorView" class from IMerchantFeeSetupAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "MerchantFeeSetupAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetupAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IMerchantFeeSetupAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IMerchantFeeSetupAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IMerchantFeeSetupAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "MerchantFeeSetupAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetupAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IMerchantFeeSetupAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "MerchantFeeSetupAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetupAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IMerchantFeeSetupAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "MerchantFeeSetupAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IMerchantFeeSetupAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "MerchantFeeSetupAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetupAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IMerchantFeeSetupAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "MerchantFeeSetupAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IMerchantFeeSetupAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "MerchantFeeSetupAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetupAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}