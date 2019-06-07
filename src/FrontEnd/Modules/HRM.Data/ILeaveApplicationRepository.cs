// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface ILeaveApplicationRepository
    {
        /// <summary>
        /// Counts the number of LeaveApplication in ILeaveApplicationRepository.
        /// </summary>
        /// <returns>Returns the count of ILeaveApplicationRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of LeaveApplication. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LeaveApplication.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> GetAll();

        /// <summary>
        /// Returns all instances of LeaveApplication to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LeaveApplication.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the LeaveApplication against leaveApplicationId. 
        /// </summary>
        /// <param name="leaveApplicationId">The column "leave_application_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of LeaveApplication.</returns>
        MixERP.Net.Entities.HRM.LeaveApplication Get(long leaveApplicationId);

        /// <summary>
        /// Gets the first record of LeaveApplication.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LeaveApplication.</returns>
        MixERP.Net.Entities.HRM.LeaveApplication GetFirst();

        /// <summary>
        /// Gets the previous record of LeaveApplication sorted by leaveApplicationId. 
        /// </summary>
        /// <param name="leaveApplicationId">The column "leave_application_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LeaveApplication.</returns>
        MixERP.Net.Entities.HRM.LeaveApplication GetPrevious(long leaveApplicationId);

        /// <summary>
        /// Gets the next record of LeaveApplication sorted by leaveApplicationId. 
        /// </summary>
        /// <param name="leaveApplicationId">The column "leave_application_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LeaveApplication.</returns>
        MixERP.Net.Entities.HRM.LeaveApplication GetNext(long leaveApplicationId);

        /// <summary>
        /// Gets the last record of LeaveApplication.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LeaveApplication.</returns>
        MixERP.Net.Entities.HRM.LeaveApplication GetLast();

        /// <summary>
        /// Returns multiple instances of the LeaveApplication against leaveApplicationIds. 
        /// </summary>
        /// <param name="leaveApplicationIds">Array of column "leave_application_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of LeaveApplication.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> Get(long[] leaveApplicationIds);

        /// <summary>
        /// Custom fields are user defined form elements for ILeaveApplicationRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for LeaveApplication.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding LeaveApplication.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for LeaveApplication.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of LeaveApplication class to ILeaveApplicationRepository.
        /// </summary>
        /// <param name="leaveApplication">The instance of LeaveApplication class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic leaveApplication, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of LeaveApplication class to ILeaveApplicationRepository.
        /// </summary>
        /// <param name="leaveApplication">The instance of LeaveApplication class to insert.</param>
        object Add(dynamic leaveApplication);

        /// <summary>
        /// Inserts or updates multiple instances of LeaveApplication class to ILeaveApplicationRepository.;
        /// </summary>
        /// <param name="leaveApplications">List of LeaveApplication class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> leaveApplications);


        /// <summary>
        /// Updates ILeaveApplicationRepository with an instance of LeaveApplication class against the primary key value.
        /// </summary>
        /// <param name="leaveApplication">The instance of LeaveApplication class to update.</param>
        /// <param name="leaveApplicationId">The value of the column "leave_application_id" which will be updated.</param>
        void Update(dynamic leaveApplication, long leaveApplicationId);

        /// <summary>
        /// Deletes LeaveApplication from  ILeaveApplicationRepository against the primary key value.
        /// </summary>
        /// <param name="leaveApplicationId">The value of the column "leave_application_id" which will be deleted.</param>
        void Delete(long leaveApplicationId);

        /// <summary>
        /// Produces a paginated result of 10 LeaveApplication classes.
        /// </summary>
        /// <returns>Returns the first page of collection of LeaveApplication class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 LeaveApplication classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of LeaveApplication class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILeaveApplicationRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of LeaveApplication class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ILeaveApplicationRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of LeaveApplication class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILeaveApplicationRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of LeaveApplication class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ILeaveApplicationRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of LeaveApplication class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.LeaveApplication> GetFiltered(long pageNumber, string filterName);


        void Verify(long leaveApplicationId, short verificationStatusId, string reason);

    }
}