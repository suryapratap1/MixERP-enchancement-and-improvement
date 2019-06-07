// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPaymentTermRepository
    {
        /// <summary>
        /// Counts the number of PaymentTerm in IPaymentTermRepository.
        /// </summary>
        /// <returns>Returns the count of IPaymentTermRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of PaymentTerm. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PaymentTerm.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetAll();

        /// <summary>
        /// Returns all instances of PaymentTerm to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PaymentTerm.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the PaymentTerm against paymentTermId. 
        /// </summary>
        /// <param name="paymentTermId">The column "payment_term_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of PaymentTerm.</returns>
        MixERP.Net.Entities.Core.PaymentTerm Get(int paymentTermId);

        /// <summary>
        /// Gets the first record of PaymentTerm.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PaymentTerm.</returns>
        MixERP.Net.Entities.Core.PaymentTerm GetFirst();

        /// <summary>
        /// Gets the previous record of PaymentTerm sorted by paymentTermId. 
        /// </summary>
        /// <param name="paymentTermId">The column "payment_term_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PaymentTerm.</returns>
        MixERP.Net.Entities.Core.PaymentTerm GetPrevious(int paymentTermId);

        /// <summary>
        /// Gets the next record of PaymentTerm sorted by paymentTermId. 
        /// </summary>
        /// <param name="paymentTermId">The column "payment_term_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PaymentTerm.</returns>
        MixERP.Net.Entities.Core.PaymentTerm GetNext(int paymentTermId);

        /// <summary>
        /// Gets the last record of PaymentTerm.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PaymentTerm.</returns>
        MixERP.Net.Entities.Core.PaymentTerm GetLast();

        /// <summary>
        /// Returns multiple instances of the PaymentTerm against paymentTermIds. 
        /// </summary>
        /// <param name="paymentTermIds">Array of column "payment_term_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of PaymentTerm.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> Get(int[] paymentTermIds);

        /// <summary>
        /// Custom fields are user defined form elements for IPaymentTermRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for PaymentTerm.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding PaymentTerm.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for PaymentTerm.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of PaymentTerm class to IPaymentTermRepository.
        /// </summary>
        /// <param name="paymentTerm">The instance of PaymentTerm class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic paymentTerm, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of PaymentTerm class to IPaymentTermRepository.
        /// </summary>
        /// <param name="paymentTerm">The instance of PaymentTerm class to insert.</param>
        object Add(dynamic paymentTerm);

        /// <summary>
        /// Inserts or updates multiple instances of PaymentTerm class to IPaymentTermRepository.;
        /// </summary>
        /// <param name="paymentTerms">List of PaymentTerm class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> paymentTerms);


        /// <summary>
        /// Updates IPaymentTermRepository with an instance of PaymentTerm class against the primary key value.
        /// </summary>
        /// <param name="paymentTerm">The instance of PaymentTerm class to update.</param>
        /// <param name="paymentTermId">The value of the column "payment_term_id" which will be updated.</param>
        void Update(dynamic paymentTerm, int paymentTermId);

        /// <summary>
        /// Deletes PaymentTerm from  IPaymentTermRepository against the primary key value.
        /// </summary>
        /// <param name="paymentTermId">The value of the column "payment_term_id" which will be deleted.</param>
        void Delete(int paymentTermId);

        /// <summary>
        /// Produces a paginated result of 10 PaymentTerm classes.
        /// </summary>
        /// <returns>Returns the first page of collection of PaymentTerm class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 PaymentTerm classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of PaymentTerm class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPaymentTermRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of PaymentTerm class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IPaymentTermRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of PaymentTerm class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPaymentTermRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of PaymentTerm class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IPaymentTermRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of PaymentTerm class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetFiltered(long pageNumber, string filterName);



    }
}