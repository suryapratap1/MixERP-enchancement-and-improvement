// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IRecurringInvoiceRepository
    {
        /// <summary>
        /// Counts the number of RecurringInvoice in IRecurringInvoiceRepository.
        /// </summary>
        /// <returns>Returns the count of IRecurringInvoiceRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of RecurringInvoice. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of RecurringInvoice.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetAll();

        /// <summary>
        /// Returns all instances of RecurringInvoice to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of RecurringInvoice.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the RecurringInvoice against recurringInvoiceId. 
        /// </summary>
        /// <param name="recurringInvoiceId">The column "recurring_invoice_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of RecurringInvoice.</returns>
        MixERP.Net.Entities.Core.RecurringInvoice Get(int recurringInvoiceId);

        /// <summary>
        /// Gets the first record of RecurringInvoice.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of RecurringInvoice.</returns>
        MixERP.Net.Entities.Core.RecurringInvoice GetFirst();

        /// <summary>
        /// Gets the previous record of RecurringInvoice sorted by recurringInvoiceId. 
        /// </summary>
        /// <param name="recurringInvoiceId">The column "recurring_invoice_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of RecurringInvoice.</returns>
        MixERP.Net.Entities.Core.RecurringInvoice GetPrevious(int recurringInvoiceId);

        /// <summary>
        /// Gets the next record of RecurringInvoice sorted by recurringInvoiceId. 
        /// </summary>
        /// <param name="recurringInvoiceId">The column "recurring_invoice_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of RecurringInvoice.</returns>
        MixERP.Net.Entities.Core.RecurringInvoice GetNext(int recurringInvoiceId);

        /// <summary>
        /// Gets the last record of RecurringInvoice.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of RecurringInvoice.</returns>
        MixERP.Net.Entities.Core.RecurringInvoice GetLast();

        /// <summary>
        /// Returns multiple instances of the RecurringInvoice against recurringInvoiceIds. 
        /// </summary>
        /// <param name="recurringInvoiceIds">Array of column "recurring_invoice_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of RecurringInvoice.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> Get(int[] recurringInvoiceIds);

        /// <summary>
        /// Custom fields are user defined form elements for IRecurringInvoiceRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for RecurringInvoice.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding RecurringInvoice.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for RecurringInvoice.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of RecurringInvoice class to IRecurringInvoiceRepository.
        /// </summary>
        /// <param name="recurringInvoice">The instance of RecurringInvoice class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic recurringInvoice, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of RecurringInvoice class to IRecurringInvoiceRepository.
        /// </summary>
        /// <param name="recurringInvoice">The instance of RecurringInvoice class to insert.</param>
        object Add(dynamic recurringInvoice);

        /// <summary>
        /// Inserts or updates multiple instances of RecurringInvoice class to IRecurringInvoiceRepository.;
        /// </summary>
        /// <param name="recurringInvoices">List of RecurringInvoice class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> recurringInvoices);


        /// <summary>
        /// Updates IRecurringInvoiceRepository with an instance of RecurringInvoice class against the primary key value.
        /// </summary>
        /// <param name="recurringInvoice">The instance of RecurringInvoice class to update.</param>
        /// <param name="recurringInvoiceId">The value of the column "recurring_invoice_id" which will be updated.</param>
        void Update(dynamic recurringInvoice, int recurringInvoiceId);

        /// <summary>
        /// Deletes RecurringInvoice from  IRecurringInvoiceRepository against the primary key value.
        /// </summary>
        /// <param name="recurringInvoiceId">The value of the column "recurring_invoice_id" which will be deleted.</param>
        void Delete(int recurringInvoiceId);

        /// <summary>
        /// Produces a paginated result of 10 RecurringInvoice classes.
        /// </summary>
        /// <returns>Returns the first page of collection of RecurringInvoice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 RecurringInvoice classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of RecurringInvoice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRecurringInvoiceRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of RecurringInvoice class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IRecurringInvoiceRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of RecurringInvoice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRecurringInvoiceRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of RecurringInvoice class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IRecurringInvoiceRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of RecurringInvoice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetFiltered(long pageNumber, string filterName);



    }
}