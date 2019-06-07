// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface IOpenExchangeRateScrudViewRepository
    {
        /// <summary>
        /// Performs count on IOpenExchangeRateScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IOpenExchangeRateScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "OpenExchangeRateScrudView" class from IOpenExchangeRateScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "OpenExchangeRateScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> Get();



        /// <summary>
        /// Produces a paginated result of 10 items from IOpenExchangeRateScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "OpenExchangeRateScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IOpenExchangeRateScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "OpenExchangeRateScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IOpenExchangeRateScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "OpenExchangeRateScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IOpenExchangeRateScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "OpenExchangeRateScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IOpenExchangeRateScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "OpenExchangeRateScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IOpenExchangeRateScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "OpenExchangeRateScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRateScrudView> GetFiltered(long pageNumber, string filterName);


    }
}