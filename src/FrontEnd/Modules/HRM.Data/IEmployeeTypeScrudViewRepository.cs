// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeTypeScrudViewRepository
    {
        /// <summary>
        /// Performs count on IEmployeeTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IEmployeeTypeScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "EmployeeTypeScrudView" class from IEmployeeTypeScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "EmployeeTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeTypeScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IEmployeeTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IEmployeeTypeScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeTypeScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "EmployeeTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeTypeScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "EmployeeTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeTypeScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeTypeScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "EmployeeTypeScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IEmployeeTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "EmployeeTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeTypeScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeTypeScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "EmployeeTypeScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IEmployeeTypeScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "EmployeeTypeScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeTypeScrudView> GetFiltered(long pageNumber, string filterName);


    }
}