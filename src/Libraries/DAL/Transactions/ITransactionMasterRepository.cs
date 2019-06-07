// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface ITransactionMasterRepository
    {
        /// <summary>
        /// Counts the number of TransactionMaster in ITransactionMasterRepository.
        /// </summary>
        /// <returns>Returns the count of ITransactionMasterRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of TransactionMaster. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TransactionMaster.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionMaster> GetAll();

        /// <summary>
        /// Returns all instances of TransactionMaster to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TransactionMaster.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the TransactionMaster against transactionMasterId. 
        /// </summary>
        /// <param name="transactionMasterId">The column "transaction_master_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of TransactionMaster.</returns>
        MixERP.Net.Entities.Transactions.TransactionMaster Get(long transactionMasterId);

        /// <summary>
        /// Returns multiple instances of the TransactionMaster against transactionMasterIds. 
        /// </summary>
        /// <param name="transactionMasterIds">Array of column "transaction_master_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of TransactionMaster.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionMaster> Get(long[] transactionMasterIds);

        /// <summary>
        /// Custom fields are user defined form elements for ITransactionMasterRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for TransactionMaster.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding TransactionMaster.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for TransactionMaster.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of TransactionMaster class to ITransactionMasterRepository.
        /// </summary>
        /// <param name="transactionMaster">The instance of TransactionMaster class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic transactionMaster, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of TransactionMaster class to ITransactionMasterRepository.
        /// </summary>
        /// <param name="transactionMaster">The instance of TransactionMaster class to insert.</param>
        object Add(dynamic transactionMaster);

        /// <summary>
        /// Inserts or updates multiple instances of TransactionMaster class to ITransactionMasterRepository.;
        /// </summary>
        /// <param name="transactionMasters">List of TransactionMaster class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> transactionMasters);


        /// <summary>
        /// Updates ITransactionMasterRepository with an instance of TransactionMaster class against the primary key value.
        /// </summary>
        /// <param name="transactionMaster">The instance of TransactionMaster class to update.</param>
        /// <param name="transactionMasterId">The value of the column "transaction_master_id" which will be updated.</param>
        void Update(dynamic transactionMaster, long transactionMasterId);

        /// <summary>
        /// Deletes TransactionMaster from  ITransactionMasterRepository against the primary key value.
        /// </summary>
        /// <param name="transactionMasterId">The value of the column "transaction_master_id" which will be deleted.</param>
        void Delete(long transactionMasterId);

        /// <summary>
        /// Produces a paginated result of 10 TransactionMaster classes.
        /// </summary>
        /// <returns>Returns the first page of collection of TransactionMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionMaster> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 TransactionMaster classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of TransactionMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionMaster> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITransactionMasterRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of TransactionMaster class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ITransactionMasterRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of TransactionMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionMaster> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITransactionMasterRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of TransactionMaster class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ITransactionMasterRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of TransactionMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.TransactionMaster> GetFiltered(long pageNumber, string filterName);


        void Verify(long transactionMasterId, short verificationStatusId, string reason);

    }
}