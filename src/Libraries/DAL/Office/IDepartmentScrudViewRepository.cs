// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IDepartmentScrudViewRepository
    {
        /// <summary>
        /// Performs count on IDepartmentScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IDepartmentScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "DepartmentScrudView" class from IDepartmentScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "DepartmentScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.DepartmentScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IDepartmentScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IDepartmentScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IDepartmentScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "DepartmentScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.DepartmentScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IDepartmentScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "DepartmentScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.DepartmentScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IDepartmentScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "DepartmentScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IDepartmentScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "DepartmentScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.DepartmentScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IDepartmentScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "DepartmentScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IDepartmentScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "DepartmentScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.DepartmentScrudView> GetFiltered(long pageNumber, string filterName);


    }
}