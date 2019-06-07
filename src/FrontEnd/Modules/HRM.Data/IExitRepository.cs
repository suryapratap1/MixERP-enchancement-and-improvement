// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IExitRepository
    {
        /// <summary>
        /// Counts the number of Exit in IExitRepository.
        /// </summary>
        /// <returns>Returns the count of IExitRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Exit. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Exit.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Exit> GetAll();

        /// <summary>
        /// Returns all instances of Exit to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Exit.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Exit against exitId. 
        /// </summary>
        /// <param name="exitId">The column "exit_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Exit.</returns>
        MixERP.Net.Entities.HRM.Exit Get(long exitId);

        /// <summary>
        /// Gets the first record of Exit.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Exit.</returns>
        MixERP.Net.Entities.HRM.Exit GetFirst();

        /// <summary>
        /// Gets the previous record of Exit sorted by exitId. 
        /// </summary>
        /// <param name="exitId">The column "exit_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Exit.</returns>
        MixERP.Net.Entities.HRM.Exit GetPrevious(long exitId);

        /// <summary>
        /// Gets the next record of Exit sorted by exitId. 
        /// </summary>
        /// <param name="exitId">The column "exit_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Exit.</returns>
        MixERP.Net.Entities.HRM.Exit GetNext(long exitId);

        /// <summary>
        /// Gets the last record of Exit.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Exit.</returns>
        MixERP.Net.Entities.HRM.Exit GetLast();

        /// <summary>
        /// Returns multiple instances of the Exit against exitIds. 
        /// </summary>
        /// <param name="exitIds">Array of column "exit_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Exit.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Exit> Get(long[] exitIds);

        /// <summary>
        /// Custom fields are user defined form elements for IExitRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Exit.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Exit.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Exit.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Exit class to IExitRepository.
        /// </summary>
        /// <param name="exit">The instance of Exit class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic exit, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Exit class to IExitRepository.
        /// </summary>
        /// <param name="exit">The instance of Exit class to insert.</param>
        object Add(dynamic exit);

        /// <summary>
        /// Inserts or updates multiple instances of Exit class to IExitRepository.;
        /// </summary>
        /// <param name="exits">List of Exit class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> exits);


        /// <summary>
        /// Updates IExitRepository with an instance of Exit class against the primary key value.
        /// </summary>
        /// <param name="exit">The instance of Exit class to update.</param>
        /// <param name="exitId">The value of the column "exit_id" which will be updated.</param>
        void Update(dynamic exit, long exitId);

        /// <summary>
        /// Deletes Exit from  IExitRepository against the primary key value.
        /// </summary>
        /// <param name="exitId">The value of the column "exit_id" which will be deleted.</param>
        void Delete(long exitId);

        /// <summary>
        /// Produces a paginated result of 10 Exit classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Exit class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Exit> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Exit classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Exit class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Exit> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IExitRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Exit class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IExitRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Exit class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Exit> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IExitRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Exit class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IExitRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Exit class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Exit> GetFiltered(long pageNumber, string filterName);


        void Verify(long exitId, short verificationStatusId, string reason);

    }
}