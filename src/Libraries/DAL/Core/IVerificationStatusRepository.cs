// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IVerificationStatusRepository
    {
        /// <summary>
        /// Counts the number of VerificationStatus in IVerificationStatusRepository.
        /// </summary>
        /// <returns>Returns the count of IVerificationStatusRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of VerificationStatus. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of VerificationStatus.</returns>
        IEnumerable<MixERP.Net.Entities.Core.VerificationStatus> GetAll();

        /// <summary>
        /// Returns all instances of VerificationStatus to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of VerificationStatus.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the VerificationStatus against verificationStatusId. 
        /// </summary>
        /// <param name="verificationStatusId">The column "verification_status_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of VerificationStatus.</returns>
        MixERP.Net.Entities.Core.VerificationStatus Get(short verificationStatusId);

        /// <summary>
        /// Gets the first record of VerificationStatus.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of VerificationStatus.</returns>
        MixERP.Net.Entities.Core.VerificationStatus GetFirst();

        /// <summary>
        /// Gets the previous record of VerificationStatus sorted by verificationStatusId. 
        /// </summary>
        /// <param name="verificationStatusId">The column "verification_status_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of VerificationStatus.</returns>
        MixERP.Net.Entities.Core.VerificationStatus GetPrevious(short verificationStatusId);

        /// <summary>
        /// Gets the next record of VerificationStatus sorted by verificationStatusId. 
        /// </summary>
        /// <param name="verificationStatusId">The column "verification_status_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of VerificationStatus.</returns>
        MixERP.Net.Entities.Core.VerificationStatus GetNext(short verificationStatusId);

        /// <summary>
        /// Gets the last record of VerificationStatus.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of VerificationStatus.</returns>
        MixERP.Net.Entities.Core.VerificationStatus GetLast();

        /// <summary>
        /// Returns multiple instances of the VerificationStatus against verificationStatusIds. 
        /// </summary>
        /// <param name="verificationStatusIds">Array of column "verification_status_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of VerificationStatus.</returns>
        IEnumerable<MixERP.Net.Entities.Core.VerificationStatus> Get(short[] verificationStatusIds);

        /// <summary>
        /// Custom fields are user defined form elements for IVerificationStatusRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for VerificationStatus.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding VerificationStatus.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for VerificationStatus.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of VerificationStatus class to IVerificationStatusRepository.
        /// </summary>
        /// <param name="verificationStatus">The instance of VerificationStatus class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic verificationStatus, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of VerificationStatus class to IVerificationStatusRepository.
        /// </summary>
        /// <param name="verificationStatus">The instance of VerificationStatus class to insert.</param>
        object Add(dynamic verificationStatus);

        /// <summary>
        /// Inserts or updates multiple instances of VerificationStatus class to IVerificationStatusRepository.;
        /// </summary>
        /// <param name="verificationStatuses">List of VerificationStatus class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> verificationStatuses);


        /// <summary>
        /// Updates IVerificationStatusRepository with an instance of VerificationStatus class against the primary key value.
        /// </summary>
        /// <param name="verificationStatus">The instance of VerificationStatus class to update.</param>
        /// <param name="verificationStatusId">The value of the column "verification_status_id" which will be updated.</param>
        void Update(dynamic verificationStatus, short verificationStatusId);

        /// <summary>
        /// Deletes VerificationStatus from  IVerificationStatusRepository against the primary key value.
        /// </summary>
        /// <param name="verificationStatusId">The value of the column "verification_status_id" which will be deleted.</param>
        void Delete(short verificationStatusId);

        /// <summary>
        /// Produces a paginated result of 10 VerificationStatus classes.
        /// </summary>
        /// <returns>Returns the first page of collection of VerificationStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.VerificationStatus> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 VerificationStatus classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of VerificationStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.VerificationStatus> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IVerificationStatusRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of VerificationStatus class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IVerificationStatusRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of VerificationStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.VerificationStatus> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IVerificationStatusRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of VerificationStatus class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IVerificationStatusRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of VerificationStatus class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.VerificationStatus> GetFiltered(long pageNumber, string filterName);



    }
}