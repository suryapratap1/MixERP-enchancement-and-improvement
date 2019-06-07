// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IAttendanceViewRepository
    {
        /// <summary>
        /// Performs count on IAttendanceViewRepository.
        /// </summary>
        /// <returns>Returns the number of IAttendanceViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "AttendanceView" class from IAttendanceViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "AttendanceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.AttendanceView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IAttendanceViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IAttendanceViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IAttendanceViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "AttendanceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.AttendanceView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IAttendanceViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "AttendanceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.AttendanceView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAttendanceViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "AttendanceView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IAttendanceViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "AttendanceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.AttendanceView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAttendanceViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "AttendanceView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IAttendanceViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "AttendanceView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.AttendanceView> GetFiltered(long pageNumber, string filterName);


    }
}