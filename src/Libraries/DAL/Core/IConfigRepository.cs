// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IConfigRepository
    {
        /// <summary>
        /// Counts the number of Config in IConfigRepository.
        /// </summary>
        /// <returns>Returns the count of IConfigRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Config. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Config.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Config> GetAll();

        /// <summary>
        /// Returns all instances of Config to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Config.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Config against configId. 
        /// </summary>
        /// <param name="configId">The column "config_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Config.</returns>
        MixERP.Net.Entities.Core.Config Get(int configId);

        /// <summary>
        /// Gets the first record of Config.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Config.</returns>
        MixERP.Net.Entities.Core.Config GetFirst();

        /// <summary>
        /// Gets the previous record of Config sorted by configId. 
        /// </summary>
        /// <param name="configId">The column "config_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Config.</returns>
        MixERP.Net.Entities.Core.Config GetPrevious(int configId);

        /// <summary>
        /// Gets the next record of Config sorted by configId. 
        /// </summary>
        /// <param name="configId">The column "config_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Config.</returns>
        MixERP.Net.Entities.Core.Config GetNext(int configId);

        /// <summary>
        /// Gets the last record of Config.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Config.</returns>
        MixERP.Net.Entities.Core.Config GetLast();

        /// <summary>
        /// Returns multiple instances of the Config against configIds. 
        /// </summary>
        /// <param name="configIds">Array of column "config_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Config.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Config> Get(int[] configIds);

        /// <summary>
        /// Custom fields are user defined form elements for IConfigRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Config.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Config.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Config.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Config class to IConfigRepository.
        /// </summary>
        /// <param name="config">The instance of Config class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic config, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Config class to IConfigRepository.
        /// </summary>
        /// <param name="config">The instance of Config class to insert.</param>
        object Add(dynamic config);

        /// <summary>
        /// Inserts or updates multiple instances of Config class to IConfigRepository.;
        /// </summary>
        /// <param name="configs">List of Config class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> configs);


        /// <summary>
        /// Updates IConfigRepository with an instance of Config class against the primary key value.
        /// </summary>
        /// <param name="config">The instance of Config class to update.</param>
        /// <param name="configId">The value of the column "config_id" which will be updated.</param>
        void Update(dynamic config, int configId);

        /// <summary>
        /// Deletes Config from  IConfigRepository against the primary key value.
        /// </summary>
        /// <param name="configId">The value of the column "config_id" which will be deleted.</param>
        void Delete(int configId);

        /// <summary>
        /// Produces a paginated result of 10 Config classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Config class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Config> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Config classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Config class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Config> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IConfigRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Config class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IConfigRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Config class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Config> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IConfigRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Config class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IConfigRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Config class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Config> GetFiltered(long pageNumber, string filterName);



    }
}