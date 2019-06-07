// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeIdentificationDetailRepository
    {
        /// <summary>
        /// Counts the number of EmployeeIdentificationDetail in IEmployeeIdentificationDetailRepository.
        /// </summary>
        /// <returns>Returns the count of IEmployeeIdentificationDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of EmployeeIdentificationDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmployeeIdentificationDetail.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetAll();

        /// <summary>
        /// Returns all instances of EmployeeIdentificationDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmployeeIdentificationDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the EmployeeIdentificationDetail against employeeIdentificationDetailId. 
        /// </summary>
        /// <param name="employeeIdentificationDetailId">The column "employee_identification_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeIdentificationDetail.</returns>
        MixERP.Net.Entities.HRM.EmployeeIdentificationDetail Get(long employeeIdentificationDetailId);

        /// <summary>
        /// Gets the first record of EmployeeIdentificationDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeIdentificationDetail.</returns>
        MixERP.Net.Entities.HRM.EmployeeIdentificationDetail GetFirst();

        /// <summary>
        /// Gets the previous record of EmployeeIdentificationDetail sorted by employeeIdentificationDetailId. 
        /// </summary>
        /// <param name="employeeIdentificationDetailId">The column "employee_identification_detail_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeIdentificationDetail.</returns>
        MixERP.Net.Entities.HRM.EmployeeIdentificationDetail GetPrevious(long employeeIdentificationDetailId);

        /// <summary>
        /// Gets the next record of EmployeeIdentificationDetail sorted by employeeIdentificationDetailId. 
        /// </summary>
        /// <param name="employeeIdentificationDetailId">The column "employee_identification_detail_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeIdentificationDetail.</returns>
        MixERP.Net.Entities.HRM.EmployeeIdentificationDetail GetNext(long employeeIdentificationDetailId);

        /// <summary>
        /// Gets the last record of EmployeeIdentificationDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeIdentificationDetail.</returns>
        MixERP.Net.Entities.HRM.EmployeeIdentificationDetail GetLast();

        /// <summary>
        /// Returns multiple instances of the EmployeeIdentificationDetail against employeeIdentificationDetailIds. 
        /// </summary>
        /// <param name="employeeIdentificationDetailIds">Array of column "employee_identification_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of EmployeeIdentificationDetail.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> Get(long[] employeeIdentificationDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEmployeeIdentificationDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for EmployeeIdentificationDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding EmployeeIdentificationDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for EmployeeIdentificationDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of EmployeeIdentificationDetail class to IEmployeeIdentificationDetailRepository.
        /// </summary>
        /// <param name="employeeIdentificationDetail">The instance of EmployeeIdentificationDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic employeeIdentificationDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of EmployeeIdentificationDetail class to IEmployeeIdentificationDetailRepository.
        /// </summary>
        /// <param name="employeeIdentificationDetail">The instance of EmployeeIdentificationDetail class to insert.</param>
        object Add(dynamic employeeIdentificationDetail);

        /// <summary>
        /// Inserts or updates multiple instances of EmployeeIdentificationDetail class to IEmployeeIdentificationDetailRepository.;
        /// </summary>
        /// <param name="employeeIdentificationDetails">List of EmployeeIdentificationDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> employeeIdentificationDetails);


        /// <summary>
        /// Updates IEmployeeIdentificationDetailRepository with an instance of EmployeeIdentificationDetail class against the primary key value.
        /// </summary>
        /// <param name="employeeIdentificationDetail">The instance of EmployeeIdentificationDetail class to update.</param>
        /// <param name="employeeIdentificationDetailId">The value of the column "employee_identification_detail_id" which will be updated.</param>
        void Update(dynamic employeeIdentificationDetail, long employeeIdentificationDetailId);

        /// <summary>
        /// Deletes EmployeeIdentificationDetail from  IEmployeeIdentificationDetailRepository against the primary key value.
        /// </summary>
        /// <param name="employeeIdentificationDetailId">The value of the column "employee_identification_detail_id" which will be deleted.</param>
        void Delete(long employeeIdentificationDetailId);

        /// <summary>
        /// Produces a paginated result of 10 EmployeeIdentificationDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of EmployeeIdentificationDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 EmployeeIdentificationDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of EmployeeIdentificationDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeIdentificationDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of EmployeeIdentificationDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEmployeeIdentificationDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of EmployeeIdentificationDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeIdentificationDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of EmployeeIdentificationDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEmployeeIdentificationDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of EmployeeIdentificationDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetFiltered(long pageNumber, string filterName);



    }
}