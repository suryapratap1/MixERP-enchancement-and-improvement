// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IBankAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IBankAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IBankAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "BankAccountSelectorView" class from IBankAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "BankAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IBankAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IBankAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IBankAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "BankAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IBankAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "BankAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IBankAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "BankAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IBankAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "BankAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IBankAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "BankAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IBankAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "BankAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}