// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface ITerminationRepository
    {
        /// <summary>
        /// Counts the number of Termination in ITerminationRepository.
        /// </summary>
        /// <returns>Returns the count of ITerminationRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Termination. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Termination.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Termination> GetAll();

        /// <summary>
        /// Returns all instances of Termination to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Termination.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Termination against terminationId. 
        /// </summary>
        /// <param name="terminationId">The column "termination_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Termination.</returns>
        MixERP.Net.Entities.HRM.Termination Get(int terminationId);

        /// <summary>
        /// Gets the first record of Termination.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Termination.</returns>
        MixERP.Net.Entities.HRM.Termination GetFirst();

        /// <summary>
        /// Gets the previous record of Termination sorted by terminationId. 
        /// </summary>
        /// <param name="terminationId">The column "termination_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Termination.</returns>
        MixERP.Net.Entities.HRM.Termination GetPrevious(int terminationId);

        /// <summary>
        /// Gets the next record of Termination sorted by terminationId. 
        /// </summary>
        /// <param name="terminationId">The column "termination_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Termination.</returns>
        MixERP.Net.Entities.HRM.Termination GetNext(int terminationId);

        /// <summary>
        /// Gets the last record of Termination.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Termination.</returns>
        MixERP.Net.Entities.HRM.Termination GetLast();

        /// <summary>
        /// Returns multiple instances of the Termination against terminationIds. 
        /// </summary>
        /// <param name="terminationIds">Array of column "termination_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Termination.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Termination> Get(int[] terminationIds);

        /// <summary>
        /// Custom fields are user defined form elements for ITerminationRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Termination.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Termination.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Termination.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Termination class to ITerminationRepository.
        /// </summary>
        /// <param name="termination">The instance of Termination class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic termination, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Termination class to ITerminationRepository.
        /// </summary>
        /// <param name="termination">The instance of Termination class to insert.</param>
        object Add(dynamic termination);

        /// <summary>
        /// Inserts or updates multiple instances of Termination class to ITerminationRepository.;
        /// </summary>
        /// <param name="terminations">List of Termination class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> terminations);


        /// <summary>
        /// Updates ITerminationRepository with an instance of Termination class against the primary key value.
        /// </summary>
        /// <param name="termination">The instance of Termination class to update.</param>
        /// <param name="terminationId">The value of the column "termination_id" which will be updated.</param>
        void Update(dynamic termination, int terminationId);

        /// <summary>
        /// Deletes Termination from  ITerminationRepository against the primary key value.
        /// </summary>
        /// <param name="terminationId">The value of the column "termination_id" which will be deleted.</param>
        void Delete(int terminationId);

        /// <summary>
        /// Produces a paginated result of 10 Termination classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Termination class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Termination> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Termination classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Termination class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Termination> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITerminationRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Termination class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ITerminationRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Termination class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Termination> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITerminationRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Termination class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ITerminationRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Termination class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Termination> GetFiltered(long pageNumber, string filterName);


        void Verify(int terminationId, short verificationStatusId, string reason);

    }
}