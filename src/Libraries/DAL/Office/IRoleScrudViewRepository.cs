// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IRoleScrudViewRepository
    {
        /// <summary>
        /// Performs count on IRoleScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IRoleScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "RoleScrudView" class from IRoleScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "RoleScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.RoleScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IRoleScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IRoleScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IRoleScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "RoleScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.RoleScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IRoleScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "RoleScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.RoleScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRoleScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "RoleScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IRoleScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "RoleScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.RoleScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRoleScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "RoleScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IRoleScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "RoleScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.RoleScrudView> GetFiltered(long pageNumber, string filterName);


    }
}