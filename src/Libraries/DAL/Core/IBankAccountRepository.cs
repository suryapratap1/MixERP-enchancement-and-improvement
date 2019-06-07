// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IBankAccountRepository
    {
        /// <summary>
        /// Counts the number of BankAccount in IBankAccountRepository.
        /// </summary>
        /// <returns>Returns the count of IBankAccountRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of BankAccount. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of BankAccount.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccount> GetAll();

        /// <summary>
        /// Returns all instances of BankAccount to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of BankAccount.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the BankAccount against accountId. 
        /// </summary>
        /// <param name="accountId">The column "account_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of BankAccount.</returns>
        MixERP.Net.Entities.Core.BankAccount Get(long accountId);

        /// <summary>
        /// Gets the first record of BankAccount.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of BankAccount.</returns>
        MixERP.Net.Entities.Core.BankAccount GetFirst();

        /// <summary>
        /// Gets the previous record of BankAccount sorted by accountId. 
        /// </summary>
        /// <param name="accountId">The column "account_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of BankAccount.</returns>
        MixERP.Net.Entities.Core.BankAccount GetPrevious(long accountId);

        /// <summary>
        /// Gets the next record of BankAccount sorted by accountId. 
        /// </summary>
        /// <param name="accountId">The column "account_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of BankAccount.</returns>
        MixERP.Net.Entities.Core.BankAccount GetNext(long accountId);

        /// <summary>
        /// Gets the last record of BankAccount.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of BankAccount.</returns>
        MixERP.Net.Entities.Core.BankAccount GetLast();

        /// <summary>
        /// Returns multiple instances of the BankAccount against accountIds. 
        /// </summary>
        /// <param name="accountIds">Array of column "account_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of BankAccount.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccount> Get(long[] accountIds);

        /// <summary>
        /// Custom fields are user defined form elements for IBankAccountRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for BankAccount.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding BankAccount.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for BankAccount.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of BankAccount class to IBankAccountRepository.
        /// </summary>
        /// <param name="bankAccount">The instance of BankAccount class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic bankAccount, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of BankAccount class to IBankAccountRepository.
        /// </summary>
        /// <param name="bankAccount">The instance of BankAccount class to insert.</param>
        object Add(dynamic bankAccount);

        /// <summary>
        /// Inserts or updates multiple instances of BankAccount class to IBankAccountRepository.;
        /// </summary>
        /// <param name="bankAccounts">List of BankAccount class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> bankAccounts);


        /// <summary>
        /// Updates IBankAccountRepository with an instance of BankAccount class against the primary key value.
        /// </summary>
        /// <param name="bankAccount">The instance of BankAccount class to update.</param>
        /// <param name="bankAccountId">The value of the column "account_id" which will be updated.</param>
        void Update(dynamic bankAccount, long bankAccountId);

        /// <summary>
        /// Deletes BankAccount from  IBankAccountRepository against the primary key value.
        /// </summary>
        /// <param name="accountId">The value of the column "account_id" which will be deleted.</param>
        void Delete(long accountId);

        /// <summary>
        /// Produces a paginated result of 10 BankAccount classes.
        /// </summary>
        /// <returns>Returns the first page of collection of BankAccount class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccount> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 BankAccount classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of BankAccount class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccount> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IBankAccountRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of BankAccount class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IBankAccountRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of BankAccount class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccount> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IBankAccountRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of BankAccount class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IBankAccountRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of BankAccount class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.BankAccount> GetFiltered(long pageNumber, string filterName);



    }
}