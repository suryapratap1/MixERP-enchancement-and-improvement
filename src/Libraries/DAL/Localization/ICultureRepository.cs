// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Localization.Data
{
    public interface ICultureRepository
    {
        /// <summary>
        /// Counts the number of Culture in ICultureRepository.
        /// </summary>
        /// <returns>Returns the count of ICultureRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Culture. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Culture.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Culture> GetAll();

        /// <summary>
        /// Returns all instances of Culture to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Culture.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Culture against cultureCode. 
        /// </summary>
        /// <param name="cultureCode">The column "culture_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Culture.</returns>
        MixERP.Net.Entities.Localization.Culture Get(string cultureCode);

        /// <summary>
        /// Gets the first record of Culture.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Culture.</returns>
        MixERP.Net.Entities.Localization.Culture GetFirst();

        /// <summary>
        /// Gets the previous record of Culture sorted by cultureCode. 
        /// </summary>
        /// <param name="cultureCode">The column "culture_code" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Culture.</returns>
        MixERP.Net.Entities.Localization.Culture GetPrevious(string cultureCode);

        /// <summary>
        /// Gets the next record of Culture sorted by cultureCode. 
        /// </summary>
        /// <param name="cultureCode">The column "culture_code" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Culture.</returns>
        MixERP.Net.Entities.Localization.Culture GetNext(string cultureCode);

        /// <summary>
        /// Gets the last record of Culture.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Culture.</returns>
        MixERP.Net.Entities.Localization.Culture GetLast();

        /// <summary>
        /// Returns multiple instances of the Culture against cultureCodes. 
        /// </summary>
        /// <param name="cultureCodes">Array of column "culture_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Culture.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Culture> Get(string[] cultureCodes);

        /// <summary>
        /// Custom fields are user defined form elements for ICultureRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Culture.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Culture.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Culture.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Culture class to ICultureRepository.
        /// </summary>
        /// <param name="culture">The instance of Culture class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic culture, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Culture class to ICultureRepository.
        /// </summary>
        /// <param name="culture">The instance of Culture class to insert.</param>
        object Add(dynamic culture);

        /// <summary>
        /// Inserts or updates multiple instances of Culture class to ICultureRepository.;
        /// </summary>
        /// <param name="cultures">List of Culture class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> cultures);


        /// <summary>
        /// Updates ICultureRepository with an instance of Culture class against the primary key value.
        /// </summary>
        /// <param name="culture">The instance of Culture class to update.</param>
        /// <param name="cultureCode">The value of the column "culture_code" which will be updated.</param>
        void Update(dynamic culture, string cultureCode);

        /// <summary>
        /// Deletes Culture from  ICultureRepository against the primary key value.
        /// </summary>
        /// <param name="cultureCode">The value of the column "culture_code" which will be deleted.</param>
        void Delete(string cultureCode);

        /// <summary>
        /// Produces a paginated result of 10 Culture classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Culture class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Culture> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Culture classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Culture class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Culture> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICultureRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Culture class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICultureRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Culture class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Culture> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICultureRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Culture class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICultureRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Culture class.</returns>
        IEnumerable<MixERP.Net.Entities.Localization.Culture> GetFiltered(long pageNumber, string filterName);



    }
}