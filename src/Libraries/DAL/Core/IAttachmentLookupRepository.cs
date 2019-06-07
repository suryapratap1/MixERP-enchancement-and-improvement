// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAttachmentLookupRepository
    {
        /// <summary>
        /// Counts the number of AttachmentLookup in IAttachmentLookupRepository.
        /// </summary>
        /// <returns>Returns the count of IAttachmentLookupRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of AttachmentLookup. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AttachmentLookup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetAll();

        /// <summary>
        /// Returns all instances of AttachmentLookup to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AttachmentLookup.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the AttachmentLookup against attachmentLookupId. 
        /// </summary>
        /// <param name="attachmentLookupId">The column "attachment_lookup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of AttachmentLookup.</returns>
        MixERP.Net.Entities.Core.AttachmentLookup Get(int attachmentLookupId);

        /// <summary>
        /// Gets the first record of AttachmentLookup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AttachmentLookup.</returns>
        MixERP.Net.Entities.Core.AttachmentLookup GetFirst();

        /// <summary>
        /// Gets the previous record of AttachmentLookup sorted by attachmentLookupId. 
        /// </summary>
        /// <param name="attachmentLookupId">The column "attachment_lookup_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AttachmentLookup.</returns>
        MixERP.Net.Entities.Core.AttachmentLookup GetPrevious(int attachmentLookupId);

        /// <summary>
        /// Gets the next record of AttachmentLookup sorted by attachmentLookupId. 
        /// </summary>
        /// <param name="attachmentLookupId">The column "attachment_lookup_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AttachmentLookup.</returns>
        MixERP.Net.Entities.Core.AttachmentLookup GetNext(int attachmentLookupId);

        /// <summary>
        /// Gets the last record of AttachmentLookup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AttachmentLookup.</returns>
        MixERP.Net.Entities.Core.AttachmentLookup GetLast();

        /// <summary>
        /// Returns multiple instances of the AttachmentLookup against attachmentLookupIds. 
        /// </summary>
        /// <param name="attachmentLookupIds">Array of column "attachment_lookup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of AttachmentLookup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> Get(int[] attachmentLookupIds);

        /// <summary>
        /// Custom fields are user defined form elements for IAttachmentLookupRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for AttachmentLookup.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding AttachmentLookup.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for AttachmentLookup.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of AttachmentLookup class to IAttachmentLookupRepository.
        /// </summary>
        /// <param name="attachmentLookup">The instance of AttachmentLookup class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic attachmentLookup, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of AttachmentLookup class to IAttachmentLookupRepository.
        /// </summary>
        /// <param name="attachmentLookup">The instance of AttachmentLookup class to insert.</param>
        object Add(dynamic attachmentLookup);

        /// <summary>
        /// Inserts or updates multiple instances of AttachmentLookup class to IAttachmentLookupRepository.;
        /// </summary>
        /// <param name="attachmentLookups">List of AttachmentLookup class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> attachmentLookups);


        /// <summary>
        /// Updates IAttachmentLookupRepository with an instance of AttachmentLookup class against the primary key value.
        /// </summary>
        /// <param name="attachmentLookup">The instance of AttachmentLookup class to update.</param>
        /// <param name="attachmentLookupId">The value of the column "attachment_lookup_id" which will be updated.</param>
        void Update(dynamic attachmentLookup, int attachmentLookupId);

        /// <summary>
        /// Deletes AttachmentLookup from  IAttachmentLookupRepository against the primary key value.
        /// </summary>
        /// <param name="attachmentLookupId">The value of the column "attachment_lookup_id" which will be deleted.</param>
        void Delete(int attachmentLookupId);

        /// <summary>
        /// Produces a paginated result of 10 AttachmentLookup classes.
        /// </summary>
        /// <returns>Returns the first page of collection of AttachmentLookup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 AttachmentLookup classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of AttachmentLookup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAttachmentLookupRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of AttachmentLookup class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IAttachmentLookupRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of AttachmentLookup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAttachmentLookupRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of AttachmentLookup class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IAttachmentLookupRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of AttachmentLookup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.AttachmentLookup> GetFiltered(long pageNumber, string filterName);



    }
}