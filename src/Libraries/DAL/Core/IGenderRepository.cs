// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGenderRepository
    {
        /// <summary>
        /// Counts the number of Gender in IGenderRepository.
        /// </summary>
        /// <returns>Returns the count of IGenderRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Gender. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Gender.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Gender> GetAll();

        /// <summary>
        /// Returns all instances of Gender to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Gender.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Gender against genderCode. 
        /// </summary>
        /// <param name="genderCode">The column "gender_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Gender.</returns>
        MixERP.Net.Entities.Core.Gender Get(string genderCode);

        /// <summary>
        /// Gets the first record of Gender.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Gender.</returns>
        MixERP.Net.Entities.Core.Gender GetFirst();

        /// <summary>
        /// Gets the previous record of Gender sorted by genderCode. 
        /// </summary>
        /// <param name="genderCode">The column "gender_code" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Gender.</returns>
        MixERP.Net.Entities.Core.Gender GetPrevious(string genderCode);

        /// <summary>
        /// Gets the next record of Gender sorted by genderCode. 
        /// </summary>
        /// <param name="genderCode">The column "gender_code" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Gender.</returns>
        MixERP.Net.Entities.Core.Gender GetNext(string genderCode);

        /// <summary>
        /// Gets the last record of Gender.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Gender.</returns>
        MixERP.Net.Entities.Core.Gender GetLast();

        /// <summary>
        /// Returns multiple instances of the Gender against genderCodes. 
        /// </summary>
        /// <param name="genderCodes">Array of column "gender_code" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Gender.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Gender> Get(string[] genderCodes);

        /// <summary>
        /// Custom fields are user defined form elements for IGenderRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Gender.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Gender.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Gender.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Gender class to IGenderRepository.
        /// </summary>
        /// <param name="gender">The instance of Gender class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic gender, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Gender class to IGenderRepository.
        /// </summary>
        /// <param name="gender">The instance of Gender class to insert.</param>
        object Add(dynamic gender);

        /// <summary>
        /// Inserts or updates multiple instances of Gender class to IGenderRepository.;
        /// </summary>
        /// <param name="genders">List of Gender class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> genders);


        /// <summary>
        /// Updates IGenderRepository with an instance of Gender class against the primary key value.
        /// </summary>
        /// <param name="gender">The instance of Gender class to update.</param>
        /// <param name="genderCode">The value of the column "gender_code" which will be updated.</param>
        void Update(dynamic gender, string genderCode);

        /// <summary>
        /// Deletes Gender from  IGenderRepository against the primary key value.
        /// </summary>
        /// <param name="genderCode">The value of the column "gender_code" which will be deleted.</param>
        void Delete(string genderCode);

        /// <summary>
        /// Produces a paginated result of 10 Gender classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Gender class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Gender> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Gender classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Gender class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Gender> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IGenderRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Gender class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IGenderRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Gender class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Gender> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IGenderRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Gender class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IGenderRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Gender class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Gender> GetFiltered(long pageNumber, string filterName);



    }
}