// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IZipCodeRepository
    {
        /// <summary>
        /// Counts the number of ZipCode in IZipCodeRepository.
        /// </summary>
        /// <returns>Returns the count of IZipCodeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ZipCode. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ZipCode.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCode> GetAll();

        /// <summary>
        /// Returns all instances of ZipCode to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ZipCode.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ZipCode against zipCodeId. 
        /// </summary>
        /// <param name="zipCodeId">The column "zip_code_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ZipCode.</returns>
        MixERP.Net.Entities.Core.ZipCode Get(long zipCodeId);

        /// <summary>
        /// Gets the first record of ZipCode.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ZipCode.</returns>
        MixERP.Net.Entities.Core.ZipCode GetFirst();

        /// <summary>
        /// Gets the previous record of ZipCode sorted by zipCodeId. 
        /// </summary>
        /// <param name="zipCodeId">The column "zip_code_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ZipCode.</returns>
        MixERP.Net.Entities.Core.ZipCode GetPrevious(long zipCodeId);

        /// <summary>
        /// Gets the next record of ZipCode sorted by zipCodeId. 
        /// </summary>
        /// <param name="zipCodeId">The column "zip_code_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ZipCode.</returns>
        MixERP.Net.Entities.Core.ZipCode GetNext(long zipCodeId);

        /// <summary>
        /// Gets the last record of ZipCode.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ZipCode.</returns>
        MixERP.Net.Entities.Core.ZipCode GetLast();

        /// <summary>
        /// Returns multiple instances of the ZipCode against zipCodeIds. 
        /// </summary>
        /// <param name="zipCodeIds">Array of column "zip_code_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ZipCode.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCode> Get(long[] zipCodeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IZipCodeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ZipCode.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ZipCode.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ZipCode.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ZipCode class to IZipCodeRepository.
        /// </summary>
        /// <param name="zipCode">The instance of ZipCode class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic zipCode, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ZipCode class to IZipCodeRepository.
        /// </summary>
        /// <param name="zipCode">The instance of ZipCode class to insert.</param>
        object Add(dynamic zipCode);

        /// <summary>
        /// Inserts or updates multiple instances of ZipCode class to IZipCodeRepository.;
        /// </summary>
        /// <param name="zipCodes">List of ZipCode class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> zipCodes);


        /// <summary>
        /// Updates IZipCodeRepository with an instance of ZipCode class against the primary key value.
        /// </summary>
        /// <param name="zipCode">The instance of ZipCode class to update.</param>
        /// <param name="zipCodeId">The value of the column "zip_code_id" which will be updated.</param>
        void Update(dynamic zipCode, long zipCodeId);

        /// <summary>
        /// Deletes ZipCode from  IZipCodeRepository against the primary key value.
        /// </summary>
        /// <param name="zipCodeId">The value of the column "zip_code_id" which will be deleted.</param>
        void Delete(long zipCodeId);

        /// <summary>
        /// Produces a paginated result of 10 ZipCode classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ZipCode class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCode> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ZipCode classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ZipCode class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCode> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IZipCodeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ZipCode class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IZipCodeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ZipCode class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCode> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IZipCodeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ZipCode class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IZipCodeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ZipCode class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCode> GetFiltered(long pageNumber, string filterName);



    }
}