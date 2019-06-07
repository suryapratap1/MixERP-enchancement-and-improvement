// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IApiAccessPolicyRepository
    {
        /// <summary>
        /// Counts the number of ApiAccessPolicy in IApiAccessPolicyRepository.
        /// </summary>
        /// <returns>Returns the count of IApiAccessPolicyRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ApiAccessPolicy. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ApiAccessPolicy.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetAll();

        /// <summary>
        /// Returns all instances of ApiAccessPolicy to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ApiAccessPolicy.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ApiAccessPolicy against apiAccessPolicyId. 
        /// </summary>
        /// <param name="apiAccessPolicyId">The column "api_access_policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ApiAccessPolicy.</returns>
        MixERP.Net.Entities.Policy.ApiAccessPolicy Get(long apiAccessPolicyId);

        /// <summary>
        /// Gets the first record of ApiAccessPolicy.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ApiAccessPolicy.</returns>
        MixERP.Net.Entities.Policy.ApiAccessPolicy GetFirst();

        /// <summary>
        /// Gets the previous record of ApiAccessPolicy sorted by apiAccessPolicyId. 
        /// </summary>
        /// <param name="apiAccessPolicyId">The column "api_access_policy_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ApiAccessPolicy.</returns>
        MixERP.Net.Entities.Policy.ApiAccessPolicy GetPrevious(long apiAccessPolicyId);

        /// <summary>
        /// Gets the next record of ApiAccessPolicy sorted by apiAccessPolicyId. 
        /// </summary>
        /// <param name="apiAccessPolicyId">The column "api_access_policy_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ApiAccessPolicy.</returns>
        MixERP.Net.Entities.Policy.ApiAccessPolicy GetNext(long apiAccessPolicyId);

        /// <summary>
        /// Gets the last record of ApiAccessPolicy.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ApiAccessPolicy.</returns>
        MixERP.Net.Entities.Policy.ApiAccessPolicy GetLast();

        /// <summary>
        /// Returns multiple instances of the ApiAccessPolicy against apiAccessPolicyIds. 
        /// </summary>
        /// <param name="apiAccessPolicyIds">Array of column "api_access_policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ApiAccessPolicy.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> Get(long[] apiAccessPolicyIds);

        /// <summary>
        /// Custom fields are user defined form elements for IApiAccessPolicyRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ApiAccessPolicy.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ApiAccessPolicy.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ApiAccessPolicy.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ApiAccessPolicy class to IApiAccessPolicyRepository.
        /// </summary>
        /// <param name="apiAccessPolicy">The instance of ApiAccessPolicy class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic apiAccessPolicy, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ApiAccessPolicy class to IApiAccessPolicyRepository.
        /// </summary>
        /// <param name="apiAccessPolicy">The instance of ApiAccessPolicy class to insert.</param>
        object Add(dynamic apiAccessPolicy);

        /// <summary>
        /// Inserts or updates multiple instances of ApiAccessPolicy class to IApiAccessPolicyRepository.;
        /// </summary>
        /// <param name="apiAccessPolicies">List of ApiAccessPolicy class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> apiAccessPolicies);


        /// <summary>
        /// Updates IApiAccessPolicyRepository with an instance of ApiAccessPolicy class against the primary key value.
        /// </summary>
        /// <param name="apiAccessPolicy">The instance of ApiAccessPolicy class to update.</param>
        /// <param name="apiAccessPolicyId">The value of the column "api_access_policy_id" which will be updated.</param>
        void Update(dynamic apiAccessPolicy, long apiAccessPolicyId);

        /// <summary>
        /// Deletes ApiAccessPolicy from  IApiAccessPolicyRepository against the primary key value.
        /// </summary>
        /// <param name="apiAccessPolicyId">The value of the column "api_access_policy_id" which will be deleted.</param>
        void Delete(long apiAccessPolicyId);

        /// <summary>
        /// Produces a paginated result of 10 ApiAccessPolicy classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ApiAccessPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ApiAccessPolicy classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ApiAccessPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IApiAccessPolicyRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ApiAccessPolicy class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IApiAccessPolicyRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ApiAccessPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IApiAccessPolicyRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ApiAccessPolicy class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IApiAccessPolicyRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ApiAccessPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetFiltered(long pageNumber, string filterName);



    }
}