// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IStorePolicyDetailRepository
    {
        /// <summary>
        /// Counts the number of StorePolicyDetail in IStorePolicyDetailRepository.
        /// </summary>
        /// <returns>Returns the count of IStorePolicyDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of StorePolicyDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StorePolicyDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetAll();

        /// <summary>
        /// Returns all instances of StorePolicyDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StorePolicyDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the StorePolicyDetail against storePolicyDetailId. 
        /// </summary>
        /// <param name="storePolicyDetailId">The column "store_policy_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of StorePolicyDetail.</returns>
        MixERP.Net.Entities.Policy.StorePolicyDetail Get(long storePolicyDetailId);

        /// <summary>
        /// Gets the first record of StorePolicyDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of StorePolicyDetail.</returns>
        MixERP.Net.Entities.Policy.StorePolicyDetail GetFirst();

        /// <summary>
        /// Gets the previous record of StorePolicyDetail sorted by storePolicyDetailId. 
        /// </summary>
        /// <param name="storePolicyDetailId">The column "store_policy_detail_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of StorePolicyDetail.</returns>
        MixERP.Net.Entities.Policy.StorePolicyDetail GetPrevious(long storePolicyDetailId);

        /// <summary>
        /// Gets the next record of StorePolicyDetail sorted by storePolicyDetailId. 
        /// </summary>
        /// <param name="storePolicyDetailId">The column "store_policy_detail_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of StorePolicyDetail.</returns>
        MixERP.Net.Entities.Policy.StorePolicyDetail GetNext(long storePolicyDetailId);

        /// <summary>
        /// Gets the last record of StorePolicyDetail.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of StorePolicyDetail.</returns>
        MixERP.Net.Entities.Policy.StorePolicyDetail GetLast();

        /// <summary>
        /// Returns multiple instances of the StorePolicyDetail against storePolicyDetailIds. 
        /// </summary>
        /// <param name="storePolicyDetailIds">Array of column "store_policy_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of StorePolicyDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> Get(long[] storePolicyDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for IStorePolicyDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for StorePolicyDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding StorePolicyDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for StorePolicyDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of StorePolicyDetail class to IStorePolicyDetailRepository.
        /// </summary>
        /// <param name="storePolicyDetail">The instance of StorePolicyDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic storePolicyDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of StorePolicyDetail class to IStorePolicyDetailRepository.
        /// </summary>
        /// <param name="storePolicyDetail">The instance of StorePolicyDetail class to insert.</param>
        object Add(dynamic storePolicyDetail);

        /// <summary>
        /// Inserts or updates multiple instances of StorePolicyDetail class to IStorePolicyDetailRepository.;
        /// </summary>
        /// <param name="storePolicyDetails">List of StorePolicyDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> storePolicyDetails);


        /// <summary>
        /// Updates IStorePolicyDetailRepository with an instance of StorePolicyDetail class against the primary key value.
        /// </summary>
        /// <param name="storePolicyDetail">The instance of StorePolicyDetail class to update.</param>
        /// <param name="storePolicyDetailId">The value of the column "store_policy_detail_id" which will be updated.</param>
        void Update(dynamic storePolicyDetail, long storePolicyDetailId);

        /// <summary>
        /// Deletes StorePolicyDetail from  IStorePolicyDetailRepository against the primary key value.
        /// </summary>
        /// <param name="storePolicyDetailId">The value of the column "store_policy_detail_id" which will be deleted.</param>
        void Delete(long storePolicyDetailId);

        /// <summary>
        /// Produces a paginated result of 10 StorePolicyDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of StorePolicyDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 StorePolicyDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of StorePolicyDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStorePolicyDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of StorePolicyDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IStorePolicyDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of StorePolicyDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStorePolicyDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of StorePolicyDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IStorePolicyDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of StorePolicyDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetFiltered(long pageNumber, string filterName);



    }
}