// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IPartyItemChartViewRepository
    {
        /// <summary>
        /// Performs count on IPartyItemChartViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPartyItemChartViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PartyItemChartView" class from IPartyItemChartViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PartyItemChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartyItemChartView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPartyItemChartViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPartyItemChartViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyItemChartViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PartyItemChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartyItemChartView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyItemChartViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PartyItemChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartyItemChartView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPartyItemChartViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PartyItemChartView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPartyItemChartViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PartyItemChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartyItemChartView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPartyItemChartViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PartyItemChartView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPartyItemChartViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PartyItemChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartyItemChartView> GetFiltered(long pageNumber, string filterName);


    }
}