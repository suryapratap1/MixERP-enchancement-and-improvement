// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IZipCodeTypeRepository
    {
        /// <summary>
        /// Counts the number of ZipCodeType in IZipCodeTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IZipCodeTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ZipCodeType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ZipCodeType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetAll();

        /// <summary>
        /// Returns all instances of ZipCodeType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ZipCodeType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ZipCodeType against zipCodeTypeId. 
        /// </summary>
        /// <param name="zipCodeTypeId">The column "zip_code_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ZipCodeType.</returns>
        MixERP.Net.Entities.Core.ZipCodeType Get(int zipCodeTypeId);

        /// <summary>
        /// Gets the first record of ZipCodeType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ZipCodeType.</returns>
        MixERP.Net.Entities.Core.ZipCodeType GetFirst();

        /// <summary>
        /// Gets the previous record of ZipCodeType sorted by zipCodeTypeId. 
        /// </summary>
        /// <param name="zipCodeTypeId">The column "zip_code_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ZipCodeType.</returns>
        MixERP.Net.Entities.Core.ZipCodeType GetPrevious(int zipCodeTypeId);

        /// <summary>
        /// Gets the next record of ZipCodeType sorted by zipCodeTypeId. 
        /// </summary>
        /// <param name="zipCodeTypeId">The column "zip_code_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ZipCodeType.</returns>
        MixERP.Net.Entities.Core.ZipCodeType GetNext(int zipCodeTypeId);

        /// <summary>
        /// Gets the last record of ZipCodeType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ZipCodeType.</returns>
        MixERP.Net.Entities.Core.ZipCodeType GetLast();

        /// <summary>
        /// Returns multiple instances of the ZipCodeType against zipCodeTypeIds. 
        /// </summary>
        /// <param name="zipCodeTypeIds">Array of column "zip_code_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ZipCodeType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> Get(int[] zipCodeTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IZipCodeTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ZipCodeType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ZipCodeType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ZipCodeType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ZipCodeType class to IZipCodeTypeRepository.
        /// </summary>
        /// <param name="zipCodeType">The instance of ZipCodeType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic zipCodeType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ZipCodeType class to IZipCodeTypeRepository.
        /// </summary>
        /// <param name="zipCodeType">The instance of ZipCodeType class to insert.</param>
        object Add(dynamic zipCodeType);

        /// <summary>
        /// Inserts or updates multiple instances of ZipCodeType class to IZipCodeTypeRepository.;
        /// </summary>
        /// <param name="zipCodeTypes">List of ZipCodeType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> zipCodeTypes);


        /// <summary>
        /// Updates IZipCodeTypeRepository with an instance of ZipCodeType class against the primary key value.
        /// </summary>
        /// <param name="zipCodeType">The instance of ZipCodeType class to update.</param>
        /// <param name="zipCodeTypeId">The value of the column "zip_code_type_id" which will be updated.</param>
        void Update(dynamic zipCodeType, int zipCodeTypeId);

        /// <summary>
        /// Deletes ZipCodeType from  IZipCodeTypeRepository against the primary key value.
        /// </summary>
        /// <param name="zipCodeTypeId">The value of the column "zip_code_type_id" which will be deleted.</param>
        void Delete(int zipCodeTypeId);

        /// <summary>
        /// Produces a paginated result of 10 ZipCodeType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ZipCodeType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ZipCodeType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ZipCodeType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IZipCodeTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ZipCodeType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IZipCodeTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ZipCodeType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IZipCodeTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ZipCodeType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IZipCodeTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ZipCodeType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ZipCodeType> GetFiltered(long pageNumber, string filterName);



    }
}