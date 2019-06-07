// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IShippingPackageShapeRepository
    {
        /// <summary>
        /// Counts the number of ShippingPackageShape in IShippingPackageShapeRepository.
        /// </summary>
        /// <returns>Returns the count of IShippingPackageShapeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ShippingPackageShape. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ShippingPackageShape.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShape> GetAll();

        /// <summary>
        /// Returns all instances of ShippingPackageShape to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ShippingPackageShape.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ShippingPackageShape against shippingPackageShapeId. 
        /// </summary>
        /// <param name="shippingPackageShapeId">The column "shipping_package_shape_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ShippingPackageShape.</returns>
        MixERP.Net.Entities.Core.ShippingPackageShape Get(int shippingPackageShapeId);

        /// <summary>
        /// Gets the first record of ShippingPackageShape.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ShippingPackageShape.</returns>
        MixERP.Net.Entities.Core.ShippingPackageShape GetFirst();

        /// <summary>
        /// Gets the previous record of ShippingPackageShape sorted by shippingPackageShapeId. 
        /// </summary>
        /// <param name="shippingPackageShapeId">The column "shipping_package_shape_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ShippingPackageShape.</returns>
        MixERP.Net.Entities.Core.ShippingPackageShape GetPrevious(int shippingPackageShapeId);

        /// <summary>
        /// Gets the next record of ShippingPackageShape sorted by shippingPackageShapeId. 
        /// </summary>
        /// <param name="shippingPackageShapeId">The column "shipping_package_shape_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ShippingPackageShape.</returns>
        MixERP.Net.Entities.Core.ShippingPackageShape GetNext(int shippingPackageShapeId);

        /// <summary>
        /// Gets the last record of ShippingPackageShape.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ShippingPackageShape.</returns>
        MixERP.Net.Entities.Core.ShippingPackageShape GetLast();

        /// <summary>
        /// Returns multiple instances of the ShippingPackageShape against shippingPackageShapeIds. 
        /// </summary>
        /// <param name="shippingPackageShapeIds">Array of column "shipping_package_shape_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ShippingPackageShape.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShape> Get(int[] shippingPackageShapeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IShippingPackageShapeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ShippingPackageShape.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ShippingPackageShape.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ShippingPackageShape.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ShippingPackageShape class to IShippingPackageShapeRepository.
        /// </summary>
        /// <param name="shippingPackageShape">The instance of ShippingPackageShape class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic shippingPackageShape, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ShippingPackageShape class to IShippingPackageShapeRepository.
        /// </summary>
        /// <param name="shippingPackageShape">The instance of ShippingPackageShape class to insert.</param>
        object Add(dynamic shippingPackageShape);

        /// <summary>
        /// Inserts or updates multiple instances of ShippingPackageShape class to IShippingPackageShapeRepository.;
        /// </summary>
        /// <param name="shippingPackageShapes">List of ShippingPackageShape class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> shippingPackageShapes);


        /// <summary>
        /// Updates IShippingPackageShapeRepository with an instance of ShippingPackageShape class against the primary key value.
        /// </summary>
        /// <param name="shippingPackageShape">The instance of ShippingPackageShape class to update.</param>
        /// <param name="shippingPackageShapeId">The value of the column "shipping_package_shape_id" which will be updated.</param>
        void Update(dynamic shippingPackageShape, int shippingPackageShapeId);

        /// <summary>
        /// Deletes ShippingPackageShape from  IShippingPackageShapeRepository against the primary key value.
        /// </summary>
        /// <param name="shippingPackageShapeId">The value of the column "shipping_package_shape_id" which will be deleted.</param>
        void Delete(int shippingPackageShapeId);

        /// <summary>
        /// Produces a paginated result of 10 ShippingPackageShape classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ShippingPackageShape class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShape> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ShippingPackageShape classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ShippingPackageShape class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShape> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IShippingPackageShapeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ShippingPackageShape class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IShippingPackageShapeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ShippingPackageShape class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShape> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IShippingPackageShapeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ShippingPackageShape class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IShippingPackageShapeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ShippingPackageShape class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingPackageShape> GetFiltered(long pageNumber, string filterName);



    }
}