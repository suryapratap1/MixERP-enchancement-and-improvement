// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IRecurringInvoiceSetupRepository
    {
        /// <summary>
        /// Counts the number of RecurringInvoiceSetup in IRecurringInvoiceSetupRepository.
        /// </summary>
        /// <returns>Returns the count of IRecurringInvoiceSetupRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of RecurringInvoiceSetup. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of RecurringInvoiceSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> GetAll();

        /// <summary>
        /// Returns all instances of RecurringInvoiceSetup to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of RecurringInvoiceSetup.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the RecurringInvoiceSetup against recurringInvoiceSetupId. 
        /// </summary>
        /// <param name="recurringInvoiceSetupId">The column "recurring_invoice_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of RecurringInvoiceSetup.</returns>
        MixERP.Net.Entities.Core.RecurringInvoiceSetup Get(int recurringInvoiceSetupId);

        /// <summary>
        /// Gets the first record of RecurringInvoiceSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of RecurringInvoiceSetup.</returns>
        MixERP.Net.Entities.Core.RecurringInvoiceSetup GetFirst();

        /// <summary>
        /// Gets the previous record of RecurringInvoiceSetup sorted by recurringInvoiceSetupId. 
        /// </summary>
        /// <param name="recurringInvoiceSetupId">The column "recurring_invoice_setup_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of RecurringInvoiceSetup.</returns>
        MixERP.Net.Entities.Core.RecurringInvoiceSetup GetPrevious(int recurringInvoiceSetupId);

        /// <summary>
        /// Gets the next record of RecurringInvoiceSetup sorted by recurringInvoiceSetupId. 
        /// </summary>
        /// <param name="recurringInvoiceSetupId">The column "recurring_invoice_setup_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of RecurringInvoiceSetup.</returns>
        MixERP.Net.Entities.Core.RecurringInvoiceSetup GetNext(int recurringInvoiceSetupId);

        /// <summary>
        /// Gets the last record of RecurringInvoiceSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of RecurringInvoiceSetup.</returns>
        MixERP.Net.Entities.Core.RecurringInvoiceSetup GetLast();

        /// <summary>
        /// Returns multiple instances of the RecurringInvoiceSetup against recurringInvoiceSetupIds. 
        /// </summary>
        /// <param name="recurringInvoiceSetupIds">Array of column "recurring_invoice_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of RecurringInvoiceSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> Get(int[] recurringInvoiceSetupIds);

        /// <summary>
        /// Custom fields are user defined form elements for IRecurringInvoiceSetupRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for RecurringInvoiceSetup.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding RecurringInvoiceSetup.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for RecurringInvoiceSetup.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of RecurringInvoiceSetup class to IRecurringInvoiceSetupRepository.
        /// </summary>
        /// <param name="recurringInvoiceSetup">The instance of RecurringInvoiceSetup class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic recurringInvoiceSetup, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of RecurringInvoiceSetup class to IRecurringInvoiceSetupRepository.
        /// </summary>
        /// <param name="recurringInvoiceSetup">The instance of RecurringInvoiceSetup class to insert.</param>
        object Add(dynamic recurringInvoiceSetup);

        /// <summary>
        /// Inserts or updates multiple instances of RecurringInvoiceSetup class to IRecurringInvoiceSetupRepository.;
        /// </summary>
        /// <param name="recurringInvoiceSetups">List of RecurringInvoiceSetup class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> recurringInvoiceSetups);


        /// <summary>
        /// Updates IRecurringInvoiceSetupRepository with an instance of RecurringInvoiceSetup class against the primary key value.
        /// </summary>
        /// <param name="recurringInvoiceSetup">The instance of RecurringInvoiceSetup class to update.</param>
        /// <param name="recurringInvoiceSetupId">The value of the column "recurring_invoice_setup_id" which will be updated.</param>
        void Update(dynamic recurringInvoiceSetup, int recurringInvoiceSetupId);

        /// <summary>
        /// Deletes RecurringInvoiceSetup from  IRecurringInvoiceSetupRepository against the primary key value.
        /// </summary>
        /// <param name="recurringInvoiceSetupId">The value of the column "recurring_invoice_setup_id" which will be deleted.</param>
        void Delete(int recurringInvoiceSetupId);

        /// <summary>
        /// Produces a paginated result of 10 RecurringInvoiceSetup classes.
        /// </summary>
        /// <returns>Returns the first page of collection of RecurringInvoiceSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 RecurringInvoiceSetup classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of RecurringInvoiceSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRecurringInvoiceSetupRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of RecurringInvoiceSetup class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IRecurringInvoiceSetupRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of RecurringInvoiceSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRecurringInvoiceSetupRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of RecurringInvoiceSetup class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IRecurringInvoiceSetupRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of RecurringInvoiceSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> GetFiltered(long pageNumber, string filterName);



    }
}