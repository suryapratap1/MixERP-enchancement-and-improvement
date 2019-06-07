// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IVoucherVerificationPolicyRepository
    {
        /// <summary>
        /// Counts the number of VoucherVerificationPolicy in IVoucherVerificationPolicyRepository.
        /// </summary>
        /// <returns>Returns the count of IVoucherVerificationPolicyRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of VoucherVerificationPolicy. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of VoucherVerificationPolicy.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetAll();

        /// <summary>
        /// Returns all instances of VoucherVerificationPolicy to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of VoucherVerificationPolicy.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the VoucherVerificationPolicy against policyId. 
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of VoucherVerificationPolicy.</returns>
        MixERP.Net.Entities.Policy.VoucherVerificationPolicy Get(int policyId);

        /// <summary>
        /// Gets the first record of VoucherVerificationPolicy.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of VoucherVerificationPolicy.</returns>
        MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetFirst();

        /// <summary>
        /// Gets the previous record of VoucherVerificationPolicy sorted by policyId. 
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of VoucherVerificationPolicy.</returns>
        MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetPrevious(int policyId);

        /// <summary>
        /// Gets the next record of VoucherVerificationPolicy sorted by policyId. 
        /// </summary>
        /// <param name="policyId">The column "policy_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of VoucherVerificationPolicy.</returns>
        MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetNext(int policyId);

        /// <summary>
        /// Gets the last record of VoucherVerificationPolicy.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of VoucherVerificationPolicy.</returns>
        MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetLast();

        /// <summary>
        /// Returns multiple instances of the VoucherVerificationPolicy against policyIds. 
        /// </summary>
        /// <param name="policyIds">Array of column "policy_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of VoucherVerificationPolicy.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> Get(int[] policyIds);

        /// <summary>
        /// Custom fields are user defined form elements for IVoucherVerificationPolicyRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for VoucherVerificationPolicy.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding VoucherVerificationPolicy.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for VoucherVerificationPolicy.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of VoucherVerificationPolicy class to IVoucherVerificationPolicyRepository.
        /// </summary>
        /// <param name="voucherVerificationPolicy">The instance of VoucherVerificationPolicy class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic voucherVerificationPolicy, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of VoucherVerificationPolicy class to IVoucherVerificationPolicyRepository.
        /// </summary>
        /// <param name="voucherVerificationPolicy">The instance of VoucherVerificationPolicy class to insert.</param>
        object Add(dynamic voucherVerificationPolicy);

        /// <summary>
        /// Inserts or updates multiple instances of VoucherVerificationPolicy class to IVoucherVerificationPolicyRepository.;
        /// </summary>
        /// <param name="voucherVerificationPolicies">List of VoucherVerificationPolicy class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> voucherVerificationPolicies);


        /// <summary>
        /// Updates IVoucherVerificationPolicyRepository with an instance of VoucherVerificationPolicy class against the primary key value.
        /// </summary>
        /// <param name="voucherVerificationPolicy">The instance of VoucherVerificationPolicy class to update.</param>
        /// <param name="policyId">The value of the column "policy_id" which will be updated.</param>
        void Update(dynamic voucherVerificationPolicy, int policyId);

        /// <summary>
        /// Deletes VoucherVerificationPolicy from  IVoucherVerificationPolicyRepository against the primary key value.
        /// </summary>
        /// <param name="policyId">The value of the column "policy_id" which will be deleted.</param>
        void Delete(int policyId);

        /// <summary>
        /// Produces a paginated result of 10 VoucherVerificationPolicy classes.
        /// </summary>
        /// <returns>Returns the first page of collection of VoucherVerificationPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 VoucherVerificationPolicy classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of VoucherVerificationPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IVoucherVerificationPolicyRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of VoucherVerificationPolicy class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IVoucherVerificationPolicyRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of VoucherVerificationPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IVoucherVerificationPolicyRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of VoucherVerificationPolicy class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IVoucherVerificationPolicyRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of VoucherVerificationPolicy class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetFiltered(long pageNumber, string filterName);



    }
}