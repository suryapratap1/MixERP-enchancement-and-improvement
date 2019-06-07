// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeSocialNetworkDetailRepository
    {
        /// <summary>
        /// Counts the number of EmployeeSocialNetworkDetail in IEmployeeSocialNetworkDetailRepository.
        /// </summary>
        /// <returns>Returns the count of IEmployeeSocialNetworkDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of EmployeeSocialNetworkDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmployeeSocialNetworkDetail.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetAll();

        /// <summary>
        /// Returns all instances of EmployeeSocialNetworkDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmployeeSocialNetworkDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the EmployeeSocialNetworkDetail against employeeSocialNetworkDetailId. 
        /// </summary>
        /// <param name="employeeSocialNetworkDetailId">The column "employee_social_network_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeSocialNetworkDetail.</returns>
        MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail Get(long employeeSocialNetworkDetailId);

        /// <summary>
        /// Gets the first record of EmployeeSocialNetworkDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeSocialNetworkDetail.</returns>
        MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail GetFirst();

        /// <summary>
        /// Gets the previous record of EmployeeSocialNetworkDetail sorted by employeeSocialNetworkDetailId. 
        /// </summary>
        /// <param name="employeeSocialNetworkDetailId">The column "employee_social_network_detail_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeSocialNetworkDetail.</returns>
        MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail GetPrevious(long employeeSocialNetworkDetailId);

        /// <summary>
        /// Gets the next record of EmployeeSocialNetworkDetail sorted by employeeSocialNetworkDetailId. 
        /// </summary>
        /// <param name="employeeSocialNetworkDetailId">The column "employee_social_network_detail_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeSocialNetworkDetail.</returns>
        MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail GetNext(long employeeSocialNetworkDetailId);

        /// <summary>
        /// Gets the last record of EmployeeSocialNetworkDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmployeeSocialNetworkDetail.</returns>
        MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail GetLast();

        /// <summary>
        /// Returns multiple instances of the EmployeeSocialNetworkDetail against employeeSocialNetworkDetailIds. 
        /// </summary>
        /// <param name="employeeSocialNetworkDetailIds">Array of column "employee_social_network_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of EmployeeSocialNetworkDetail.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> Get(long[] employeeSocialNetworkDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEmployeeSocialNetworkDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for EmployeeSocialNetworkDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding EmployeeSocialNetworkDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for EmployeeSocialNetworkDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of EmployeeSocialNetworkDetail class to IEmployeeSocialNetworkDetailRepository.
        /// </summary>
        /// <param name="employeeSocialNetworkDetail">The instance of EmployeeSocialNetworkDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic employeeSocialNetworkDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of EmployeeSocialNetworkDetail class to IEmployeeSocialNetworkDetailRepository.
        /// </summary>
        /// <param name="employeeSocialNetworkDetail">The instance of EmployeeSocialNetworkDetail class to insert.</param>
        object Add(dynamic employeeSocialNetworkDetail);

        /// <summary>
        /// Inserts or updates multiple instances of EmployeeSocialNetworkDetail class to IEmployeeSocialNetworkDetailRepository.;
        /// </summary>
        /// <param name="employeeSocialNetworkDetails">List of EmployeeSocialNetworkDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> employeeSocialNetworkDetails);


        /// <summary>
        /// Updates IEmployeeSocialNetworkDetailRepository with an instance of EmployeeSocialNetworkDetail class against the primary key value.
        /// </summary>
        /// <param name="employeeSocialNetworkDetail">The instance of EmployeeSocialNetworkDetail class to update.</param>
        /// <param name="employeeSocialNetworkDetailId">The value of the column "employee_social_network_detail_id" which will be updated.</param>
        void Update(dynamic employeeSocialNetworkDetail, long employeeSocialNetworkDetailId);

        /// <summary>
        /// Deletes EmployeeSocialNetworkDetail from  IEmployeeSocialNetworkDetailRepository against the primary key value.
        /// </summary>
        /// <param name="employeeSocialNetworkDetailId">The value of the column "employee_social_network_detail_id" which will be deleted.</param>
        void Delete(long employeeSocialNetworkDetailId);

        /// <summary>
        /// Produces a paginated result of 10 EmployeeSocialNetworkDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of EmployeeSocialNetworkDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 EmployeeSocialNetworkDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of EmployeeSocialNetworkDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeSocialNetworkDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of EmployeeSocialNetworkDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEmployeeSocialNetworkDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of EmployeeSocialNetworkDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeSocialNetworkDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of EmployeeSocialNetworkDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEmployeeSocialNetworkDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of EmployeeSocialNetworkDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetFiltered(long pageNumber, string filterName);



    }
}