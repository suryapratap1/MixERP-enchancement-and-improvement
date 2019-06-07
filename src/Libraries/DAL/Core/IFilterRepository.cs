// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IFilterRepository
    {
        /// <summary>
        /// Counts the number of Filter in IFilterRepository.
        /// </summary>
        /// <returns>Returns the count of IFilterRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Filter. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Filter.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Filter> GetAll();

        /// <summary>
        /// Returns all instances of Filter to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Filter.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Filter against filterId. 
        /// </summary>
        /// <param name="filterId">The column "filter_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Filter.</returns>
        MixERP.Net.Entities.Core.Filter Get(long filterId);

        /// <summary>
        /// Gets the first record of Filter.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Filter.</returns>
        MixERP.Net.Entities.Core.Filter GetFirst();

        /// <summary>
        /// Gets the previous record of Filter sorted by filterId. 
        /// </summary>
        /// <param name="filterId">The column "filter_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Filter.</returns>
        MixERP.Net.Entities.Core.Filter GetPrevious(long filterId);

        /// <summary>
        /// Gets the next record of Filter sorted by filterId. 
        /// </summary>
        /// <param name="filterId">The column "filter_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Filter.</returns>
        MixERP.Net.Entities.Core.Filter GetNext(long filterId);

        /// <summary>
        /// Gets the last record of Filter.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Filter.</returns>
        MixERP.Net.Entities.Core.Filter GetLast();

        /// <summary>
        /// Returns multiple instances of the Filter against filterIds. 
        /// </summary>
        /// <param name="filterIds">Array of column "filter_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Filter.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Filter> Get(long[] filterIds);

        /// <summary>
        /// Custom fields are user defined form elements for IFilterRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Filter.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Filter.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Filter.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Filter class to IFilterRepository.
        /// </summary>
        /// <param name="filter">The instance of Filter class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic filter, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Filter class to IFilterRepository.
        /// </summary>
        /// <param name="filter">The instance of Filter class to insert.</param>
        object Add(dynamic filter);

        /// <summary>
        /// Inserts or updates multiple instances of Filter class to IFilterRepository.;
        /// </summary>
        /// <param name="filters">List of Filter class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> filters);


        /// <summary>
        /// Updates IFilterRepository with an instance of Filter class against the primary key value.
        /// </summary>
        /// <param name="filter">The instance of Filter class to update.</param>
        /// <param name="filterId">The value of the column "filter_id" which will be updated.</param>
        void Update(dynamic filter, long filterId);

        /// <summary>
        /// Deletes Filter from  IFilterRepository against the primary key value.
        /// </summary>
        /// <param name="filterId">The value of the column "filter_id" which will be deleted.</param>
        void Delete(long filterId);

        /// <summary>
        /// Produces a paginated result of 10 Filter classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Filter class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Filter> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Filter classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Filter class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Filter> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFilterRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Filter class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IFilterRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Filter class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Filter> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFilterRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Filter class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IFilterRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Filter class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Filter> GetFiltered(long pageNumber, string filterName);



        /// <summary>
        /// Deletes Filter from  IFilterRepository against the primary key value.
        /// </summary>
        /// <param name="filterName">The value of the column "filter_name" which will be deleted.</param>
        void Delete(string filterName);

        void RecreateFilters(string objectName, string filterName, List<MixERP.Net.Entities.Core.Filter> filters);

        void MakeDefault(string objectName, string filterName);

        void RemoveDefault(string objectName);
    }
}