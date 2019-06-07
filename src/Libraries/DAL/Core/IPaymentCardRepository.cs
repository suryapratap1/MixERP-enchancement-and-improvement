// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPaymentCardRepository
    {
        /// <summary>
        /// Counts the number of PaymentCard in IPaymentCardRepository.
        /// </summary>
        /// <returns>Returns the count of IPaymentCardRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of PaymentCard. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PaymentCard.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentCard> GetAll();

        /// <summary>
        /// Returns all instances of PaymentCard to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PaymentCard.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the PaymentCard against paymentCardId. 
        /// </summary>
        /// <param name="paymentCardId">The column "payment_card_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of PaymentCard.</returns>
        MixERP.Net.Entities.Core.PaymentCard Get(int paymentCardId);

        /// <summary>
        /// Gets the first record of PaymentCard.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PaymentCard.</returns>
        MixERP.Net.Entities.Core.PaymentCard GetFirst();

        /// <summary>
        /// Gets the previous record of PaymentCard sorted by paymentCardId. 
        /// </summary>
        /// <param name="paymentCardId">The column "payment_card_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PaymentCard.</returns>
        MixERP.Net.Entities.Core.PaymentCard GetPrevious(int paymentCardId);

        /// <summary>
        /// Gets the next record of PaymentCard sorted by paymentCardId. 
        /// </summary>
        /// <param name="paymentCardId">The column "payment_card_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PaymentCard.</returns>
        MixERP.Net.Entities.Core.PaymentCard GetNext(int paymentCardId);

        /// <summary>
        /// Gets the last record of PaymentCard.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PaymentCard.</returns>
        MixERP.Net.Entities.Core.PaymentCard GetLast();

        /// <summary>
        /// Returns multiple instances of the PaymentCard against paymentCardIds. 
        /// </summary>
        /// <param name="paymentCardIds">Array of column "payment_card_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of PaymentCard.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentCard> Get(int[] paymentCardIds);

        /// <summary>
        /// Custom fields are user defined form elements for IPaymentCardRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for PaymentCard.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding PaymentCard.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for PaymentCard.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of PaymentCard class to IPaymentCardRepository.
        /// </summary>
        /// <param name="paymentCard">The instance of PaymentCard class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic paymentCard, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of PaymentCard class to IPaymentCardRepository.
        /// </summary>
        /// <param name="paymentCard">The instance of PaymentCard class to insert.</param>
        object Add(dynamic paymentCard);

        /// <summary>
        /// Inserts or updates multiple instances of PaymentCard class to IPaymentCardRepository.;
        /// </summary>
        /// <param name="paymentCards">List of PaymentCard class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> paymentCards);


        /// <summary>
        /// Updates IPaymentCardRepository with an instance of PaymentCard class against the primary key value.
        /// </summary>
        /// <param name="paymentCard">The instance of PaymentCard class to update.</param>
        /// <param name="paymentCardId">The value of the column "payment_card_id" which will be updated.</param>
        void Update(dynamic paymentCard, int paymentCardId);

        /// <summary>
        /// Deletes PaymentCard from  IPaymentCardRepository against the primary key value.
        /// </summary>
        /// <param name="paymentCardId">The value of the column "payment_card_id" which will be deleted.</param>
        void Delete(int paymentCardId);

        /// <summary>
        /// Produces a paginated result of 10 PaymentCard classes.
        /// </summary>
        /// <returns>Returns the first page of collection of PaymentCard class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentCard> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 PaymentCard classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of PaymentCard class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentCard> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPaymentCardRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of PaymentCard class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IPaymentCardRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of PaymentCard class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentCard> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPaymentCardRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of PaymentCard class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IPaymentCardRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of PaymentCard class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PaymentCard> GetFiltered(long pageNumber, string filterName);



    }
}