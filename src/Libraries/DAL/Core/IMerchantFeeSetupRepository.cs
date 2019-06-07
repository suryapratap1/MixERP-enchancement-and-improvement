// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IMerchantFeeSetupRepository
    {
        /// <summary>
        /// Counts the number of MerchantFeeSetup in IMerchantFeeSetupRepository.
        /// </summary>
        /// <returns>Returns the count of IMerchantFeeSetupRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of MerchantFeeSetup. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of MerchantFeeSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetAll();

        /// <summary>
        /// Returns all instances of MerchantFeeSetup to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of MerchantFeeSetup.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the MerchantFeeSetup against merchantFeeSetupId. 
        /// </summary>
        /// <param name="merchantFeeSetupId">The column "merchant_fee_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of MerchantFeeSetup.</returns>
        MixERP.Net.Entities.Core.MerchantFeeSetup Get(int merchantFeeSetupId);

        /// <summary>
        /// Gets the first record of MerchantFeeSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of MerchantFeeSetup.</returns>
        MixERP.Net.Entities.Core.MerchantFeeSetup GetFirst();

        /// <summary>
        /// Gets the previous record of MerchantFeeSetup sorted by merchantFeeSetupId. 
        /// </summary>
        /// <param name="merchantFeeSetupId">The column "merchant_fee_setup_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of MerchantFeeSetup.</returns>
        MixERP.Net.Entities.Core.MerchantFeeSetup GetPrevious(int merchantFeeSetupId);

        /// <summary>
        /// Gets the next record of MerchantFeeSetup sorted by merchantFeeSetupId. 
        /// </summary>
        /// <param name="merchantFeeSetupId">The column "merchant_fee_setup_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of MerchantFeeSetup.</returns>
        MixERP.Net.Entities.Core.MerchantFeeSetup GetNext(int merchantFeeSetupId);

        /// <summary>
        /// Gets the last record of MerchantFeeSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of MerchantFeeSetup.</returns>
        MixERP.Net.Entities.Core.MerchantFeeSetup GetLast();

        /// <summary>
        /// Returns multiple instances of the MerchantFeeSetup against merchantFeeSetupIds. 
        /// </summary>
        /// <param name="merchantFeeSetupIds">Array of column "merchant_fee_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of MerchantFeeSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> Get(int[] merchantFeeSetupIds);

        /// <summary>
        /// Custom fields are user defined form elements for IMerchantFeeSetupRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for MerchantFeeSetup.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding MerchantFeeSetup.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for MerchantFeeSetup.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of MerchantFeeSetup class to IMerchantFeeSetupRepository.
        /// </summary>
        /// <param name="merchantFeeSetup">The instance of MerchantFeeSetup class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic merchantFeeSetup, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of MerchantFeeSetup class to IMerchantFeeSetupRepository.
        /// </summary>
        /// <param name="merchantFeeSetup">The instance of MerchantFeeSetup class to insert.</param>
        object Add(dynamic merchantFeeSetup);

        /// <summary>
        /// Inserts or updates multiple instances of MerchantFeeSetup class to IMerchantFeeSetupRepository.;
        /// </summary>
        /// <param name="merchantFeeSetups">List of MerchantFeeSetup class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> merchantFeeSetups);


        /// <summary>
        /// Updates IMerchantFeeSetupRepository with an instance of MerchantFeeSetup class against the primary key value.
        /// </summary>
        /// <param name="merchantFeeSetup">The instance of MerchantFeeSetup class to update.</param>
        /// <param name="merchantFeeSetupId">The value of the column "merchant_fee_setup_id" which will be updated.</param>
        void Update(dynamic merchantFeeSetup, int merchantFeeSetupId);

        /// <summary>
        /// Deletes MerchantFeeSetup from  IMerchantFeeSetupRepository against the primary key value.
        /// </summary>
        /// <param name="merchantFeeSetupId">The value of the column "merchant_fee_setup_id" which will be deleted.</param>
        void Delete(int merchantFeeSetupId);

        /// <summary>
        /// Produces a paginated result of 10 MerchantFeeSetup classes.
        /// </summary>
        /// <returns>Returns the first page of collection of MerchantFeeSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 MerchantFeeSetup classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of MerchantFeeSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IMerchantFeeSetupRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of MerchantFeeSetup class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IMerchantFeeSetupRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of MerchantFeeSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IMerchantFeeSetupRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of MerchantFeeSetup class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IMerchantFeeSetupRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of MerchantFeeSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MerchantFeeSetup> GetFiltered(long pageNumber, string filterName);



    }
}