// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface IMixerpRepository
    {
        /// <summary>
        /// Counts the number of Mixerp in IMixerpRepository.
        /// </summary>
        /// <returns>Returns the count of IMixerpRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Mixerp. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Mixerp.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Mixerp> GetAll();

        /// <summary>
        /// Returns all instances of Mixerp to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Mixerp.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Mixerp against key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Mixerp.</returns>
        MixERP.Net.Entities.Config.Mixerp Get(string key);

        /// <summary>
        /// Gets the first record of Mixerp.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Mixerp.</returns>
        MixERP.Net.Entities.Config.Mixerp GetFirst();

        /// <summary>
        /// Gets the previous record of Mixerp sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Mixerp.</returns>
        MixERP.Net.Entities.Config.Mixerp GetPrevious(string key);

        /// <summary>
        /// Gets the next record of Mixerp sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Mixerp.</returns>
        MixERP.Net.Entities.Config.Mixerp GetNext(string key);

        /// <summary>
        /// Gets the last record of Mixerp.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Mixerp.</returns>
        MixERP.Net.Entities.Config.Mixerp GetLast();

        /// <summary>
        /// Returns multiple instances of the Mixerp against keys. 
        /// </summary>
        /// <param name="keys">Array of column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Mixerp.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Mixerp> Get(string[] keys);

        /// <summary>
        /// Custom fields are user defined form elements for IMixerpRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Mixerp.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Mixerp.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Mixerp.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Mixerp class to IMixerpRepository.
        /// </summary>
        /// <param name="mixerp">The instance of Mixerp class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic mixerp, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Mixerp class to IMixerpRepository.
        /// </summary>
        /// <param name="mixerp">The instance of Mixerp class to insert.</param>
        object Add(dynamic mixerp);

        /// <summary>
        /// Inserts or updates multiple instances of Mixerp class to IMixerpRepository.;
        /// </summary>
        /// <param name="mixerps">List of Mixerp class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> mixerps);


        /// <summary>
        /// Updates IMixerpRepository with an instance of Mixerp class against the primary key value.
        /// </summary>
        /// <param name="mixerp">The instance of Mixerp class to update.</param>
        /// <param name="key">The value of the column "key" which will be updated.</param>
        void Update(dynamic mixerp, string key);

        /// <summary>
        /// Deletes Mixerp from  IMixerpRepository against the primary key value.
        /// </summary>
        /// <param name="key">The value of the column "key" which will be deleted.</param>
        void Delete(string key);

        /// <summary>
        /// Produces a paginated result of 10 Mixerp classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Mixerp class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Mixerp> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Mixerp classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Mixerp class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Mixerp> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IMixerpRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Mixerp class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IMixerpRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Mixerp class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Mixerp> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IMixerpRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Mixerp class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IMixerpRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Mixerp class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Mixerp> GetFiltered(long pageNumber, string filterName);



    }
}