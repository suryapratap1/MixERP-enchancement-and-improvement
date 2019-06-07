// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Policy.Data
{
    public interface ILockOutRepository
    {
        /// <summary>
        /// Counts the number of LockOut in ILockOutRepository.
        /// </summary>
        /// <returns>Returns the count of ILockOutRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of LockOut. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LockOut.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetAll();

        /// <summary>
        /// Returns all instances of LockOut to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LockOut.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the LockOut against lockOutId. 
        /// </summary>
        /// <param name="lockOutId">The column "lock_out_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of LockOut.</returns>
        MixERP.Net.Entities.Policy.LockOut Get(long lockOutId);

        /// <summary>
        /// Gets the first record of LockOut.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LockOut.</returns>
        MixERP.Net.Entities.Policy.LockOut GetFirst();

        /// <summary>
        /// Gets the previous record of LockOut sorted by lockOutId. 
        /// </summary>
        /// <param name="lockOutId">The column "lock_out_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LockOut.</returns>
        MixERP.Net.Entities.Policy.LockOut GetPrevious(long lockOutId);

        /// <summary>
        /// Gets the next record of LockOut sorted by lockOutId. 
        /// </summary>
        /// <param name="lockOutId">The column "lock_out_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LockOut.</returns>
        MixERP.Net.Entities.Policy.LockOut GetNext(long lockOutId);

        /// <summary>
        /// Gets the last record of LockOut.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LockOut.</returns>
        MixERP.Net.Entities.Policy.LockOut GetLast();

        /// <summary>
        /// Returns multiple instances of the LockOut against lockOutIds. 
        /// </summary>
        /// <param name="lockOutIds">Array of column "lock_out_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of LockOut.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.LockOut> Get(long[] lockOutIds);

        /// <summary>
        /// Custom fields are user defined form elements for ILockOutRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for LockOut.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding LockOut.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for LockOut.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of LockOut class to ILockOutRepository.
        /// </summary>
        /// <param name="lockOut">The instance of LockOut class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic lockOut, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of LockOut class to ILockOutRepository.
        /// </summary>
        /// <param name="lockOut">The instance of LockOut class to insert.</param>
        object Add(dynamic lockOut);

        /// <summary>
        /// Inserts or updates multiple instances of LockOut class to ILockOutRepository.;
        /// </summary>
        /// <param name="lockOuts">List of LockOut class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> lockOuts);


        /// <summary>
        /// Updates ILockOutRepository with an instance of LockOut class against the primary key value.
        /// </summary>
        /// <param name="lockOut">The instance of LockOut class to update.</param>
        /// <param name="lockOutId">The value of the column "lock_out_id" which will be updated.</param>
        void Update(dynamic lockOut, long lockOutId);

        /// <summary>
        /// Deletes LockOut from  ILockOutRepository against the primary key value.
        /// </summary>
        /// <param name="lockOutId">The value of the column "lock_out_id" which will be deleted.</param>
        void Delete(long lockOutId);

        /// <summary>
        /// Produces a paginated result of 10 LockOut classes.
        /// </summary>
        /// <returns>Returns the first page of collection of LockOut class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 LockOut classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of LockOut class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILockOutRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of LockOut class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ILockOutRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of LockOut class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILockOutRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of LockOut class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ILockOutRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of LockOut class.</returns>
        IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetFiltered(long pageNumber, string filterName);



    }
}