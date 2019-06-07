// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IStoreTypeRepository
    {
        /// <summary>
        /// Counts the number of StoreType in IStoreTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IStoreTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of StoreType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StoreType.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreType> GetAll();

        /// <summary>
        /// Returns all instances of StoreType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StoreType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the StoreType against storeTypeId. 
        /// </summary>
        /// <param name="storeTypeId">The column "store_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of StoreType.</returns>
        MixERP.Net.Entities.Office.StoreType Get(int storeTypeId);

        /// <summary>
        /// Gets the first record of StoreType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of StoreType.</returns>
        MixERP.Net.Entities.Office.StoreType GetFirst();

        /// <summary>
        /// Gets the previous record of StoreType sorted by storeTypeId. 
        /// </summary>
        /// <param name="storeTypeId">The column "store_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of StoreType.</returns>
        MixERP.Net.Entities.Office.StoreType GetPrevious(int storeTypeId);

        /// <summary>
        /// Gets the next record of StoreType sorted by storeTypeId. 
        /// </summary>
        /// <param name="storeTypeId">The column "store_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of StoreType.</returns>
        MixERP.Net.Entities.Office.StoreType GetNext(int storeTypeId);

        /// <summary>
        /// Gets the last record of StoreType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of StoreType.</returns>
        MixERP.Net.Entities.Office.StoreType GetLast();

        /// <summary>
        /// Returns multiple instances of the StoreType against storeTypeIds. 
        /// </summary>
        /// <param name="storeTypeIds">Array of column "store_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of StoreType.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreType> Get(int[] storeTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IStoreTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for StoreType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding StoreType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for StoreType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of StoreType class to IStoreTypeRepository.
        /// </summary>
        /// <param name="storeType">The instance of StoreType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic storeType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of StoreType class to IStoreTypeRepository.
        /// </summary>
        /// <param name="storeType">The instance of StoreType class to insert.</param>
        object Add(dynamic storeType);

        /// <summary>
        /// Inserts or updates multiple instances of StoreType class to IStoreTypeRepository.;
        /// </summary>
        /// <param name="storeTypes">List of StoreType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> storeTypes);


        /// <summary>
        /// Updates IStoreTypeRepository with an instance of StoreType class against the primary key value.
        /// </summary>
        /// <param name="storeType">The instance of StoreType class to update.</param>
        /// <param name="storeTypeId">The value of the column "store_type_id" which will be updated.</param>
        void Update(dynamic storeType, int storeTypeId);

        /// <summary>
        /// Deletes StoreType from  IStoreTypeRepository against the primary key value.
        /// </summary>
        /// <param name="storeTypeId">The value of the column "store_type_id" which will be deleted.</param>
        void Delete(int storeTypeId);

        /// <summary>
        /// Produces a paginated result of 10 StoreType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of StoreType class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 StoreType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of StoreType class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStoreTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of StoreType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IStoreTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of StoreType class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStoreTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of StoreType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IStoreTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of StoreType class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.StoreType> GetFiltered(long pageNumber, string filterName);



    }
}