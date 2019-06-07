// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IRoleViewRepository
    {
        /// <summary>
        /// Performs count on IRoleViewRepository.
        /// </summary>
        /// <returns>Returns the number of IRoleViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "RoleView" class from IRoleViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "RoleView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.RoleView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IRoleViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IRoleViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IRoleViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "RoleView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.RoleView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IRoleViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "RoleView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.RoleView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRoleViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "RoleView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IRoleViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "RoleView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.RoleView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRoleViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "RoleView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IRoleViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "RoleView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.RoleView> GetFiltered(long pageNumber, string filterName);


    }
}