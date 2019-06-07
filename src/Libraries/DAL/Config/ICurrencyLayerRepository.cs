// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface ICurrencyLayerRepository
    {
        /// <summary>
        /// Counts the number of CurrencyLayer in ICurrencyLayerRepository.
        /// </summary>
        /// <returns>Returns the count of ICurrencyLayerRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CurrencyLayer. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CurrencyLayer.</returns>
        IEnumerable<MixERP.Net.Entities.Config.CurrencyLayer> GetAll();

        /// <summary>
        /// Returns all instances of CurrencyLayer to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CurrencyLayer.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CurrencyLayer against key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CurrencyLayer.</returns>
        MixERP.Net.Entities.Config.CurrencyLayer Get(string key);

        /// <summary>
        /// Gets the first record of CurrencyLayer.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CurrencyLayer.</returns>
        MixERP.Net.Entities.Config.CurrencyLayer GetFirst();

        /// <summary>
        /// Gets the previous record of CurrencyLayer sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CurrencyLayer.</returns>
        MixERP.Net.Entities.Config.CurrencyLayer GetPrevious(string key);

        /// <summary>
        /// Gets the next record of CurrencyLayer sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CurrencyLayer.</returns>
        MixERP.Net.Entities.Config.CurrencyLayer GetNext(string key);

        /// <summary>
        /// Gets the last record of CurrencyLayer.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CurrencyLayer.</returns>
        MixERP.Net.Entities.Config.CurrencyLayer GetLast();

        /// <summary>
        /// Returns multiple instances of the CurrencyLayer against keys. 
        /// </summary>
        /// <param name="keys">Array of column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CurrencyLayer.</returns>
        IEnumerable<MixERP.Net.Entities.Config.CurrencyLayer> Get(string[] keys);

        /// <summary>
        /// Custom fields are user defined form elements for ICurrencyLayerRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CurrencyLayer.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CurrencyLayer.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CurrencyLayer.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CurrencyLayer class to ICurrencyLayerRepository.
        /// </summary>
        /// <param name="currencyLayer">The instance of CurrencyLayer class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic currencyLayer, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CurrencyLayer class to ICurrencyLayerRepository.
        /// </summary>
        /// <param name="currencyLayer">The instance of CurrencyLayer class to insert.</param>
        object Add(dynamic currencyLayer);

        /// <summary>
        /// Inserts or updates multiple instances of CurrencyLayer class to ICurrencyLayerRepository.;
        /// </summary>
        /// <param name="currencyLayers">List of CurrencyLayer class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> currencyLayers);


        /// <summary>
        /// Updates ICurrencyLayerRepository with an instance of CurrencyLayer class against the primary key value.
        /// </summary>
        /// <param name="currencyLayer">The instance of CurrencyLayer class to update.</param>
        /// <param name="key">The value of the column "key" which will be updated.</param>
        void Update(dynamic currencyLayer, string key);

        /// <summary>
        /// Deletes CurrencyLayer from  ICurrencyLayerRepository against the primary key value.
        /// </summary>
        /// <param name="key">The value of the column "key" which will be deleted.</param>
        void Delete(string key);

        /// <summary>
        /// Produces a paginated result of 10 CurrencyLayer classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CurrencyLayer class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.CurrencyLayer> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CurrencyLayer classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CurrencyLayer class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.CurrencyLayer> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICurrencyLayerRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CurrencyLayer class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICurrencyLayerRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CurrencyLayer class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.CurrencyLayer> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICurrencyLayerRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CurrencyLayer class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICurrencyLayerRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CurrencyLayer class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.CurrencyLayer> GetFiltered(long pageNumber, string filterName);



    }
}