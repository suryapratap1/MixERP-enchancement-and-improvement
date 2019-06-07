// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICashFlowHeadingScrudViewRepository
    {
        /// <summary>
        /// Performs count on ICashFlowHeadingScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICashFlowHeadingScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CashFlowHeadingScrudView" class from ICashFlowHeadingScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CashFlowHeadingScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowHeadingScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICashFlowHeadingScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICashFlowHeadingScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICashFlowHeadingScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CashFlowHeadingScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowHeadingScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICashFlowHeadingScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CashFlowHeadingScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowHeadingScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICashFlowHeadingScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CashFlowHeadingScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICashFlowHeadingScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CashFlowHeadingScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowHeadingScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICashFlowHeadingScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CashFlowHeadingScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICashFlowHeadingScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CashFlowHeadingScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowHeadingScrudView> GetFiltered(long pageNumber, string filterName);


    }
}