// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICountyRepository
    {
        /// <summary>
        /// Counts the number of County in ICountyRepository.
        /// </summary>
        /// <returns>Returns the count of ICountyRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of County. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of County.</returns>
        IEnumerable<MixERP.Net.Entities.Core.County> GetAll();

        /// <summary>
        /// Returns all instances of County to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of County.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the County against countyId. 
        /// </summary>
        /// <param name="countyId">The column "county_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of County.</returns>
        MixERP.Net.Entities.Core.County Get(int countyId);

        /// <summary>
        /// Gets the first record of County.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of County.</returns>
        MixERP.Net.Entities.Core.County GetFirst();

        /// <summary>
        /// Gets the previous record of County sorted by countyId. 
        /// </summary>
        /// <param name="countyId">The column "county_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of County.</returns>
        MixERP.Net.Entities.Core.County GetPrevious(int countyId);

        /// <summary>
        /// Gets the next record of County sorted by countyId. 
        /// </summary>
        /// <param name="countyId">The column "county_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of County.</returns>
        MixERP.Net.Entities.Core.County GetNext(int countyId);

        /// <summary>
        /// Gets the last record of County.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of County.</returns>
        MixERP.Net.Entities.Core.County GetLast();

        /// <summary>
        /// Returns multiple instances of the County against countyIds. 
        /// </summary>
        /// <param name="countyIds">Array of column "county_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of County.</returns>
        IEnumerable<MixERP.Net.Entities.Core.County> Get(int[] countyIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICountyRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for County.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding County.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for County.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of County class to ICountyRepository.
        /// </summary>
        /// <param name="county">The instance of County class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic county, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of County class to ICountyRepository.
        /// </summary>
        /// <param name="county">The instance of County class to insert.</param>
        object Add(dynamic county);

        /// <summary>
        /// Inserts or updates multiple instances of County class to ICountyRepository.;
        /// </summary>
        /// <param name="counties">List of County class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> counties);


        /// <summary>
        /// Updates ICountyRepository with an instance of County class against the primary key value.
        /// </summary>
        /// <param name="county">The instance of County class to update.</param>
        /// <param name="countyId">The value of the column "county_id" which will be updated.</param>
        void Update(dynamic county, int countyId);

        /// <summary>
        /// Deletes County from  ICountyRepository against the primary key value.
        /// </summary>
        /// <param name="countyId">The value of the column "county_id" which will be deleted.</param>
        void Delete(int countyId);

        /// <summary>
        /// Produces a paginated result of 10 County classes.
        /// </summary>
        /// <returns>Returns the first page of collection of County class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.County> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 County classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of County class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.County> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICountyRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of County class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICountyRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of County class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.County> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICountyRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of County class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICountyRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of County class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.County> GetFiltered(long pageNumber, string filterName);



    }
}