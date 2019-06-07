// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IAttendanceRepository
    {
        /// <summary>
        /// Counts the number of Attendance in IAttendanceRepository.
        /// </summary>
        /// <returns>Returns the count of IAttendanceRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Attendance. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Attendance.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Attendance> GetAll();

        /// <summary>
        /// Returns all instances of Attendance to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Attendance.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Attendance against attendanceId. 
        /// </summary>
        /// <param name="attendanceId">The column "attendance_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Attendance.</returns>
        MixERP.Net.Entities.HRM.Attendance Get(long attendanceId);

        /// <summary>
        /// Gets the first record of Attendance.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Attendance.</returns>
        MixERP.Net.Entities.HRM.Attendance GetFirst();

        /// <summary>
        /// Gets the previous record of Attendance sorted by attendanceId. 
        /// </summary>
        /// <param name="attendanceId">The column "attendance_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Attendance.</returns>
        MixERP.Net.Entities.HRM.Attendance GetPrevious(long attendanceId);

        /// <summary>
        /// Gets the next record of Attendance sorted by attendanceId. 
        /// </summary>
        /// <param name="attendanceId">The column "attendance_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Attendance.</returns>
        MixERP.Net.Entities.HRM.Attendance GetNext(long attendanceId);

        /// <summary>
        /// Gets the last record of Attendance.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Attendance.</returns>
        MixERP.Net.Entities.HRM.Attendance GetLast();

        /// <summary>
        /// Returns multiple instances of the Attendance against attendanceIds. 
        /// </summary>
        /// <param name="attendanceIds">Array of column "attendance_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Attendance.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Attendance> Get(long[] attendanceIds);

        /// <summary>
        /// Custom fields are user defined form elements for IAttendanceRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Attendance.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Attendance.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Attendance.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Attendance class to IAttendanceRepository.
        /// </summary>
        /// <param name="attendance">The instance of Attendance class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic attendance, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Attendance class to IAttendanceRepository.
        /// </summary>
        /// <param name="attendance">The instance of Attendance class to insert.</param>
        object Add(dynamic attendance);

        /// <summary>
        /// Inserts or updates multiple instances of Attendance class to IAttendanceRepository.;
        /// </summary>
        /// <param name="attendances">List of Attendance class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> attendances);


        /// <summary>
        /// Updates IAttendanceRepository with an instance of Attendance class against the primary key value.
        /// </summary>
        /// <param name="attendance">The instance of Attendance class to update.</param>
        /// <param name="attendanceId">The value of the column "attendance_id" which will be updated.</param>
        void Update(dynamic attendance, long attendanceId);

        /// <summary>
        /// Deletes Attendance from  IAttendanceRepository against the primary key value.
        /// </summary>
        /// <param name="attendanceId">The value of the column "attendance_id" which will be deleted.</param>
        void Delete(long attendanceId);

        /// <summary>
        /// Produces a paginated result of 10 Attendance classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Attendance class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Attendance> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Attendance classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Attendance class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Attendance> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAttendanceRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Attendance class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IAttendanceRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Attendance class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Attendance> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAttendanceRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Attendance class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IAttendanceRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Attendance class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Attendance> GetFiltered(long pageNumber, string filterName);



    }
}