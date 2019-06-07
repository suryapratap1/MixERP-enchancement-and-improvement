// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICurrencyScrudViewRepository
    {
        /// <summary>
        /// Performs count on ICurrencyScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICurrencyScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CurrencyScrudView" class from ICurrencyScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CurrencyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CurrencyScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICurrencyScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICurrencyScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICurrencyScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CurrencyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CurrencyScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICurrencyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CurrencyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CurrencyScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICurrencyScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CurrencyScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICurrencyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CurrencyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CurrencyScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICurrencyScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CurrencyScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICurrencyScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CurrencyScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CurrencyScrudView> GetFiltered(long pageNumber, string filterName);


    }
}