// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface ILeaveTypeRepository
    {
        /// <summary>
        /// Counts the number of LeaveType in ILeaveTypeRepository.
        /// </summary>
        /// <returns>Returns the count of ILeaveTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of LeaveType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LeaveType.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveType> GetAll();

        /// <summary>
        /// Returns all instances of LeaveType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LeaveType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the LeaveType against leaveTypeId. 
        /// </summary>
        /// <param name="leaveTypeId">The column "leave_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of LeaveType.</returns>
        MixERP.Net.Entities.HRM.LeaveType Get(int leaveTypeId);

        /// <summary>
        /// Gets the first record of LeaveType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LeaveType.</returns>
        MixERP.Net.Entities.HRM.LeaveType GetFirst();

        /// <summary>
        /// Gets the previous record of LeaveType sorted by leaveTypeId. 
        /// </summary>
        /// <param name="leaveTypeId">The column "leave_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LeaveType.</returns>
        MixERP.Net.Entities.HRM.LeaveType GetPrevious(int leaveTypeId);

        /// <summary>
        /// Gets the next record of LeaveType sorted by leaveTypeId. 
        /// </summary>
        /// <param name="leaveTypeId">The column "leave_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LeaveType.</returns>
        MixERP.Net.Entities.HRM.LeaveType GetNext(int leaveTypeId);

        /// <summary>
        /// Gets the last record of LeaveType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LeaveType.</returns>
        MixERP.Net.Entities.HRM.LeaveType GetLast();

        /// <summary>
        /// Returns multiple instances of the LeaveType against leaveTypeIds. 
        /// </summary>
        /// <param name="leaveTypeIds">Array of column "leave_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of LeaveType.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveType> Get(int[] leaveTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for ILeaveTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for LeaveType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding LeaveType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for LeaveType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of LeaveType class to ILeaveTypeRepository.
        /// </summary>
        /// <param name="leaveType">The instance of LeaveType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic leaveType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of LeaveType class to ILeaveTypeRepository.
        /// </summary>
        /// <param name="leaveType">The instance of LeaveType class to insert.</param>
        object Add(dynamic leaveType);

        /// <summary>
        /// Inserts or updates multiple instances of LeaveType class to ILeaveTypeRepository.;
        /// </summary>
        /// <param name="leaveTypes">List of LeaveType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> leaveTypes);


        /// <summary>
        /// Updates ILeaveTypeRepository with an instance of LeaveType class against the primary key value.
        /// </summary>
        /// <param name="leaveType">The instance of LeaveType class to update.</param>
        /// <param name="leaveTypeId">The value of the column "leave_type_id" which will be updated.</param>
        void Update(dynamic leaveType, int leaveTypeId);

        /// <summary>
        /// Deletes LeaveType from  ILeaveTypeRepository against the primary key value.
        /// </summary>
        /// <param name="leaveTypeId">The value of the column "leave_type_id" which will be deleted.</param>
        void Delete(int leaveTypeId);

        /// <summary>
        /// Produces a paginated result of 10 LeaveType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of LeaveType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 LeaveType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of LeaveType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILeaveTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of LeaveType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ILeaveTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of LeaveType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILeaveTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of LeaveType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ILeaveTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of LeaveType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveType> GetFiltered(long pageNumber, string filterName);



    }
}