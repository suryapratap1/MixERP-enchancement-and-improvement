// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface ICostCenterScrudViewRepository
    {
        /// <summary>
        /// Performs count on ICostCenterScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICostCenterScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CostCenterScrudView" class from ICostCenterScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CostCenterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CostCenterScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICostCenterScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICostCenterScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICostCenterScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CostCenterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CostCenterScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICostCenterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CostCenterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CostCenterScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICostCenterScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CostCenterScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICostCenterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CostCenterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CostCenterScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICostCenterScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CostCenterScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICostCenterScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CostCenterScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CostCenterScrudView> GetFiltered(long pageNumber, string filterName);


    }
}