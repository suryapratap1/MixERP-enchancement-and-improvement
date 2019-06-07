// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface ICurrencyLayerScrudViewRepository
    {
        /// <summary>
        /// Performs count on ICurrencyLayerScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICurrencyLayerScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CurrencyLayerScrudView" class from ICurrencyLayerScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CurrencyLayerScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.CurrencyLayerScrudView> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from ICurrencyLayerScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CurrencyLayerScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.CurrencyLayerScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICurrencyLayerScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CurrencyLayerScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.CurrencyLayerScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICurrencyLayerScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CurrencyLayerScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICurrencyLayerScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CurrencyLayerScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.CurrencyLayerScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICurrencyLayerScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CurrencyLayerScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICurrencyLayerScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CurrencyLayerScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.CurrencyLayerScrudView> GetFiltered(long pageNumber, string filterName);


    }
}