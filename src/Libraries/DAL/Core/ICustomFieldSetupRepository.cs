// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICustomFieldSetupRepository
    {
        /// <summary>
        /// Counts the number of CustomFieldSetup in ICustomFieldSetupRepository.
        /// </summary>
        /// <returns>Returns the count of ICustomFieldSetupRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CustomFieldSetup. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CustomFieldSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetAll();

        /// <summary>
        /// Returns all instances of CustomFieldSetup to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CustomFieldSetup.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CustomFieldSetup against customFieldSetupId. 
        /// </summary>
        /// <param name="customFieldSetupId">The column "custom_field_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CustomFieldSetup.</returns>
        MixERP.Net.Entities.Core.CustomFieldSetup Get(int customFieldSetupId);

        /// <summary>
        /// Gets the first record of CustomFieldSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CustomFieldSetup.</returns>
        MixERP.Net.Entities.Core.CustomFieldSetup GetFirst();

        /// <summary>
        /// Gets the previous record of CustomFieldSetup sorted by customFieldSetupId. 
        /// </summary>
        /// <param name="customFieldSetupId">The column "custom_field_setup_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CustomFieldSetup.</returns>
        MixERP.Net.Entities.Core.CustomFieldSetup GetPrevious(int customFieldSetupId);

        /// <summary>
        /// Gets the next record of CustomFieldSetup sorted by customFieldSetupId. 
        /// </summary>
        /// <param name="customFieldSetupId">The column "custom_field_setup_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CustomFieldSetup.</returns>
        MixERP.Net.Entities.Core.CustomFieldSetup GetNext(int customFieldSetupId);

        /// <summary>
        /// Gets the last record of CustomFieldSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CustomFieldSetup.</returns>
        MixERP.Net.Entities.Core.CustomFieldSetup GetLast();

        /// <summary>
        /// Returns multiple instances of the CustomFieldSetup against customFieldSetupIds. 
        /// </summary>
        /// <param name="customFieldSetupIds">Array of column "custom_field_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CustomFieldSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> Get(int[] customFieldSetupIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICustomFieldSetupRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CustomFieldSetup.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CustomFieldSetup.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CustomFieldSetup.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CustomFieldSetup class to ICustomFieldSetupRepository.
        /// </summary>
        /// <param name="customFieldSetup">The instance of CustomFieldSetup class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic customFieldSetup, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CustomFieldSetup class to ICustomFieldSetupRepository.
        /// </summary>
        /// <param name="customFieldSetup">The instance of CustomFieldSetup class to insert.</param>
        object Add(dynamic customFieldSetup);

        /// <summary>
        /// Inserts or updates multiple instances of CustomFieldSetup class to ICustomFieldSetupRepository.;
        /// </summary>
        /// <param name="customFieldSetups">List of CustomFieldSetup class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> customFieldSetups);


        /// <summary>
        /// Updates ICustomFieldSetupRepository with an instance of CustomFieldSetup class against the primary key value.
        /// </summary>
        /// <param name="customFieldSetup">The instance of CustomFieldSetup class to update.</param>
        /// <param name="customFieldSetupId">The value of the column "custom_field_setup_id" which will be updated.</param>
        void Update(dynamic customFieldSetup, int customFieldSetupId);

        /// <summary>
        /// Deletes CustomFieldSetup from  ICustomFieldSetupRepository against the primary key value.
        /// </summary>
        /// <param name="customFieldSetupId">The value of the column "custom_field_setup_id" which will be deleted.</param>
        void Delete(int customFieldSetupId);

        /// <summary>
        /// Produces a paginated result of 10 CustomFieldSetup classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CustomFieldSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CustomFieldSetup classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CustomFieldSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICustomFieldSetupRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CustomFieldSetup class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICustomFieldSetupRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CustomFieldSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICustomFieldSetupRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CustomFieldSetup class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICustomFieldSetupRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CustomFieldSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetFiltered(long pageNumber, string filterName);



    }
}