// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICountryRepository
    {
        /// <summary>
        /// Counts the number of Country in ICountryRepository.
        /// </summary>
        /// <returns>Returns the count of ICountryRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Country. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Country.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Country> GetAll();

        /// <summary>
        /// Returns all instances of Country to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Country.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Country against countryId. 
        /// </summary>
        /// <param name="countryId">The column "country_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Country.</returns>
        MixERP.Net.Entities.Core.Country Get(int countryId);

        /// <summary>
        /// Gets the first record of Country.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Country.</returns>
        MixERP.Net.Entities.Core.Country GetFirst();

        /// <summary>
        /// Gets the previous record of Country sorted by countryId. 
        /// </summary>
        /// <param name="countryId">The column "country_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Country.</returns>
        MixERP.Net.Entities.Core.Country GetPrevious(int countryId);

        /// <summary>
        /// Gets the next record of Country sorted by countryId. 
        /// </summary>
        /// <param name="countryId">The column "country_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Country.</returns>
        MixERP.Net.Entities.Core.Country GetNext(int countryId);

        /// <summary>
        /// Gets the last record of Country.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Country.</returns>
        MixERP.Net.Entities.Core.Country GetLast();

        /// <summary>
        /// Returns multiple instances of the Country against countryIds. 
        /// </summary>
        /// <param name="countryIds">Array of column "country_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Country.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Country> Get(int[] countryIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICountryRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Country.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Country.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Country.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Country class to ICountryRepository.
        /// </summary>
        /// <param name="country">The instance of Country class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic country, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Country class to ICountryRepository.
        /// </summary>
        /// <param name="country">The instance of Country class to insert.</param>
        object Add(dynamic country);

        /// <summary>
        /// Inserts or updates multiple instances of Country class to ICountryRepository.;
        /// </summary>
        /// <param name="countries">List of Country class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> countries);


        /// <summary>
        /// Updates ICountryRepository with an instance of Country class against the primary key value.
        /// </summary>
        /// <param name="country">The instance of Country class to update.</param>
        /// <param name="countryId">The value of the column "country_id" which will be updated.</param>
        void Update(dynamic country, int countryId);

        /// <summary>
        /// Deletes Country from  ICountryRepository against the primary key value.
        /// </summary>
        /// <param name="countryId">The value of the column "country_id" which will be deleted.</param>
        void Delete(int countryId);

        /// <summary>
        /// Produces a paginated result of 10 Country classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Country class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Country> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Country classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Country class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Country> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICountryRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Country class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICountryRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Country class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Country> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICountryRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Country class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICountryRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Country class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Country> GetFiltered(long pageNumber, string filterName);



    }
}