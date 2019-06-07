// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAccountMasterSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IAccountMasterSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IAccountMasterSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "AccountMasterSelectorView" class from IAccountMasterSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "AccountMasterSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountMasterSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IAccountMasterSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IAccountMasterSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IAccountMasterSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "AccountMasterSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountMasterSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IAccountMasterSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "AccountMasterSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountMasterSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAccountMasterSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "AccountMasterSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IAccountMasterSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "AccountMasterSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountMasterSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAccountMasterSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "AccountMasterSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IAccountMasterSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "AccountMasterSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountMasterSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}