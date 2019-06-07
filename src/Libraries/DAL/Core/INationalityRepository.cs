// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface INationalityRepository
    {
        /// <summary>
        /// Counts the number of Nationality in INationalityRepository.
        /// </summary>
        /// <returns>Returns the count of INationalityRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Nationality. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Nationality.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Nationality> GetAll();

        /// <summary>
        /// Returns all instances of Nationality to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Nationality.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Nationality against nationalityCode. 
        /// </summary>
        /// <param name="nationalityCode">The column "nationality_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Nationality.</returns>
        MixERP.Net.Entities.Core.Nationality Get(string nationalityCode);

        /// <summary>
        /// Gets the first record of Nationality.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Nationality.</returns>
        MixERP.Net.Entities.Core.Nationality GetFirst();

        /// <summary>
        /// Gets the previous record of Nationality sorted by nationalityCode. 
        /// </summary>
        /// <param name="nationalityCode">The column "nationality_code" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Nationality.</returns>
        MixERP.Net.Entities.Core.Nationality GetPrevious(string nationalityCode);

        /// <summary>
        /// Gets the next record of Nationality sorted by nationalityCode. 
        /// </summary>
        /// <param name="nationalityCode">The column "nationality_code" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Nationality.</returns>
        MixERP.Net.Entities.Core.Nationality GetNext(string nationalityCode);

        /// <summary>
        /// Gets the last record of Nationality.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Nationality.</returns>
        MixERP.Net.Entities.Core.Nationality GetLast();

        /// <summary>
        /// Returns multiple instances of the Nationality against nationalityCodes. 
        /// </summary>
        /// <param name="nationalityCodes">Array of column "nationality_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Nationality.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Nationality> Get(string[] nationalityCodes);

        /// <summary>
        /// Custom fields are user defined form elements for INationalityRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Nationality.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Nationality.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Nationality.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Nationality class to INationalityRepository.
        /// </summary>
        /// <param name="nationality">The instance of Nationality class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic nationality, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Nationality class to INationalityRepository.
        /// </summary>
        /// <param name="nationality">The instance of Nationality class to insert.</param>
        object Add(dynamic nationality);

        /// <summary>
        /// Inserts or updates multiple instances of Nationality class to INationalityRepository.;
        /// </summary>
        /// <param name="nationalities">List of Nationality class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> nationalities);


        /// <summary>
        /// Updates INationalityRepository with an instance of Nationality class against the primary key value.
        /// </summary>
        /// <param name="nationality">The instance of Nationality class to update.</param>
        /// <param name="nationalityCode">The value of the column "nationality_code" which will be updated.</param>
        void Update(dynamic nationality, string nationalityCode);

        /// <summary>
        /// Deletes Nationality from  INationalityRepository against the primary key value.
        /// </summary>
        /// <param name="nationalityCode">The value of the column "nationality_code" which will be deleted.</param>
        void Delete(string nationalityCode);

        /// <summary>
        /// Produces a paginated result of 10 Nationality classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Nationality class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Nationality> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Nationality classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Nationality class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Nationality> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on INationalityRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Nationality class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against INationalityRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Nationality class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Nationality> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on INationalityRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Nationality class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of INationalityRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Nationality class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Nationality> GetFiltered(long pageNumber, string filterName);



    }
}