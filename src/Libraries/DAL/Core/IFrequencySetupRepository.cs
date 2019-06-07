// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IFrequencySetupRepository
    {
        /// <summary>
        /// Counts the number of FrequencySetup in IFrequencySetupRepository.
        /// </summary>
        /// <returns>Returns the count of IFrequencySetupRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of FrequencySetup. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of FrequencySetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetAll();

        /// <summary>
        /// Returns all instances of FrequencySetup to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of FrequencySetup.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the FrequencySetup against frequencySetupId. 
        /// </summary>
        /// <param name="frequencySetupId">The column "frequency_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of FrequencySetup.</returns>
        MixERP.Net.Entities.Core.FrequencySetup Get(int frequencySetupId);

        /// <summary>
        /// Gets the first record of FrequencySetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of FrequencySetup.</returns>
        MixERP.Net.Entities.Core.FrequencySetup GetFirst();

        /// <summary>
        /// Gets the previous record of FrequencySetup sorted by frequencySetupId. 
        /// </summary>
        /// <param name="frequencySetupId">The column "frequency_setup_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of FrequencySetup.</returns>
        MixERP.Net.Entities.Core.FrequencySetup GetPrevious(int frequencySetupId);

        /// <summary>
        /// Gets the next record of FrequencySetup sorted by frequencySetupId. 
        /// </summary>
        /// <param name="frequencySetupId">The column "frequency_setup_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of FrequencySetup.</returns>
        MixERP.Net.Entities.Core.FrequencySetup GetNext(int frequencySetupId);

        /// <summary>
        /// Gets the last record of FrequencySetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of FrequencySetup.</returns>
        MixERP.Net.Entities.Core.FrequencySetup GetLast();

        /// <summary>
        /// Returns multiple instances of the FrequencySetup against frequencySetupIds. 
        /// </summary>
        /// <param name="frequencySetupIds">Array of column "frequency_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of FrequencySetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> Get(int[] frequencySetupIds);

        /// <summary>
        /// Custom fields are user defined form elements for IFrequencySetupRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for FrequencySetup.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding FrequencySetup.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for FrequencySetup.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of FrequencySetup class to IFrequencySetupRepository.
        /// </summary>
        /// <param name="frequencySetup">The instance of FrequencySetup class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic frequencySetup, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of FrequencySetup class to IFrequencySetupRepository.
        /// </summary>
        /// <param name="frequencySetup">The instance of FrequencySetup class to insert.</param>
        object Add(dynamic frequencySetup);

        /// <summary>
        /// Inserts or updates multiple instances of FrequencySetup class to IFrequencySetupRepository.;
        /// </summary>
        /// <param name="frequencySetups">List of FrequencySetup class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> frequencySetups);


        /// <summary>
        /// Updates IFrequencySetupRepository with an instance of FrequencySetup class against the primary key value.
        /// </summary>
        /// <param name="frequencySetup">The instance of FrequencySetup class to update.</param>
        /// <param name="frequencySetupId">The value of the column "frequency_setup_id" which will be updated.</param>
        void Update(dynamic frequencySetup, int frequencySetupId);

        /// <summary>
        /// Deletes FrequencySetup from  IFrequencySetupRepository against the primary key value.
        /// </summary>
        /// <param name="frequencySetupId">The value of the column "frequency_setup_id" which will be deleted.</param>
        void Delete(int frequencySetupId);

        /// <summary>
        /// Produces a paginated result of 10 FrequencySetup classes.
        /// </summary>
        /// <returns>Returns the first page of collection of FrequencySetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 FrequencySetup classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of FrequencySetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFrequencySetupRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of FrequencySetup class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IFrequencySetupRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of FrequencySetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFrequencySetupRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of FrequencySetup class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IFrequencySetupRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of FrequencySetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FrequencySetup> GetFiltered(long pageNumber, string filterName);



    }
}