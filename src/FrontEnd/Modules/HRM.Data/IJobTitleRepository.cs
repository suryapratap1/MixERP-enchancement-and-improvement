// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IJobTitleRepository
    {
        /// <summary>
        /// Counts the number of JobTitle in IJobTitleRepository.
        /// </summary>
        /// <returns>Returns the count of IJobTitleRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of JobTitle. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of JobTitle.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.JobTitle> GetAll();

        /// <summary>
        /// Returns all instances of JobTitle to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of JobTitle.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the JobTitle against jobTitleId. 
        /// </summary>
        /// <param name="jobTitleId">The column "job_title_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of JobTitle.</returns>
        MixERP.Net.Entities.HRM.JobTitle Get(int jobTitleId);

        /// <summary>
        /// Gets the first record of JobTitle.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of JobTitle.</returns>
        MixERP.Net.Entities.HRM.JobTitle GetFirst();

        /// <summary>
        /// Gets the previous record of JobTitle sorted by jobTitleId. 
        /// </summary>
        /// <param name="jobTitleId">The column "job_title_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of JobTitle.</returns>
        MixERP.Net.Entities.HRM.JobTitle GetPrevious(int jobTitleId);

        /// <summary>
        /// Gets the next record of JobTitle sorted by jobTitleId. 
        /// </summary>
        /// <param name="jobTitleId">The column "job_title_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of JobTitle.</returns>
        MixERP.Net.Entities.HRM.JobTitle GetNext(int jobTitleId);

        /// <summary>
        /// Gets the last record of JobTitle.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of JobTitle.</returns>
        MixERP.Net.Entities.HRM.JobTitle GetLast();

        /// <summary>
        /// Returns multiple instances of the JobTitle against jobTitleIds. 
        /// </summary>
        /// <param name="jobTitleIds">Array of column "job_title_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of JobTitle.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.JobTitle> Get(int[] jobTitleIds);

        /// <summary>
        /// Custom fields are user defined form elements for IJobTitleRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for JobTitle.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding JobTitle.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for JobTitle.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of JobTitle class to IJobTitleRepository.
        /// </summary>
        /// <param name="jobTitle">The instance of JobTitle class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic jobTitle, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of JobTitle class to IJobTitleRepository.
        /// </summary>
        /// <param name="jobTitle">The instance of JobTitle class to insert.</param>
        object Add(dynamic jobTitle);

        /// <summary>
        /// Inserts or updates multiple instances of JobTitle class to IJobTitleRepository.;
        /// </summary>
        /// <param name="jobTitles">List of JobTitle class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> jobTitles);


        /// <summary>
        /// Updates IJobTitleRepository with an instance of JobTitle class against the primary key value.
        /// </summary>
        /// <param name="jobTitle">The instance of JobTitle class to update.</param>
        /// <param name="jobTitleId">The value of the column "job_title_id" which will be updated.</param>
        void Update(dynamic jobTitle, int jobTitleId);

        /// <summary>
        /// Deletes JobTitle from  IJobTitleRepository against the primary key value.
        /// </summary>
        /// <param name="jobTitleId">The value of the column "job_title_id" which will be deleted.</param>
        void Delete(int jobTitleId);

        /// <summary>
        /// Produces a paginated result of 10 JobTitle classes.
        /// </summary>
        /// <returns>Returns the first page of collection of JobTitle class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.JobTitle> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 JobTitle classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of JobTitle class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.JobTitle> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IJobTitleRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of JobTitle class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IJobTitleRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of JobTitle class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.JobTitle> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IJobTitleRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of JobTitle class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IJobTitleRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of JobTitle class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.JobTitle> GetFiltered(long pageNumber, string filterName);



    }
}