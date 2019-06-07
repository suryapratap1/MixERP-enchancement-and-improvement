// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IShipperRepository
    {
        /// <summary>
        /// Counts the number of Shipper in IShipperRepository.
        /// </summary>
        /// <returns>Returns the count of IShipperRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Shipper. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Shipper.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Shipper> GetAll();

        /// <summary>
        /// Returns all instances of Shipper to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Shipper.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Shipper against shipperId. 
        /// </summary>
        /// <param name="shipperId">The column "shipper_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Shipper.</returns>
        MixERP.Net.Entities.Core.Shipper Get(int shipperId);

        /// <summary>
        /// Gets the first record of Shipper.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Shipper.</returns>
        MixERP.Net.Entities.Core.Shipper GetFirst();

        /// <summary>
        /// Gets the previous record of Shipper sorted by shipperId. 
        /// </summary>
        /// <param name="shipperId">The column "shipper_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Shipper.</returns>
        MixERP.Net.Entities.Core.Shipper GetPrevious(int shipperId);

        /// <summary>
        /// Gets the next record of Shipper sorted by shipperId. 
        /// </summary>
        /// <param name="shipperId">The column "shipper_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Shipper.</returns>
        MixERP.Net.Entities.Core.Shipper GetNext(int shipperId);

        /// <summary>
        /// Gets the last record of Shipper.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Shipper.</returns>
        MixERP.Net.Entities.Core.Shipper GetLast();

        /// <summary>
        /// Returns multiple instances of the Shipper against shipperIds. 
        /// </summary>
        /// <param name="shipperIds">Array of column "shipper_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Shipper.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Shipper> Get(int[] shipperIds);

        /// <summary>
        /// Custom fields are user defined form elements for IShipperRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Shipper.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Shipper.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Shipper.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Shipper class to IShipperRepository.
        /// </summary>
        /// <param name="shipper">The instance of Shipper class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic shipper, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Shipper class to IShipperRepository.
        /// </summary>
        /// <param name="shipper">The instance of Shipper class to insert.</param>
        object Add(dynamic shipper);

        /// <summary>
        /// Inserts or updates multiple instances of Shipper class to IShipperRepository.;
        /// </summary>
        /// <param name="shippers">List of Shipper class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> shippers);


        /// <summary>
        /// Updates IShipperRepository with an instance of Shipper class against the primary key value.
        /// </summary>
        /// <param name="shipper">The instance of Shipper class to update.</param>
        /// <param name="shipperId">The value of the column "shipper_id" which will be updated.</param>
        void Update(dynamic shipper, int shipperId);

        /// <summary>
        /// Deletes Shipper from  IShipperRepository against the primary key value.
        /// </summary>
        /// <param name="shipperId">The value of the column "shipper_id" which will be deleted.</param>
        void Delete(int shipperId);

        /// <summary>
        /// Produces a paginated result of 10 Shipper classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Shipper class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Shipper> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Shipper classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Shipper class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Shipper> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IShipperRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Shipper class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IShipperRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Shipper class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Shipper> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IShipperRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Shipper class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IShipperRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Shipper class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Shipper> GetFiltered(long pageNumber, string filterName);



    }
}