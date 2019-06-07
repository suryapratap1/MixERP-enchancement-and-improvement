// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface ILeaveApplicationVerificationScrudViewRepository
    {
        /// <summary>
        /// Performs count on ILeaveApplicationVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of ILeaveApplicationVerificationScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "LeaveApplicationVerificationScrudView" class from ILeaveApplicationVerificationScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "LeaveApplicationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ILeaveApplicationVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ILeaveApplicationVerificationScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ILeaveApplicationVerificationScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "LeaveApplicationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ILeaveApplicationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "LeaveApplicationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILeaveApplicationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "LeaveApplicationVerificationScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ILeaveApplicationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "LeaveApplicationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILeaveApplicationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "LeaveApplicationVerificationScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ILeaveApplicationVerificationScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "LeaveApplicationVerificationScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplicationVerificationScrudView> GetFiltered(long pageNumber, string filterName);


    }
}