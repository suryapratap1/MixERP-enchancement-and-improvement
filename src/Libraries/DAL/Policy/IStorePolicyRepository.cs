// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IStorePolicyRepository
    {
        /// <summary>
        /// Counts the number of StorePolicy in IStorePolicyRepository.
        /// </summary>
        /// <returns>Returns the count of IStorePolicyRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of StorePolicy. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StorePolicy.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> GetAll();

        /// <summary>
        /// Returns all instances of StorePolicy to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StorePolicy.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the StorePolicy against storePolicyId. 
        /// </summary>
        /// <param name="storePolicyId">The column "store_policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of StorePolicy.</returns>
        MixERP.Net.Entities.Policy.StorePolicy Get(long storePolicyId);

        /// <summary>
        /// Gets the first record of StorePolicy.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of StorePolicy.</returns>
        MixERP.Net.Entities.Policy.StorePolicy GetFirst();

        /// <summary>
        /// Gets the previous record of StorePolicy sorted by storePolicyId. 
        /// </summary>
        /// <param name="storePolicyId">The column "store_policy_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of StorePolicy.</returns>
        MixERP.Net.Entities.Policy.StorePolicy GetPrevious(long storePolicyId);

        /// <summary>
        /// Gets the next record of StorePolicy sorted by storePolicyId. 
        /// </summary>
        /// <param name="storePolicyId">The column "store_policy_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of StorePolicy.</returns>
        MixERP.Net.Entities.Policy.StorePolicy GetNext(long storePolicyId);

        /// <summary>
        /// Gets the last record of StorePolicy.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of StorePolicy.</returns>
        MixERP.Net.Entities.Policy.StorePolicy GetLast();

        /// <summary>
        /// Returns multiple instances of the StorePolicy against storePolicyIds. 
        /// </summary>
        /// <param name="storePolicyIds">Array of column "store_policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of StorePolicy.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> Get(long[] storePolicyIds);

        /// <summary>
        /// Custom fields are user defined form elements for IStorePolicyRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for StorePolicy.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding StorePolicy.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for StorePolicy.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of StorePolicy class to IStorePolicyRepository.
        /// </summary>
        /// <param name="storePolicy">The instance of StorePolicy class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic storePolicy, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of StorePolicy class to IStorePolicyRepository.
        /// </summary>
        /// <param name="storePolicy">The instance of StorePolicy class to insert.</param>
        object Add(dynamic storePolicy);

        /// <summary>
        /// Inserts or updates multiple instances of StorePolicy class to IStorePolicyRepository.;
        /// </summary>
        /// <param name="storePolicies">List of StorePolicy class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> storePolicies);


        /// <summary>
        /// Updates IStorePolicyRepository with an instance of StorePolicy class against the primary key value.
        /// </summary>
        /// <param name="storePolicy">The instance of StorePolicy class to update.</param>
        /// <param name="storePolicyId">The value of the column "store_policy_id" which will be updated.</param>
        void Update(dynamic storePolicy, long storePolicyId);

        /// <summary>
        /// Deletes StorePolicy from  IStorePolicyRepository against the primary key value.
        /// </summary>
        /// <param name="storePolicyId">The value of the column "store_policy_id" which will be deleted.</param>
        void Delete(long storePolicyId);

        /// <summary>
        /// Produces a paginated result of 10 StorePolicy classes.
        /// </summary>
        /// <returns>Returns the first page of collection of StorePolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 StorePolicy classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of StorePolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStorePolicyRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of StorePolicy class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IStorePolicyRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of StorePolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStorePolicyRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of StorePolicy class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IStorePolicyRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of StorePolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> GetFiltered(long pageNumber, string filterName);



    }
}