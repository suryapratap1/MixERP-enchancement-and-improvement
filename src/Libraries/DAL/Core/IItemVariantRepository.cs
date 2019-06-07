// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemVariantRepository
    {
        /// <summary>
        /// Counts the number of ItemVariant in IItemVariantRepository.
        /// </summary>
        /// <returns>Returns the count of IItemVariantRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ItemVariant. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ItemVariant.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemVariant> GetAll();

        /// <summary>
        /// Returns all instances of ItemVariant to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ItemVariant.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ItemVariant against itemVariantId. 
        /// </summary>
        /// <param name="itemVariantId">The column "item_variant_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemVariant.</returns>
        MixERP.Net.Entities.Core.ItemVariant Get(int itemVariantId);

        /// <summary>
        /// Gets the first record of ItemVariant.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ItemVariant.</returns>
        MixERP.Net.Entities.Core.ItemVariant GetFirst();

        /// <summary>
        /// Gets the previous record of ItemVariant sorted by itemVariantId. 
        /// </summary>
        /// <param name="itemVariantId">The column "item_variant_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemVariant.</returns>
        MixERP.Net.Entities.Core.ItemVariant GetPrevious(int itemVariantId);

        /// <summary>
        /// Gets the next record of ItemVariant sorted by itemVariantId. 
        /// </summary>
        /// <param name="itemVariantId">The column "item_variant_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemVariant.</returns>
        MixERP.Net.Entities.Core.ItemVariant GetNext(int itemVariantId);

        /// <summary>
        /// Gets the last record of ItemVariant.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ItemVariant.</returns>
        MixERP.Net.Entities.Core.ItemVariant GetLast();

        /// <summary>
        /// Returns multiple instances of the ItemVariant against itemVariantIds. 
        /// </summary>
        /// <param name="itemVariantIds">Array of column "item_variant_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ItemVariant.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemVariant> Get(int[] itemVariantIds);

        /// <summary>
        /// Custom fields are user defined form elements for IItemVariantRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ItemVariant.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ItemVariant.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ItemVariant.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ItemVariant class to IItemVariantRepository.
        /// </summary>
        /// <param name="itemVariant">The instance of ItemVariant class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic itemVariant, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ItemVariant class to IItemVariantRepository.
        /// </summary>
        /// <param name="itemVariant">The instance of ItemVariant class to insert.</param>
        object Add(dynamic itemVariant);

        /// <summary>
        /// Inserts or updates multiple instances of ItemVariant class to IItemVariantRepository.;
        /// </summary>
        /// <param name="itemVariants">List of ItemVariant class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> itemVariants);


        /// <summary>
        /// Updates IItemVariantRepository with an instance of ItemVariant class against the primary key value.
        /// </summary>
        /// <param name="itemVariant">The instance of ItemVariant class to update.</param>
        /// <param name="itemVariantId">The value of the column "item_variant_id" which will be updated.</param>
        void Update(dynamic itemVariant, int itemVariantId);

        /// <summary>
        /// Deletes ItemVariant from  IItemVariantRepository against the primary key value.
        /// </summary>
        /// <param name="itemVariantId">The value of the column "item_variant_id" which will be deleted.</param>
        void Delete(int itemVariantId);

        /// <summary>
        /// Produces a paginated result of 10 ItemVariant classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ItemVariant class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemVariant> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ItemVariant classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ItemVariant class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemVariant> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemVariantRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ItemVariant class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IItemVariantRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ItemVariant class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemVariant> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemVariantRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ItemVariant class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IItemVariantRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ItemVariant class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemVariant> GetFiltered(long pageNumber, string filterName);



    }
}