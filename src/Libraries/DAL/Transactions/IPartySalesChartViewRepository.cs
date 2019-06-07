// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IPartySalesChartViewRepository
    {
        /// <summary>
        /// Performs count on IPartySalesChartViewRepository.
        /// </summary>
        /// <returns>Returns the number of IPartySalesChartViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "PartySalesChartView" class from IPartySalesChartViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "PartySalesChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartySalesChartView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IPartySalesChartViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IPartySalesChartViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartySalesChartViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "PartySalesChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartySalesChartView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IPartySalesChartViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "PartySalesChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartySalesChartView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPartySalesChartViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "PartySalesChartView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IPartySalesChartViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "PartySalesChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartySalesChartView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPartySalesChartViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "PartySalesChartView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IPartySalesChartViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "PartySalesChartView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.PartySalesChartView> GetFiltered(long pageNumber, string filterName);


    }
}