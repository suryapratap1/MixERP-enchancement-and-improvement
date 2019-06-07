// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface ICashRepositoryScrudViewRepository
    {
        /// <summary>
        /// Performs count on ICashRepositoryScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICashRepositoryScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CashRepositoryScrudView" class from ICashRepositoryScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CashRepositoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepositoryScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICashRepositoryScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICashRepositoryScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICashRepositoryScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CashRepositoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepositoryScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICashRepositoryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CashRepositoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepositoryScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICashRepositoryScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CashRepositoryScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICashRepositoryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CashRepositoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepositoryScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICashRepositoryScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CashRepositoryScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICashRepositoryScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CashRepositoryScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepositoryScrudView> GetFiltered(long pageNumber, string filterName);


    }
}