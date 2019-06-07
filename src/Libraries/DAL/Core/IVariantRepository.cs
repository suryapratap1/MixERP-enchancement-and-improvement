// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IVariantRepository
    {
        /// <summary>
        /// Counts the number of Variant in IVariantRepository.
        /// </summary>
        /// <returns>Returns the count of IVariantRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Variant. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Variant.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Variant> GetAll();

        /// <summary>
        /// Returns all instances of Variant to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Variant.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Variant against variantId. 
        /// </summary>
        /// <param name="variantId">The column "variant_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Variant.</returns>
        MixERP.Net.Entities.Core.Variant Get(int variantId);

        /// <summary>
        /// Gets the first record of Variant.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Variant.</returns>
        MixERP.Net.Entities.Core.Variant GetFirst();

        /// <summary>
        /// Gets the previous record of Variant sorted by variantId. 
        /// </summary>
        /// <param name="variantId">The column "variant_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Variant.</returns>
        MixERP.Net.Entities.Core.Variant GetPrevious(int variantId);

        /// <summary>
        /// Gets the next record of Variant sorted by variantId. 
        /// </summary>
        /// <param name="variantId">The column "variant_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Variant.</returns>
        MixERP.Net.Entities.Core.Variant GetNext(int variantId);

        /// <summary>
        /// Gets the last record of Variant.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Variant.</returns>
        MixERP.Net.Entities.Core.Variant GetLast();

        /// <summary>
        /// Returns multiple instances of the Variant against variantIds. 
        /// </summary>
        /// <param name="variantIds">Array of column "variant_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Variant.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Variant> Get(int[] variantIds);

        /// <summary>
        /// Custom fields are user defined form elements for IVariantRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Variant.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Variant.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Variant.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Variant class to IVariantRepository.
        /// </summary>
        /// <param name="variant">The instance of Variant class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic variant, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Variant class to IVariantRepository.
        /// </summary>
        /// <param name="variant">The instance of Variant class to insert.</param>
        object Add(dynamic variant);

        /// <summary>
        /// Inserts or updates multiple instances of Variant class to IVariantRepository.;
        /// </summary>
        /// <param name="variants">List of Variant class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> variants);


        /// <summary>
        /// Updates IVariantRepository with an instance of Variant class against the primary key value.
        /// </summary>
        /// <param name="variant">The instance of Variant class to update.</param>
        /// <param name="variantId">The value of the column "variant_id" which will be updated.</param>
        void Update(dynamic variant, int variantId);

        /// <summary>
        /// Deletes Variant from  IVariantRepository against the primary key value.
        /// </summary>
        /// <param name="variantId">The value of the column "variant_id" which will be deleted.</param>
        void Delete(int variantId);

        /// <summary>
        /// Produces a paginated result of 10 Variant classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Variant class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Variant> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Variant classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Variant class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Variant> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IVariantRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Variant class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IVariantRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Variant class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Variant> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IVariantRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Variant class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IVariantRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Variant class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Variant> GetFiltered(long pageNumber, string filterName);



    }
}