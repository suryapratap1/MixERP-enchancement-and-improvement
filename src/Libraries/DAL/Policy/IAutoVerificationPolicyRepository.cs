// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IAutoVerificationPolicyRepository
    {
        /// <summary>
        /// Counts the number of AutoVerificationPolicy in IAutoVerificationPolicyRepository.
        /// </summary>
        /// <returns>Returns the count of IAutoVerificationPolicyRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of AutoVerificationPolicy. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AutoVerificationPolicy.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AutoVerificationPolicy> GetAll();

        /// <summary>
        /// Returns all instances of AutoVerificationPolicy to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AutoVerificationPolicy.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the AutoVerificationPolicy against policyId. 
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of AutoVerificationPolicy.</returns>
        MixERP.Net.Entities.Policy.AutoVerificationPolicy Get(int policyId);

        /// <summary>
        /// Gets the first record of AutoVerificationPolicy.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AutoVerificationPolicy.</returns>
        MixERP.Net.Entities.Policy.AutoVerificationPolicy GetFirst();

        /// <summary>
        /// Gets the previous record of AutoVerificationPolicy sorted by policyId. 
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AutoVerificationPolicy.</returns>
        MixERP.Net.Entities.Policy.AutoVerificationPolicy GetPrevious(int policyId);

        /// <summary>
        /// Gets the next record of AutoVerificationPolicy sorted by policyId. 
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AutoVerificationPolicy.</returns>
        MixERP.Net.Entities.Policy.AutoVerificationPolicy GetNext(int policyId);

        /// <summary>
        /// Gets the last record of AutoVerificationPolicy.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AutoVerificationPolicy.</returns>
        MixERP.Net.Entities.Policy.AutoVerificationPolicy GetLast();

        /// <summary>
        /// Returns multiple instances of the AutoVerificationPolicy against policyIds. 
        /// </summary>
        /// <param name="policyIds">Array of column "policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of AutoVerificationPolicy.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AutoVerificationPolicy> Get(int[] policyIds);

        /// <summary>
        /// Custom fields are user defined form elements for IAutoVerificationPolicyRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for AutoVerificationPolicy.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding AutoVerificationPolicy.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for AutoVerificationPolicy.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of AutoVerificationPolicy class to IAutoVerificationPolicyRepository.
        /// </summary>
        /// <param name="autoVerificationPolicy">The instance of AutoVerificationPolicy class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic autoVerificationPolicy, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of AutoVerificationPolicy class to IAutoVerificationPolicyRepository.
        /// </summary>
        /// <param name="autoVerificationPolicy">The instance of AutoVerificationPolicy class to insert.</param>
        object Add(dynamic autoVerificationPolicy);

        /// <summary>
        /// Inserts or updates multiple instances of AutoVerificationPolicy class to IAutoVerificationPolicyRepository.;
        /// </summary>
        /// <param name="autoVerificationPolicies">List of AutoVerificationPolicy class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> autoVerificationPolicies);


        /// <summary>
        /// Updates IAutoVerificationPolicyRepository with an instance of AutoVerificationPolicy class against the primary key value.
        /// </summary>
        /// <param name="autoVerificationPolicy">The instance of AutoVerificationPolicy class to update.</param>
        /// <param name="policyId">The value of the column "policy_id" which will be updated.</param>
        void Update(dynamic autoVerificationPolicy, int policyId);

        /// <summary>
        /// Deletes AutoVerificationPolicy from  IAutoVerificationPolicyRepository against the primary key value.
        /// </summary>
        /// <param name="policyId">The value of the column "policy_id" which will be deleted.</param>
        void Delete(int policyId);

        /// <summary>
        /// Produces a paginated result of 10 AutoVerificationPolicy classes.
        /// </summary>
        /// <returns>Returns the first page of collection of AutoVerificationPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AutoVerificationPolicy> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 AutoVerificationPolicy classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of AutoVerificationPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AutoVerificationPolicy> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAutoVerificationPolicyRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of AutoVerificationPolicy class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IAutoVerificationPolicyRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of AutoVerificationPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AutoVerificationPolicy> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAutoVerificationPolicyRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of AutoVerificationPolicy class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IAutoVerificationPolicyRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of AutoVerificationPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.AutoVerificationPolicy> GetFiltered(long pageNumber, string filterName);



    }
}