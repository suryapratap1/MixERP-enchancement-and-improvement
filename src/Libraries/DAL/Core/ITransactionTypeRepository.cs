// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ITransactionTypeRepository
    {
        /// <summary>
        /// Counts the number of TransactionType in ITransactionTypeRepository.
        /// </summary>
        /// <returns>Returns the count of ITransactionTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of TransactionType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TransactionType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TransactionType> GetAll();

        /// <summary>
        /// Returns all instances of TransactionType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of TransactionType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the TransactionType against transactionTypeId. 
        /// </summary>
        /// <param name="transactionTypeId">The column "transaction_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of TransactionType.</returns>
        MixERP.Net.Entities.Core.TransactionType Get(short transactionTypeId);

        /// <summary>
        /// Gets the first record of TransactionType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of TransactionType.</returns>
        MixERP.Net.Entities.Core.TransactionType GetFirst();

        /// <summary>
        /// Gets the previous record of TransactionType sorted by transactionTypeId. 
        /// </summary>
        /// <param name="transactionTypeId">The column "transaction_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of TransactionType.</returns>
        MixERP.Net.Entities.Core.TransactionType GetPrevious(short transactionTypeId);

        /// <summary>
        /// Gets the next record of TransactionType sorted by transactionTypeId. 
        /// </summary>
        /// <param name="transactionTypeId">The column "transaction_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of TransactionType.</returns>
        MixERP.Net.Entities.Core.TransactionType GetNext(short transactionTypeId);

        /// <summary>
        /// Gets the last record of TransactionType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of TransactionType.</returns>
        MixERP.Net.Entities.Core.TransactionType GetLast();

        /// <summary>
        /// Returns multiple instances of the TransactionType against transactionTypeIds. 
        /// </summary>
        /// <param name="transactionTypeIds">Array of column "transaction_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of TransactionType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TransactionType> Get(short[] transactionTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for ITransactionTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for TransactionType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding TransactionType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for TransactionType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of TransactionType class to ITransactionTypeRepository.
        /// </summary>
        /// <param name="transactionType">The instance of TransactionType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic transactionType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of TransactionType class to ITransactionTypeRepository.
        /// </summary>
        /// <param name="transactionType">The instance of TransactionType class to insert.</param>
        object Add(dynamic transactionType);

        /// <summary>
        /// Inserts or updates multiple instances of TransactionType class to ITransactionTypeRepository.;
        /// </summary>
        /// <param name="transactionTypes">List of TransactionType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> transactionTypes);


        /// <summary>
        /// Updates ITransactionTypeRepository with an instance of TransactionType class against the primary key value.
        /// </summary>
        /// <param name="transactionType">The instance of TransactionType class to update.</param>
        /// <param name="transactionTypeId">The value of the column "transaction_type_id" which will be updated.</param>
        void Update(dynamic transactionType, short transactionTypeId);

        /// <summary>
        /// Deletes TransactionType from  ITransactionTypeRepository against the primary key value.
        /// </summary>
        /// <param name="transactionTypeId">The value of the column "transaction_type_id" which will be deleted.</param>
        void Delete(short transactionTypeId);

        /// <summary>
        /// Produces a paginated result of 10 TransactionType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of TransactionType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TransactionType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 TransactionType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of TransactionType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TransactionType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ITransactionTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of TransactionType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ITransactionTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of TransactionType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TransactionType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ITransactionTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of TransactionType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ITransactionTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of TransactionType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.TransactionType> GetFiltered(long pageNumber, string filterName);



    }
}