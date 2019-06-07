// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface ILeaveApplicationScrudViewRepository
    {
        /// <summary>
        /// Performs count on ILeaveApplicationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ILeaveApplicationScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "LeaveApplicationScrudView" class from ILeaveApplicationScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "LeaveApplicationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ILeaveApplicationScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ILeaveApplicationScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ILeaveApplicationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "LeaveApplicationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ILeaveApplicationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "LeaveApplicationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILeaveApplicationScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "LeaveApplicationScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ILeaveApplicationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "LeaveApplicationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILeaveApplicationScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "LeaveApplicationScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ILeaveApplicationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "LeaveApplicationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationScrudView> GetFiltered(long pageNumber, string filterName);


    }
}