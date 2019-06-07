// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmploymentStatusRepository
    {
        /// <summary>
        /// Counts the number of EmploymentStatus in IEmploymentStatusRepository.
        /// </summary>
        /// <returns>Returns the count of IEmploymentStatusRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of EmploymentStatus. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmploymentStatus.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetAll();

        /// <summary>
        /// Returns all instances of EmploymentStatus to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of EmploymentStatus.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the EmploymentStatus against employmentStatusId. 
        /// </summary>
        /// <param name="employmentStatusId">The column "employment_status_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmploymentStatus.</returns>
        MixERP.Net.Entities.HRM.EmploymentStatus Get(int employmentStatusId);

        /// <summary>
        /// Gets the first record of EmploymentStatus.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmploymentStatus.</returns>
        MixERP.Net.Entities.HRM.EmploymentStatus GetFirst();

        /// <summary>
        /// Gets the previous record of EmploymentStatus sorted by employmentStatusId. 
        /// </summary>
        /// <param name="employmentStatusId">The column "employment_status_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmploymentStatus.</returns>
        MixERP.Net.Entities.HRM.EmploymentStatus GetPrevious(int employmentStatusId);

        /// <summary>
        /// Gets the next record of EmploymentStatus sorted by employmentStatusId. 
        /// </summary>
        /// <param name="employmentStatusId">The column "employment_status_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of EmploymentStatus.</returns>
        MixERP.Net.Entities.HRM.EmploymentStatus GetNext(int employmentStatusId);

        /// <summary>
        /// Gets the last record of EmploymentStatus.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of EmploymentStatus.</returns>
        MixERP.Net.Entities.HRM.EmploymentStatus GetLast();

        /// <summary>
        /// Returns multiple instances of the EmploymentStatus against employmentStatusIds. 
        /// </summary>
        /// <param name="employmentStatusIds">Array of column "employment_status_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of EmploymentStatus.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> Get(int[] employmentStatusIds);

        /// <summary>
        /// Custom fields are user defined form elements for IEmploymentStatusRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for EmploymentStatus.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding EmploymentStatus.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for EmploymentStatus.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of EmploymentStatus class to IEmploymentStatusRepository.
        /// </summary>
        /// <param name="employmentStatus">The instance of EmploymentStatus class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic employmentStatus, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of EmploymentStatus class to IEmploymentStatusRepository.
        /// </summary>
        /// <param name="employmentStatus">The instance of EmploymentStatus class to insert.</param>
        object Add(dynamic employmentStatus);

        /// <summary>
        /// Inserts or updates multiple instances of EmploymentStatus class to IEmploymentStatusRepository.;
        /// </summary>
        /// <param name="employmentStatuses">List of EmploymentStatus class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> employmentStatuses);


        /// <summary>
        /// Updates IEmploymentStatusRepository with an instance of EmploymentStatus class against the primary key value.
        /// </summary>
        /// <param name="employmentStatus">The instance of EmploymentStatus class to update.</param>
        /// <param name="employmentStatusId">The value of the column "employment_status_id" which will be updated.</param>
        void Update(dynamic employmentStatus, int employmentStatusId);

        /// <summary>
        /// Deletes EmploymentStatus from  IEmploymentStatusRepository against the primary key value.
        /// </summary>
        /// <param name="employmentStatusId">The value of the column "employment_status_id" which will be deleted.</param>
        void Delete(int employmentStatusId);

        /// <summary>
        /// Produces a paginated result of 10 EmploymentStatus classes.
        /// </summary>
        /// <returns>Returns the first page of collection of EmploymentStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 EmploymentStatus classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of EmploymentStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmploymentStatusRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of EmploymentStatus class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IEmploymentStatusRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of EmploymentStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmploymentStatusRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of EmploymentStatus class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IEmploymentStatusRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of EmploymentStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetFiltered(long pageNumber, string filterName);



    }
}