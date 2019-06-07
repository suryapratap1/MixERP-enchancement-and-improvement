// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IResignationRepository
    {
        /// <summary>
        /// Counts the number of Resignation in IResignationRepository.
        /// </summary>
        /// <returns>Returns the count of IResignationRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Resignation. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Resignation.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Resignation> GetAll();

        /// <summary>
        /// Returns all instances of Resignation to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Resignation.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Resignation against resignationId. 
        /// </summary>
        /// <param name="resignationId">The column "resignation_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Resignation.</returns>
        MixERP.Net.Entities.HRM.Resignation Get(int resignationId);

        /// <summary>
        /// Gets the first record of Resignation.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Resignation.</returns>
        MixERP.Net.Entities.HRM.Resignation GetFirst();

        /// <summary>
        /// Gets the previous record of Resignation sorted by resignationId. 
        /// </summary>
        /// <param name="resignationId">The column "resignation_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Resignation.</returns>
        MixERP.Net.Entities.HRM.Resignation GetPrevious(int resignationId);

        /// <summary>
        /// Gets the next record of Resignation sorted by resignationId. 
        /// </summary>
        /// <param name="resignationId">The column "resignation_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Resignation.</returns>
        MixERP.Net.Entities.HRM.Resignation GetNext(int resignationId);

        /// <summary>
        /// Gets the last record of Resignation.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Resignation.</returns>
        MixERP.Net.Entities.HRM.Resignation GetLast();

        /// <summary>
        /// Returns multiple instances of the Resignation against resignationIds. 
        /// </summary>
        /// <param name="resignationIds">Array of column "resignation_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Resignation.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Resignation> Get(int[] resignationIds);

        /// <summary>
        /// Custom fields are user defined form elements for IResignationRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Resignation.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Resignation.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Resignation.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Resignation class to IResignationRepository.
        /// </summary>
        /// <param name="resignation">The instance of Resignation class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic resignation, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Resignation class to IResignationRepository.
        /// </summary>
        /// <param name="resignation">The instance of Resignation class to insert.</param>
        object Add(dynamic resignation);

        /// <summary>
        /// Inserts or updates multiple instances of Resignation class to IResignationRepository.;
        /// </summary>
        /// <param name="resignations">List of Resignation class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> resignations);


        /// <summary>
        /// Updates IResignationRepository with an instance of Resignation class against the primary key value.
        /// </summary>
        /// <param name="resignation">The instance of Resignation class to update.</param>
        /// <param name="resignationId">The value of the column "resignation_id" which will be updated.</param>
        void Update(dynamic resignation, int resignationId);

        /// <summary>
        /// Deletes Resignation from  IResignationRepository against the primary key value.
        /// </summary>
        /// <param name="resignationId">The value of the column "resignation_id" which will be deleted.</param>
        void Delete(int resignationId);

        /// <summary>
        /// Produces a paginated result of 10 Resignation classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Resignation class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Resignation> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Resignation classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Resignation class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Resignation> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IResignationRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Resignation class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IResignationRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Resignation class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Resignation> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IResignationRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Resignation class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IResignationRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Resignation class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.Resignation> GetFiltered(long pageNumber, string filterName);


        void Verify(int resignationId, short verificationStatusId, string reason);

    }
}