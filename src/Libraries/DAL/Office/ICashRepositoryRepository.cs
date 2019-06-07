// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface ICashRepositoryRepository
    {
        /// <summary>
        /// Counts the number of CashRepository in ICashRepositoryRepository.
        /// </summary>
        /// <returns>Returns the count of ICashRepositoryRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CashRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CashRepository.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetAll();

        /// <summary>
        /// Returns all instances of CashRepository to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CashRepository.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CashRepository against cashRepositoryId. 
        /// </summary>
        /// <param name="cashRepositoryId">The column "cash_repository_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CashRepository.</returns>
        MixERP.Net.Entities.Office.CashRepository Get(int cashRepositoryId);

        /// <summary>
        /// Gets the first record of CashRepository.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CashRepository.</returns>
        MixERP.Net.Entities.Office.CashRepository GetFirst();

        /// <summary>
        /// Gets the previous record of CashRepository sorted by cashRepositoryId. 
        /// </summary>
        /// <param name="cashRepositoryId">The column "cash_repository_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CashRepository.</returns>
        MixERP.Net.Entities.Office.CashRepository GetPrevious(int cashRepositoryId);

        /// <summary>
        /// Gets the next record of CashRepository sorted by cashRepositoryId. 
        /// </summary>
        /// <param name="cashRepositoryId">The column "cash_repository_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CashRepository.</returns>
        MixERP.Net.Entities.Office.CashRepository GetNext(int cashRepositoryId);

        /// <summary>
        /// Gets the last record of CashRepository.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CashRepository.</returns>
        MixERP.Net.Entities.Office.CashRepository GetLast();

        /// <summary>
        /// Returns multiple instances of the CashRepository against cashRepositoryIds. 
        /// </summary>
        /// <param name="cashRepositoryIds">Array of column "cash_repository_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CashRepository.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepository> Get(int[] cashRepositoryIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICashRepositoryRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CashRepository.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CashRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CashRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CashRepository class to ICashRepositoryRepository.
        /// </summary>
        /// <param name="cashRepository">The instance of CashRepository class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic cashRepository, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CashRepository class to ICashRepositoryRepository.
        /// </summary>
        /// <param name="cashRepository">The instance of CashRepository class to insert.</param>
        object Add(dynamic cashRepository);

        /// <summary>
        /// Inserts or updates multiple instances of CashRepository class to ICashRepositoryRepository.;
        /// </summary>
        /// <param name="cashRepositories">List of CashRepository class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> cashRepositories);


        /// <summary>
        /// Updates ICashRepositoryRepository with an instance of CashRepository class against the primary key value.
        /// </summary>
        /// <param name="cashRepository">The instance of CashRepository class to update.</param>
        /// <param name="cashRepositoryId">The value of the column "cash_repository_id" which will be updated.</param>
        void Update(dynamic cashRepository, int cashRepositoryId);

        /// <summary>
        /// Deletes CashRepository from  ICashRepositoryRepository against the primary key value.
        /// </summary>
        /// <param name="cashRepositoryId">The value of the column "cash_repository_id" which will be deleted.</param>
        void Delete(int cashRepositoryId);

        /// <summary>
        /// Produces a paginated result of 10 CashRepository classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CashRepository class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CashRepository classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CashRepository class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICashRepositoryRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CashRepository class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICashRepositoryRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CashRepository class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICashRepositoryRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CashRepository class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICashRepositoryRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CashRepository class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.CashRepository> GetFiltered(long pageNumber, string filterName);



    }
}