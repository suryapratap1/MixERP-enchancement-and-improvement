// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmploymentStatusCodeRepository
    {
        /// <summary>
        /// Counts the number of EmploymentStatusCode in IEmploymentStatusCodeRepository.
        /// </summary>
        /// <returns>Returns the count of IEmploymentStatusCodeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of EmploymentStatusCode. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmploymentStatusCode.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetAll();

        /// <summary>
        /// Returns all instances of EmploymentStatusCode to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmploymentStatusCode.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the EmploymentStatusCode against employmentStatusCodeId. 
        /// </summary>
        /// <param name="employmentStatusCodeId">The column "employment_status_code_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmploymentStatusCode.</returns>
        MixERP.Net.Entities.HRM.EmploymentStatusCode Get(int employmentStatusCodeId);

        /// <summary>
        /// Gets the first record of EmploymentStatusCode.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmploymentStatusCode.</returns>
        MixERP.Net.Entities.HRM.EmploymentStatusCode GetFirst();

        /// <summary>
        /// Gets the previous record of EmploymentStatusCode sorted by employmentStatusCodeId. 
        /// </summary>
        /// <param name="employmentStatusCodeId">The column "employment_status_code_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmploymentStatusCode.</returns>
        MixERP.Net.Entities.HRM.EmploymentStatusCode GetPrevious(int employmentStatusCodeId);

        /// <summary>
        /// Gets the next record of EmploymentStatusCode sorted by employmentStatusCodeId. 
        /// </summary>
        /// <param name="employmentStatusCodeId">The column "employment_status_code_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmploymentStatusCode.</returns>
        MixERP.Net.Entities.HRM.EmploymentStatusCode GetNext(int employmentStatusCodeId);

        /// <summary>
        /// Gets the last record of EmploymentStatusCode.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmploymentStatusCode.</returns>
        MixERP.Net.Entities.HRM.EmploymentStatusCode GetLast();

        /// <summary>
        /// Returns multiple instances of the EmploymentStatusCode against employmentStatusCodeIds. 
        /// </summary>
        /// <param name="employmentStatusCodeIds">Array of column "employment_status_code_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of EmploymentStatusCode.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> Get(int[] employmentStatusCodeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEmploymentStatusCodeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for EmploymentStatusCode.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding EmploymentStatusCode.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for EmploymentStatusCode.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of EmploymentStatusCode class to IEmploymentStatusCodeRepository.
        /// </summary>
        /// <param name="employmentStatusCode">The instance of EmploymentStatusCode class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic employmentStatusCode, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of EmploymentStatusCode class to IEmploymentStatusCodeRepository.
        /// </summary>
        /// <param name="employmentStatusCode">The instance of EmploymentStatusCode class to insert.</param>
        object Add(dynamic employmentStatusCode);

        /// <summary>
        /// Inserts or updates multiple instances of EmploymentStatusCode class to IEmploymentStatusCodeRepository.;
        /// </summary>
        /// <param name="employmentStatusCodes">List of EmploymentStatusCode class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> employmentStatusCodes);


        /// <summary>
        /// Updates IEmploymentStatusCodeRepository with an instance of EmploymentStatusCode class against the primary key value.
        /// </summary>
        /// <param name="employmentStatusCode">The instance of EmploymentStatusCode class to update.</param>
        /// <param name="employmentStatusCodeId">The value of the column "employment_status_code_id" which will be updated.</param>
        void Update(dynamic employmentStatusCode, int employmentStatusCodeId);

        /// <summary>
        /// Deletes EmploymentStatusCode from  IEmploymentStatusCodeRepository against the primary key value.
        /// </summary>
        /// <param name="employmentStatusCodeId">The value of the column "employment_status_code_id" which will be deleted.</param>
        void Delete(int employmentStatusCodeId);

        /// <summary>
        /// Produces a paginated result of 10 EmploymentStatusCode classes.
        /// </summary>
        /// <returns>Returns the first page of collection of EmploymentStatusCode class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 EmploymentStatusCode classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of EmploymentStatusCode class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmploymentStatusCodeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of EmploymentStatusCode class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEmploymentStatusCodeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of EmploymentStatusCode class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmploymentStatusCodeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of EmploymentStatusCode class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEmploymentStatusCodeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of EmploymentStatusCode class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetFiltered(long pageNumber, string filterName);



    }
}