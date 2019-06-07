// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IBrandRepository
    {
        /// <summary>
        /// Counts the number of Brand in IBrandRepository.
        /// </summary>
        /// <returns>Returns the count of IBrandRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Brand. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Brand.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Brand> GetAll();

        /// <summary>
        /// Returns all instances of Brand to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Brand.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Brand against brandId. 
        /// </summary>
        /// <param name="brandId">The column "brand_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Brand.</returns>
        MixERP.Net.Entities.Core.Brand Get(int brandId);

        /// <summary>
        /// Gets the first record of Brand.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Brand.</returns>
        MixERP.Net.Entities.Core.Brand GetFirst();

        /// <summary>
        /// Gets the previous record of Brand sorted by brandId. 
        /// </summary>
        /// <param name="brandId">The column "brand_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Brand.</returns>
        MixERP.Net.Entities.Core.Brand GetPrevious(int brandId);

        /// <summary>
        /// Gets the next record of Brand sorted by brandId. 
        /// </summary>
        /// <param name="brandId">The column "brand_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Brand.</returns>
        MixERP.Net.Entities.Core.Brand GetNext(int brandId);

        /// <summary>
        /// Gets the last record of Brand.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Brand.</returns>
        MixERP.Net.Entities.Core.Brand GetLast();

        /// <summary>
        /// Returns multiple instances of the Brand against brandIds. 
        /// </summary>
        /// <param name="brandIds">Array of column "brand_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Brand.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Brand> Get(int[] brandIds);

        /// <summary>
        /// Custom fields are user defined form elements for IBrandRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Brand.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Brand.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Brand.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Brand class to IBrandRepository.
        /// </summary>
        /// <param name="brand">The instance of Brand class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic brand, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Brand class to IBrandRepository.
        /// </summary>
        /// <param name="brand">The instance of Brand class to insert.</param>
        object Add(dynamic brand);

        /// <summary>
        /// Inserts or updates multiple instances of Brand class to IBrandRepository.;
        /// </summary>
        /// <param name="brands">List of Brand class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> brands);


        /// <summary>
        /// Updates IBrandRepository with an instance of Brand class against the primary key value.
        /// </summary>
        /// <param name="brand">The instance of Brand class to update.</param>
        /// <param name="brandId">The value of the column "brand_id" which will be updated.</param>
        void Update(dynamic brand, int brandId);

        /// <summary>
        /// Deletes Brand from  IBrandRepository against the primary key value.
        /// </summary>
        /// <param name="brandId">The value of the column "brand_id" which will be deleted.</param>
        void Delete(int brandId);

        /// <summary>
        /// Produces a paginated result of 10 Brand classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Brand class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Brand> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Brand classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Brand class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Brand> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IBrandRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Brand class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IBrandRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Brand class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Brand> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IBrandRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Brand class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IBrandRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Brand class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Brand> GetFiltered(long pageNumber, string filterName);



    }
}