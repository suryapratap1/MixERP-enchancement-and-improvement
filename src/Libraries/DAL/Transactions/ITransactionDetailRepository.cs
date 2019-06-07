// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface ITransactionDetailRepository
    {
        /// <summary>
        /// Counts the number of TransactionDetail in ITransactionDetailRepository.
        /// </summary>
        /// <returns>Returns the count of ITransactionDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of TransactionDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TransactionDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetAll();

        /// <summary>
        /// Returns all instances of TransactionDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TransactionDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the TransactionDetail against transactionDetailId. 
        /// </summary>
        /// <param name="transactionDetailId">The column "transaction_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of TransactionDetail.</returns>
        MixERP.Net.Entities.Transactions.TransactionDetail Get(long transactionDetailId);

        /// <summary>
        /// Returns multiple instances of the TransactionDetail against transactionDetailIds. 
        /// </summary>
        /// <param name="transactionDetailIds">Array of column "transaction_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of TransactionDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> Get(long[] transactionDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for ITransactionDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for TransactionDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding TransactionDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for TransactionDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of TransactionDetail class to ITransactionDetailRepository.
        /// </summary>
        /// <param name="transactionDetail">The instance of TransactionDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic transactionDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of TransactionDetail class to ITransactionDetailRepository.
        /// </summary>
        /// <param name="transactionDetail">The instance of TransactionDetail class to insert.</param>
        object Add(dynamic transactionDetail);

        /// <summary>
        /// Inserts or updates multiple instances of TransactionDetail class to ITransactionDetailRepository.;
        /// </summary>
        /// <param name="transactionDetails">List of TransactionDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> transactionDetails);


        /// <summary>
        /// Updates ITransactionDetailRepository with an instance of TransactionDetail class against the primary key value.
        /// </summary>
        /// <param name="transactionDetail">The instance of TransactionDetail class to update.</param>
        /// <param name="transactionDetailId">The value of the column "transaction_detail_id" which will be updated.</param>
        void Update(dynamic transactionDetail, long transactionDetailId);

        /// <summary>
        /// Deletes TransactionDetail from  ITransactionDetailRepository against the primary key value.
        /// </summary>
        /// <param name="transactionDetailId">The value of the column "transaction_detail_id" which will be deleted.</param>
        void Delete(long transactionDetailId);

        /// <summary>
        /// Produces a paginated result of 10 TransactionDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of TransactionDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 TransactionDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of TransactionDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITransactionDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of TransactionDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ITransactionDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of TransactionDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITransactionDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of TransactionDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ITransactionDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of TransactionDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetFiltered(long pageNumber, string filterName);



    }
}