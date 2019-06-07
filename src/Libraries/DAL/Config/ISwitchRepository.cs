// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface ISwitchRepository
    {
        /// <summary>
        /// Counts the number of Switch in ISwitchRepository.
        /// </summary>
        /// <returns>Returns the count of ISwitchRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Switch. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Switch.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Switch> GetAll();

        /// <summary>
        /// Returns all instances of Switch to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Switch.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Switch against key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Switch.</returns>
        MixERP.Net.Entities.Config.Switch Get(string key);

        /// <summary>
        /// Gets the first record of Switch.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Switch.</returns>
        MixERP.Net.Entities.Config.Switch GetFirst();

        /// <summary>
        /// Gets the previous record of Switch sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Switch.</returns>
        MixERP.Net.Entities.Config.Switch GetPrevious(string key);

        /// <summary>
        /// Gets the next record of Switch sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Switch.</returns>
        MixERP.Net.Entities.Config.Switch GetNext(string key);

        /// <summary>
        /// Gets the last record of Switch.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Switch.</returns>
        MixERP.Net.Entities.Config.Switch GetLast();

        /// <summary>
        /// Returns multiple instances of the Switch against keys. 
        /// </summary>
        /// <param name="keys">Array of column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Switch.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Switch> Get(string[] keys);

        /// <summary>
        /// Custom fields are user defined form elements for ISwitchRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Switch.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Switch.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Switch.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Switch class to ISwitchRepository.
        /// </summary>
        /// <param name="switchParameter">The instance of Switch class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic switchParameter, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Switch class to ISwitchRepository.
        /// </summary>
        /// <param name="switchParameter">The instance of Switch class to insert.</param>
        object Add(dynamic switchParameter);

        /// <summary>
        /// Inserts or updates multiple instances of Switch class to ISwitchRepository.;
        /// </summary>
        /// <param name="switches">List of Switch class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> switches);


        /// <summary>
        /// Updates ISwitchRepository with an instance of Switch class against the primary key value.
        /// </summary>
        /// <param name="switchParameter">The instance of Switch class to update.</param>
        /// <param name="key">The value of the column "key" which will be updated.</param>
        void Update(dynamic switchParameter, string key);

        /// <summary>
        /// Deletes Switch from  ISwitchRepository against the primary key value.
        /// </summary>
        /// <param name="key">The value of the column "key" which will be deleted.</param>
        void Delete(string key);

        /// <summary>
        /// Produces a paginated result of 10 Switch classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Switch class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Switch> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Switch classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Switch class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Switch> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISwitchRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Switch class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ISwitchRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Switch class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Switch> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISwitchRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Switch class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ISwitchRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Switch class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.Switch> GetFiltered(long pageNumber, string filterName);



    }
}