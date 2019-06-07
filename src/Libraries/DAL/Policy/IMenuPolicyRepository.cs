// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IMenuPolicyRepository
    {
        /// <summary>
        /// Counts the number of MenuPolicy in IMenuPolicyRepository.
        /// </summary>
        /// <returns>Returns the count of IMenuPolicyRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of MenuPolicy. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of MenuPolicy.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuPolicy> GetAll();

        /// <summary>
        /// Returns all instances of MenuPolicy to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of MenuPolicy.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the MenuPolicy against policyId. 
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of MenuPolicy.</returns>
        MixERP.Net.Entities.Policy.MenuPolicy Get(int policyId);

        /// <summary>
        /// Gets the first record of MenuPolicy.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of MenuPolicy.</returns>
        MixERP.Net.Entities.Policy.MenuPolicy GetFirst();

        /// <summary>
        /// Gets the previous record of MenuPolicy sorted by policyId. 
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of MenuPolicy.</returns>
        MixERP.Net.Entities.Policy.MenuPolicy GetPrevious(int policyId);

        /// <summary>
        /// Gets the next record of MenuPolicy sorted by policyId. 
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of MenuPolicy.</returns>
        MixERP.Net.Entities.Policy.MenuPolicy GetNext(int policyId);

        /// <summary>
        /// Gets the last record of MenuPolicy.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of MenuPolicy.</returns>
        MixERP.Net.Entities.Policy.MenuPolicy GetLast();

        /// <summary>
        /// Returns multiple instances of the MenuPolicy against policyIds. 
        /// </summary>
        /// <param name="policyIds">Array of column "policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of MenuPolicy.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuPolicy> Get(int[] policyIds);

        /// <summary>
        /// Custom fields are user defined form elements for IMenuPolicyRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for MenuPolicy.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding MenuPolicy.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for MenuPolicy.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of MenuPolicy class to IMenuPolicyRepository.
        /// </summary>
        /// <param name="menuPolicy">The instance of MenuPolicy class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic menuPolicy, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of MenuPolicy class to IMenuPolicyRepository.
        /// </summary>
        /// <param name="menuPolicy">The instance of MenuPolicy class to insert.</param>
        object Add(dynamic menuPolicy);

        /// <summary>
        /// Inserts or updates multiple instances of MenuPolicy class to IMenuPolicyRepository.;
        /// </summary>
        /// <param name="menuPolicies">List of MenuPolicy class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> menuPolicies);


        /// <summary>
        /// Updates IMenuPolicyRepository with an instance of MenuPolicy class against the primary key value.
        /// </summary>
        /// <param name="menuPolicy">The instance of MenuPolicy class to update.</param>
        /// <param name="policyId">The value of the column "policy_id" which will be updated.</param>
        void Update(dynamic menuPolicy, int policyId);

        /// <summary>
        /// Deletes MenuPolicy from  IMenuPolicyRepository against the primary key value.
        /// </summary>
        /// <param name="policyId">The value of the column "policy_id" which will be deleted.</param>
        void Delete(int policyId);

        /// <summary>
        /// Produces a paginated result of 10 MenuPolicy classes.
        /// </summary>
        /// <returns>Returns the first page of collection of MenuPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuPolicy> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 MenuPolicy classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of MenuPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuPolicy> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IMenuPolicyRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of MenuPolicy class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IMenuPolicyRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of MenuPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuPolicy> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IMenuPolicyRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of MenuPolicy class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IMenuPolicyRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of MenuPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.MenuPolicy> GetFiltered(long pageNumber, string filterName);



    }
}