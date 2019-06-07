// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAccountMasterRepository
    {
        /// <summary>
        /// Counts the number of AccountMaster in IAccountMasterRepository.
        /// </summary>
        /// <returns>Returns the count of IAccountMasterRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of AccountMaster. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AccountMaster.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountMaster> GetAll();

        /// <summary>
        /// Returns all instances of AccountMaster to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AccountMaster.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the AccountMaster against accountMasterId. 
        /// </summary>
        /// <param name="accountMasterId">The column "account_master_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of AccountMaster.</returns>
        MixERP.Net.Entities.Core.AccountMaster Get(short accountMasterId);

        /// <summary>
        /// Gets the first record of AccountMaster.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AccountMaster.</returns>
        MixERP.Net.Entities.Core.AccountMaster GetFirst();

        /// <summary>
        /// Gets the previous record of AccountMaster sorted by accountMasterId. 
        /// </summary>
        /// <param name="accountMasterId">The column "account_master_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AccountMaster.</returns>
        MixERP.Net.Entities.Core.AccountMaster GetPrevious(short accountMasterId);

        /// <summary>
        /// Gets the next record of AccountMaster sorted by accountMasterId. 
        /// </summary>
        /// <param name="accountMasterId">The column "account_master_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AccountMaster.</returns>
        MixERP.Net.Entities.Core.AccountMaster GetNext(short accountMasterId);

        /// <summary>
        /// Gets the last record of AccountMaster.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AccountMaster.</returns>
        MixERP.Net.Entities.Core.AccountMaster GetLast();

        /// <summary>
        /// Returns multiple instances of the AccountMaster against accountMasterIds. 
        /// </summary>
        /// <param name="accountMasterIds">Array of column "account_master_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of AccountMaster.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountMaster> Get(short[] accountMasterIds);

        /// <summary>
        /// Custom fields are user defined form elements for IAccountMasterRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for AccountMaster.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding AccountMaster.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for AccountMaster.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of AccountMaster class to IAccountMasterRepository.
        /// </summary>
        /// <param name="accountMaster">The instance of AccountMaster class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic accountMaster, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of AccountMaster class to IAccountMasterRepository.
        /// </summary>
        /// <param name="accountMaster">The instance of AccountMaster class to insert.</param>
        object Add(dynamic accountMaster);

        /// <summary>
        /// Inserts or updates multiple instances of AccountMaster class to IAccountMasterRepository.;
        /// </summary>
        /// <param name="accountMasters">List of AccountMaster class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> accountMasters);


        /// <summary>
        /// Updates IAccountMasterRepository with an instance of AccountMaster class against the primary key value.
        /// </summary>
        /// <param name="accountMaster">The instance of AccountMaster class to update.</param>
        /// <param name="accountMasterId">The value of the column "account_master_id" which will be updated.</param>
        void Update(dynamic accountMaster, short accountMasterId);

        /// <summary>
        /// Deletes AccountMaster from  IAccountMasterRepository against the primary key value.
        /// </summary>
        /// <param name="accountMasterId">The value of the column "account_master_id" which will be deleted.</param>
        void Delete(short accountMasterId);

        /// <summary>
        /// Produces a paginated result of 10 AccountMaster classes.
        /// </summary>
        /// <returns>Returns the first page of collection of AccountMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountMaster> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 AccountMaster classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of AccountMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountMaster> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAccountMasterRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of AccountMaster class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IAccountMasterRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of AccountMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountMaster> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAccountMasterRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of AccountMaster class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IAccountMasterRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of AccountMaster class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AccountMaster> GetFiltered(long pageNumber, string filterName);



    }
}