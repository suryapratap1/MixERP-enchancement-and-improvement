// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface IScrudFactoryRepository
    {
        /// <summary>
        /// Counts the number of ScrudFactory in IScrudFactoryRepository.
        /// </summary>
        /// <returns>Returns the count of IScrudFactoryRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ScrudFactory. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ScrudFactory.</returns>
        IEnumerable<MixERP.Net.Entities.Config.ScrudFactory> GetAll();

        /// <summary>
        /// Returns all instances of ScrudFactory to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ScrudFactory.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ScrudFactory against key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ScrudFactory.</returns>
        MixERP.Net.Entities.Config.ScrudFactory Get(string key);

        /// <summary>
        /// Gets the first record of ScrudFactory.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ScrudFactory.</returns>
        MixERP.Net.Entities.Config.ScrudFactory GetFirst();

        /// <summary>
        /// Gets the previous record of ScrudFactory sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ScrudFactory.</returns>
        MixERP.Net.Entities.Config.ScrudFactory GetPrevious(string key);

        /// <summary>
        /// Gets the next record of ScrudFactory sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ScrudFactory.</returns>
        MixERP.Net.Entities.Config.ScrudFactory GetNext(string key);

        /// <summary>
        /// Gets the last record of ScrudFactory.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ScrudFactory.</returns>
        MixERP.Net.Entities.Config.ScrudFactory GetLast();

        /// <summary>
        /// Returns multiple instances of the ScrudFactory against keys. 
        /// </summary>
        /// <param name="keys">Array of column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ScrudFactory.</returns>
        IEnumerable<MixERP.Net.Entities.Config.ScrudFactory> Get(string[] keys);

        /// <summary>
        /// Custom fields are user defined form elements for IScrudFactoryRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ScrudFactory.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ScrudFactory.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ScrudFactory.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ScrudFactory class to IScrudFactoryRepository.
        /// </summary>
        /// <param name="scrudFactory">The instance of ScrudFactory class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic scrudFactory, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ScrudFactory class to IScrudFactoryRepository.
        /// </summary>
        /// <param name="scrudFactory">The instance of ScrudFactory class to insert.</param>
        object Add(dynamic scrudFactory);

        /// <summary>
        /// Inserts or updates multiple instances of ScrudFactory class to IScrudFactoryRepository.;
        /// </summary>
        /// <param name="scrudFactories">List of ScrudFactory class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> scrudFactories);


        /// <summary>
        /// Updates IScrudFactoryRepository with an instance of ScrudFactory class against the primary key value.
        /// </summary>
        /// <param name="scrudFactory">The instance of ScrudFactory class to update.</param>
        /// <param name="key">The value of the column "key" which will be updated.</param>
        void Update(dynamic scrudFactory, string key);

        /// <summary>
        /// Deletes ScrudFactory from  IScrudFactoryRepository against the primary key value.
        /// </summary>
        /// <param name="key">The value of the column "key" which will be deleted.</param>
        void Delete(string key);

        /// <summary>
        /// Produces a paginated result of 10 ScrudFactory classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ScrudFactory class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.ScrudFactory> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ScrudFactory classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ScrudFactory class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.ScrudFactory> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IScrudFactoryRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ScrudFactory class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IScrudFactoryRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ScrudFactory class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.ScrudFactory> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IScrudFactoryRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ScrudFactory class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IScrudFactoryRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ScrudFactory class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.ScrudFactory> GetFiltered(long pageNumber, string filterName);



    }
}