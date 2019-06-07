// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface IDbParameterRepository
    {
        /// <summary>
        /// Counts the number of DbParameter in IDbParameterRepository.
        /// </summary>
        /// <returns>Returns the count of IDbParameterRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of DbParameter. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of DbParameter.</returns>
        IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetAll();

        /// <summary>
        /// Returns all instances of DbParameter to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of DbParameter.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the DbParameter against key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of DbParameter.</returns>
        MixERP.Net.Entities.Config.DbParameter Get(string key);

        /// <summary>
        /// Gets the first record of DbParameter.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of DbParameter.</returns>
        MixERP.Net.Entities.Config.DbParameter GetFirst();

        /// <summary>
        /// Gets the previous record of DbParameter sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of DbParameter.</returns>
        MixERP.Net.Entities.Config.DbParameter GetPrevious(string key);

        /// <summary>
        /// Gets the next record of DbParameter sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of DbParameter.</returns>
        MixERP.Net.Entities.Config.DbParameter GetNext(string key);

        /// <summary>
        /// Gets the last record of DbParameter.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of DbParameter.</returns>
        MixERP.Net.Entities.Config.DbParameter GetLast();

        /// <summary>
        /// Returns multiple instances of the DbParameter against keys. 
        /// </summary>
        /// <param name="keys">Array of column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of DbParameter.</returns>
        IEnumerable<MixERP.Net.Entities.Config.DbParameter> Get(string[] keys);

        /// <summary>
        /// Custom fields are user defined form elements for IDbParameterRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for DbParameter.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding DbParameter.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for DbParameter.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of DbParameter class to IDbParameterRepository.
        /// </summary>
        /// <param name="dbParameter">The instance of DbParameter class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic dbParameter, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of DbParameter class to IDbParameterRepository.
        /// </summary>
        /// <param name="dbParameter">The instance of DbParameter class to insert.</param>
        object Add(dynamic dbParameter);

        /// <summary>
        /// Inserts or updates multiple instances of DbParameter class to IDbParameterRepository.;
        /// </summary>
        /// <param name="dbParameters">List of DbParameter class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> dbParameters);


        /// <summary>
        /// Updates IDbParameterRepository with an instance of DbParameter class against the primary key value.
        /// </summary>
        /// <param name="dbParameter">The instance of DbParameter class to update.</param>
        /// <param name="key">The value of the column "key" which will be updated.</param>
        void Update(dynamic dbParameter, string key);

        /// <summary>
        /// Deletes DbParameter from  IDbParameterRepository against the primary key value.
        /// </summary>
        /// <param name="key">The value of the column "key" which will be deleted.</param>
        void Delete(string key);

        /// <summary>
        /// Produces a paginated result of 10 DbParameter classes.
        /// </summary>
        /// <returns>Returns the first page of collection of DbParameter class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 DbParameter classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of DbParameter class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IDbParameterRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of DbParameter class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IDbParameterRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of DbParameter class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IDbParameterRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of DbParameter class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IDbParameterRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of DbParameter class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetFiltered(long pageNumber, string filterName);



    }
}