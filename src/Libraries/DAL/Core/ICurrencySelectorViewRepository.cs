// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICurrencySelectorViewRepository
    {
        /// <summary>
        /// Performs count on ICurrencySelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICurrencySelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CurrencySelectorView" class from ICurrencySelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CurrencySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CurrencySelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICurrencySelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICurrencySelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICurrencySelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CurrencySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CurrencySelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICurrencySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CurrencySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CurrencySelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICurrencySelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CurrencySelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICurrencySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CurrencySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CurrencySelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICurrencySelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CurrencySelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICurrencySelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CurrencySelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CurrencySelectorView> GetFiltered(long pageNumber, string filterName);


    }
}