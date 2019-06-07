// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeQualificationRepository
    {
        /// <summary>
        /// Counts the number of EmployeeQualification in IEmployeeQualificationRepository.
        /// </summary>
        /// <returns>Returns the count of IEmployeeQualificationRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of EmployeeQualification. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmployeeQualification.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> GetAll();

        /// <summary>
        /// Returns all instances of EmployeeQualification to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmployeeQualification.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the EmployeeQualification against employeeQualificationId. 
        /// </summary>
        /// <param name="employeeQualificationId">The column "employee_qualification_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeQualification.</returns>
        MixERP.Net.Entities.HRM.EmployeeQualification Get(long employeeQualificationId);

        /// <summary>
        /// Gets the first record of EmployeeQualification.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeQualification.</returns>
        MixERP.Net.Entities.HRM.EmployeeQualification GetFirst();

        /// <summary>
        /// Gets the previous record of EmployeeQualification sorted by employeeQualificationId. 
        /// </summary>
        /// <param name="employeeQualificationId">The column "employee_qualification_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeQualification.</returns>
        MixERP.Net.Entities.HRM.EmployeeQualification GetPrevious(long employeeQualificationId);

        /// <summary>
        /// Gets the next record of EmployeeQualification sorted by employeeQualificationId. 
        /// </summary>
        /// <param name="employeeQualificationId">The column "employee_qualification_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeQualification.</returns>
        MixERP.Net.Entities.HRM.EmployeeQualification GetNext(long employeeQualificationId);

        /// <summary>
        /// Gets the last record of EmployeeQualification.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeQualification.</returns>
        MixERP.Net.Entities.HRM.EmployeeQualification GetLast();

        /// <summary>
        /// Returns multiple instances of the EmployeeQualification against employeeQualificationIds. 
        /// </summary>
        /// <param name="employeeQualificationIds">Array of column "employee_qualification_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of EmployeeQualification.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> Get(long[] employeeQualificationIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEmployeeQualificationRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for EmployeeQualification.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding EmployeeQualification.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for EmployeeQualification.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of EmployeeQualification class to IEmployeeQualificationRepository.
        /// </summary>
        /// <param name="employeeQualification">The instance of EmployeeQualification class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic employeeQualification, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of EmployeeQualification class to IEmployeeQualificationRepository.
        /// </summary>
        /// <param name="employeeQualification">The instance of EmployeeQualification class to insert.</param>
        object Add(dynamic employeeQualification);

        /// <summary>
        /// Inserts or updates multiple instances of EmployeeQualification class to IEmployeeQualificationRepository.;
        /// </summary>
        /// <param name="employeeQualifications">List of EmployeeQualification class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> employeeQualifications);


        /// <summary>
        /// Updates IEmployeeQualificationRepository with an instance of EmployeeQualification class against the primary key value.
        /// </summary>
        /// <param name="employeeQualification">The instance of EmployeeQualification class to update.</param>
        /// <param name="employeeQualificationId">The value of the column "employee_qualification_id" which will be updated.</param>
        void Update(dynamic employeeQualification, long employeeQualificationId);

        /// <summary>
        /// Deletes EmployeeQualification from  IEmployeeQualificationRepository against the primary key value.
        /// </summary>
        /// <param name="employeeQualificationId">The value of the column "employee_qualification_id" which will be deleted.</param>
        void Delete(long employeeQualificationId);

        /// <summary>
        /// Produces a paginated result of 10 EmployeeQualification classes.
        /// </summary>
        /// <returns>Returns the first page of collection of EmployeeQualification class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 EmployeeQualification classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of EmployeeQualification class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeQualificationRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of EmployeeQualification class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEmployeeQualificationRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of EmployeeQualification class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeQualificationRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of EmployeeQualification class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEmployeeQualificationRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of EmployeeQualification class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> GetFiltered(long pageNumber, string filterName);



    }
}