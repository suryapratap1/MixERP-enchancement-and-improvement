// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Config.Data
{
    public interface IAttachmentFactoryRepository
    {
        /// <summary>
        /// Counts the number of AttachmentFactory in IAttachmentFactoryRepository.
        /// </summary>
        /// <returns>Returns the count of IAttachmentFactoryRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of AttachmentFactory. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AttachmentFactory.</returns>
        IEnumerable<MixERP.Net.Entities.Config.AttachmentFactory> GetAll();

        /// <summary>
        /// Returns all instances of AttachmentFactory to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of AttachmentFactory.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the AttachmentFactory against key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of AttachmentFactory.</returns>
        MixERP.Net.Entities.Config.AttachmentFactory Get(string key);

        /// <summary>
        /// Gets the first record of AttachmentFactory.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AttachmentFactory.</returns>
        MixERP.Net.Entities.Config.AttachmentFactory GetFirst();

        /// <summary>
        /// Gets the previous record of AttachmentFactory sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AttachmentFactory.</returns>
        MixERP.Net.Entities.Config.AttachmentFactory GetPrevious(string key);

        /// <summary>
        /// Gets the next record of AttachmentFactory sorted by key. 
        /// </summary>
        /// <param name="key">The column "key" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of AttachmentFactory.</returns>
        MixERP.Net.Entities.Config.AttachmentFactory GetNext(string key);

        /// <summary>
        /// Gets the last record of AttachmentFactory.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of AttachmentFactory.</returns>
        MixERP.Net.Entities.Config.AttachmentFactory GetLast();

        /// <summary>
        /// Returns multiple instances of the AttachmentFactory against keys. 
        /// </summary>
        /// <param name="keys">Array of column "key" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of AttachmentFactory.</returns>
        IEnumerable<MixERP.Net.Entities.Config.AttachmentFactory> Get(string[] keys);

        /// <summary>
        /// Custom fields are user defined form elements for IAttachmentFactoryRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for AttachmentFactory.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding AttachmentFactory.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for AttachmentFactory.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of AttachmentFactory class to IAttachmentFactoryRepository.
        /// </summary>
        /// <param name="attachmentFactory">The instance of AttachmentFactory class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic attachmentFactory, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of AttachmentFactory class to IAttachmentFactoryRepository.
        /// </summary>
        /// <param name="attachmentFactory">The instance of AttachmentFactory class to insert.</param>
        object Add(dynamic attachmentFactory);

        /// <summary>
        /// Inserts or updates multiple instances of AttachmentFactory class to IAttachmentFactoryRepository.;
        /// </summary>
        /// <param name="attachmentFactories">List of AttachmentFactory class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> attachmentFactories);


        /// <summary>
        /// Updates IAttachmentFactoryRepository with an instance of AttachmentFactory class against the primary key value.
        /// </summary>
        /// <param name="attachmentFactory">The instance of AttachmentFactory class to update.</param>
        /// <param name="key">The value of the column "key" which will be updated.</param>
        void Update(dynamic attachmentFactory, string key);

        /// <summary>
        /// Deletes AttachmentFactory from  IAttachmentFactoryRepository against the primary key value.
        /// </summary>
        /// <param name="key">The value of the column "key" which will be deleted.</param>
        void Delete(string key);

        /// <summary>
        /// Produces a paginated result of 10 AttachmentFactory classes.
        /// </summary>
        /// <returns>Returns the first page of collection of AttachmentFactory class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.AttachmentFactory> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 AttachmentFactory classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of AttachmentFactory class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.AttachmentFactory> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAttachmentFactoryRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of AttachmentFactory class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IAttachmentFactoryRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of AttachmentFactory class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.AttachmentFactory> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAttachmentFactoryRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of AttachmentFactory class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IAttachmentFactoryRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of AttachmentFactory class.</returns>
        IEnumerable<MixERP.Net.Entities.Config.AttachmentFactory> GetFiltered(long pageNumber, string filterName);



    }
}