// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IPartyPurchaseChartViewRepository
    {
        /// <summary>
        /// Performs count on IPartyPurchaseChartViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPartyPurchaseChartViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PartyPurchaseChartView" class from IPartyPurchaseChartViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PartyPurchaseChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartyPurchaseChartView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPartyPurchaseChartViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPartyPurchaseChartViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyPurchaseChartViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PartyPurchaseChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartyPurchaseChartView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartyPurchaseChartViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PartyPurchaseChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartyPurchaseChartView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPartyPurchaseChartViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PartyPurchaseChartView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPartyPurchaseChartViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PartyPurchaseChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartyPurchaseChartView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPartyPurchaseChartViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PartyPurchaseChartView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPartyPurchaseChartViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PartyPurchaseChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartyPurchaseChartView> GetFiltered(long pageNumber, string filterName);


    }
}