// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ILateFeeRepository
    {
        /// <summary>
        /// Counts the number of LateFee in ILateFeeRepository.
        /// </summary>
        /// <returns>Returns the count of ILateFeeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of LateFee. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LateFee.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFee> GetAll();

        /// <summary>
        /// Returns all instances of LateFee to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of LateFee.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the LateFee against lateFeeId. 
        /// </summary>
        /// <param name="lateFeeId">The column "late_fee_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of LateFee.</returns>
        MixERP.Net.Entities.Core.LateFee Get(int lateFeeId);

        /// <summary>
        /// Gets the first record of LateFee.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LateFee.</returns>
        MixERP.Net.Entities.Core.LateFee GetFirst();

        /// <summary>
        /// Gets the previous record of LateFee sorted by lateFeeId. 
        /// </summary>
        /// <param name="lateFeeId">The column "late_fee_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LateFee.</returns>
        MixERP.Net.Entities.Core.LateFee GetPrevious(int lateFeeId);

        /// <summary>
        /// Gets the next record of LateFee sorted by lateFeeId. 
        /// </summary>
        /// <param name="lateFeeId">The column "late_fee_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of LateFee.</returns>
        MixERP.Net.Entities.Core.LateFee GetNext(int lateFeeId);

        /// <summary>
        /// Gets the last record of LateFee.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of LateFee.</returns>
        MixERP.Net.Entities.Core.LateFee GetLast();

        /// <summary>
        /// Returns multiple instances of the LateFee against lateFeeIds. 
        /// </summary>
        /// <param name="lateFeeIds">Array of column "late_fee_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of LateFee.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFee> Get(int[] lateFeeIds);

        /// <summary>
        /// Custom fields are user defined form elements for ILateFeeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for LateFee.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding LateFee.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for LateFee.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of LateFee class to ILateFeeRepository.
        /// </summary>
        /// <param name="lateFee">The instance of LateFee class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic lateFee, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of LateFee class to ILateFeeRepository.
        /// </summary>
        /// <param name="lateFee">The instance of LateFee class to insert.</param>
        object Add(dynamic lateFee);

        /// <summary>
        /// Inserts or updates multiple instances of LateFee class to ILateFeeRepository.;
        /// </summary>
        /// <param name="lateFees">List of LateFee class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> lateFees);


        /// <summary>
        /// Updates ILateFeeRepository with an instance of LateFee class against the primary key value.
        /// </summary>
        /// <param name="lateFee">The instance of LateFee class to update.</param>
        /// <param name="lateFeeId">The value of the column "late_fee_id" which will be updated.</param>
        void Update(dynamic lateFee, int lateFeeId);

        /// <summary>
        /// Deletes LateFee from  ILateFeeRepository against the primary key value.
        /// </summary>
        /// <param name="lateFeeId">The value of the column "late_fee_id" which will be deleted.</param>
        void Delete(int lateFeeId);

        /// <summary>
        /// Produces a paginated result of 10 LateFee classes.
        /// </summary>
        /// <returns>Returns the first page of collection of LateFee class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFee> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 LateFee classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of LateFee class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFee> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ILateFeeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of LateFee class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ILateFeeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of LateFee class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFee> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ILateFeeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of LateFee class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ILateFeeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of LateFee class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.LateFee> GetFiltered(long pageNumber, string filterName);



    }
}