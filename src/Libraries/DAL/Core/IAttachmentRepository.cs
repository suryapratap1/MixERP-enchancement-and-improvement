// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAttachmentRepository
    {
        /// <summary>
        /// Counts the number of Attachment in IAttachmentRepository.
        /// </summary>
        /// <returns>Returns the count of IAttachmentRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Attachment. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Attachment.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attachment> GetAll();

        /// <summary>
        /// Returns all instances of Attachment to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Attachment.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Attachment against attachmentId. 
        /// </summary>
        /// <param name="attachmentId">The column "attachment_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Attachment.</returns>
        MixERP.Net.Entities.Core.Attachment Get(long attachmentId);

        /// <summary>
        /// Gets the first record of Attachment.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Attachment.</returns>
        MixERP.Net.Entities.Core.Attachment GetFirst();

        /// <summary>
        /// Gets the previous record of Attachment sorted by attachmentId. 
        /// </summary>
        /// <param name="attachmentId">The column "attachment_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Attachment.</returns>
        MixERP.Net.Entities.Core.Attachment GetPrevious(long attachmentId);

        /// <summary>
        /// Gets the next record of Attachment sorted by attachmentId. 
        /// </summary>
        /// <param name="attachmentId">The column "attachment_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Attachment.</returns>
        MixERP.Net.Entities.Core.Attachment GetNext(long attachmentId);

        /// <summary>
        /// Gets the last record of Attachment.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Attachment.</returns>
        MixERP.Net.Entities.Core.Attachment GetLast();

        /// <summary>
        /// Returns multiple instances of the Attachment against attachmentIds. 
        /// </summary>
        /// <param name="attachmentIds">Array of column "attachment_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Attachment.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attachment> Get(long[] attachmentIds);

        /// <summary>
        /// Custom fields are user defined form elements for IAttachmentRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Attachment.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Attachment.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Attachment.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Attachment class to IAttachmentRepository.
        /// </summary>
        /// <param name="attachment">The instance of Attachment class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic attachment, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Attachment class to IAttachmentRepository.
        /// </summary>
        /// <param name="attachment">The instance of Attachment class to insert.</param>
        object Add(dynamic attachment);

        /// <summary>
        /// Inserts or updates multiple instances of Attachment class to IAttachmentRepository.;
        /// </summary>
        /// <param name="attachments">List of Attachment class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> attachments);


        /// <summary>
        /// Updates IAttachmentRepository with an instance of Attachment class against the primary key value.
        /// </summary>
        /// <param name="attachment">The instance of Attachment class to update.</param>
        /// <param name="attachmentId">The value of the column "attachment_id" which will be updated.</param>
        void Update(dynamic attachment, long attachmentId);

        /// <summary>
        /// Deletes Attachment from  IAttachmentRepository against the primary key value.
        /// </summary>
        /// <param name="attachmentId">The value of the column "attachment_id" which will be deleted.</param>
        void Delete(long attachmentId);

        /// <summary>
        /// Produces a paginated result of 10 Attachment classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Attachment class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attachment> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Attachment classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Attachment class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attachment> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAttachmentRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Attachment class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IAttachmentRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Attachment class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attachment> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAttachmentRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Attachment class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IAttachmentRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Attachment class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attachment> GetFiltered(long pageNumber, string filterName);



    }
}