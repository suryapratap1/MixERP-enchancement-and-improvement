// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IConfigurationRepository
    {
        /// <summary>
        /// Counts the number of Configuration in IConfigurationRepository.
        /// </summary>
        /// <returns>Returns the count of IConfigurationRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Configuration. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Configuration.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Configuration> GetAll();

        /// <summary>
        /// Returns all instances of Configuration to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Configuration.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Configuration against configurationId. 
        /// </summary>
        /// <param name="configurationId">The column "configuration_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Configuration.</returns>
        MixERP.Net.Entities.Office.Configuration Get(int configurationId);

        /// <summary>
        /// Gets the first record of Configuration.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Configuration.</returns>
        MixERP.Net.Entities.Office.Configuration GetFirst();

        /// <summary>
        /// Gets the previous record of Configuration sorted by configurationId. 
        /// </summary>
        /// <param name="configurationId">The column "configuration_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Configuration.</returns>
        MixERP.Net.Entities.Office.Configuration GetPrevious(int configurationId);

        /// <summary>
        /// Gets the next record of Configuration sorted by configurationId. 
        /// </summary>
        /// <param name="configurationId">The column "configuration_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Configuration.</returns>
        MixERP.Net.Entities.Office.Configuration GetNext(int configurationId);

        /// <summary>
        /// Gets the last record of Configuration.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Configuration.</returns>
        MixERP.Net.Entities.Office.Configuration GetLast();

        /// <summary>
        /// Returns multiple instances of the Configuration against configurationIds. 
        /// </summary>
        /// <param name="configurationIds">Array of column "configuration_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Configuration.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Configuration> Get(int[] configurationIds);

        /// <summary>
        /// Custom fields are user defined form elements for IConfigurationRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Configuration.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Configuration.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Configuration.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Configuration class to IConfigurationRepository.
        /// </summary>
        /// <param name="configuration">The instance of Configuration class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic configuration, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Configuration class to IConfigurationRepository.
        /// </summary>
        /// <param name="configuration">The instance of Configuration class to insert.</param>
        object Add(dynamic configuration);

        /// <summary>
        /// Inserts or updates multiple instances of Configuration class to IConfigurationRepository.;
        /// </summary>
        /// <param name="configurations">List of Configuration class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> configurations);


        /// <summary>
        /// Updates IConfigurationRepository with an instance of Configuration class against the primary key value.
        /// </summary>
        /// <param name="configuration">The instance of Configuration class to update.</param>
        /// <param name="configurationId">The value of the column "configuration_id" which will be updated.</param>
        void Update(dynamic configuration, int configurationId);

        /// <summary>
        /// Deletes Configuration from  IConfigurationRepository against the primary key value.
        /// </summary>
        /// <param name="configurationId">The value of the column "configuration_id" which will be deleted.</param>
        void Delete(int configurationId);

        /// <summary>
        /// Produces a paginated result of 10 Configuration classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Configuration class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Configuration> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Configuration classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Configuration class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Configuration> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IConfigurationRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Configuration class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IConfigurationRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Configuration class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Configuration> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IConfigurationRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Configuration class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IConfigurationRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Configuration class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Configuration> GetFiltered(long pageNumber, string filterName);



    }
}