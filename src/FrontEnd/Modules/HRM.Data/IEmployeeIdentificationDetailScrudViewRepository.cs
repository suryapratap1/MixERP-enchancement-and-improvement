// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeIdentificationDetailScrudViewRepository
    {
        /// <summary>
        /// Performs count on IEmployeeIdentificationDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IEmployeeIdentificationDetailScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "EmployeeIdentificationDetailScrudView" class from IEmployeeIdentificationDetailScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "EmployeeIdentificationDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IEmployeeIdentificationDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IEmployeeIdentificationDetailScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeIdentificationDetailScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "EmployeeIdentificationDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeIdentificationDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "EmployeeIdentificationDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeIdentificationDetailScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "EmployeeIdentificationDetailScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IEmployeeIdentificationDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "EmployeeIdentificationDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeIdentificationDetailScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "EmployeeIdentificationDetailScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IEmployeeIdentificationDetailScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "EmployeeIdentificationDetailScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetailScrudView> GetFiltered(long pageNumber, string filterName);


    }
}