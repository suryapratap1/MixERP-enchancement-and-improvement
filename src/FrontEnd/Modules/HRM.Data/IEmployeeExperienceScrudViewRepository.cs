// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeExperienceScrudViewRepository
    {
        /// <summary>
        /// Performs count on IEmployeeExperienceScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IEmployeeExperienceScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "EmployeeExperienceScrudView" class from IEmployeeExperienceScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "EmployeeExperienceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperienceScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IEmployeeExperienceScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IEmployeeExperienceScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeExperienceScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "EmployeeExperienceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperienceScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeExperienceScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "EmployeeExperienceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperienceScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeExperienceScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "EmployeeExperienceScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IEmployeeExperienceScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "EmployeeExperienceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperienceScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeExperienceScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "EmployeeExperienceScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IEmployeeExperienceScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "EmployeeExperienceScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeExperienceScrudView> GetFiltered(long pageNumber, string filterName);


    }
}