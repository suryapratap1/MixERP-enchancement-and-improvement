// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICashFlowSetupScrudViewRepository
    {
        /// <summary>
        /// Performs count on ICashFlowSetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICashFlowSetupScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CashFlowSetupScrudView" class from ICashFlowSetupScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CashFlowSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowSetupScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICashFlowSetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICashFlowSetupScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICashFlowSetupScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CashFlowSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowSetupScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICashFlowSetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CashFlowSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowSetupScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICashFlowSetupScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CashFlowSetupScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICashFlowSetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CashFlowSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowSetupScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICashFlowSetupScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CashFlowSetupScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICashFlowSetupScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CashFlowSetupScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CashFlowSetupScrudView> GetFiltered(long pageNumber, string filterName);


    }
}