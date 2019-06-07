// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface ICustomerReceiptRepository
    {
        /// <summary>
        /// Counts the number of CustomerReceipt in ICustomerReceiptRepository.
        /// </summary>
        /// <returns>Returns the count of ICustomerReceiptRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CustomerReceipt. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CustomerReceipt.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetAll();

        /// <summary>
        /// Returns all instances of CustomerReceipt to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CustomerReceipt.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CustomerReceipt against receiptId. 
        /// </summary>
        /// <param name="receiptId">The column "receipt_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CustomerReceipt.</returns>
        MixERP.Net.Entities.Transactions.CustomerReceipt Get(long receiptId);

        /// <summary>
        /// Returns multiple instances of the CustomerReceipt against receiptIds. 
        /// </summary>
        /// <param name="receiptIds">Array of column "receipt_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CustomerReceipt.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> Get(long[] receiptIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICustomerReceiptRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CustomerReceipt.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CustomerReceipt.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CustomerReceipt.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CustomerReceipt class to ICustomerReceiptRepository.
        /// </summary>
        /// <param name="customerReceipt">The instance of CustomerReceipt class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic customerReceipt, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CustomerReceipt class to ICustomerReceiptRepository.
        /// </summary>
        /// <param name="customerReceipt">The instance of CustomerReceipt class to insert.</param>
        object Add(dynamic customerReceipt);

        /// <summary>
        /// Inserts or updates multiple instances of CustomerReceipt class to ICustomerReceiptRepository.;
        /// </summary>
        /// <param name="customerReceipts">List of CustomerReceipt class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> customerReceipts);


        /// <summary>
        /// Updates ICustomerReceiptRepository with an instance of CustomerReceipt class against the primary key value.
        /// </summary>
        /// <param name="customerReceipt">The instance of CustomerReceipt class to update.</param>
        /// <param name="receiptId">The value of the column "receipt_id" which will be updated.</param>
        void Update(dynamic customerReceipt, long receiptId);

        /// <summary>
        /// Deletes CustomerReceipt from  ICustomerReceiptRepository against the primary key value.
        /// </summary>
        /// <param name="receiptId">The value of the column "receipt_id" which will be deleted.</param>
        void Delete(long receiptId);

        /// <summary>
        /// Produces a paginated result of 10 CustomerReceipt classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CustomerReceipt class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CustomerReceipt classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CustomerReceipt class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICustomerReceiptRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CustomerReceipt class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICustomerReceiptRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CustomerReceipt class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICustomerReceiptRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CustomerReceipt class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICustomerReceiptRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CustomerReceipt class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetFiltered(long pageNumber, string filterName);



    }
}