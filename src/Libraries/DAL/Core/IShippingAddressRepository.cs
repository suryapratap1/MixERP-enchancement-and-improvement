// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IShippingAddressRepository
    {
        /// <summary>
        /// Counts the number of ShippingAddress in IShippingAddressRepository.
        /// </summary>
        /// <returns>Returns the count of IShippingAddressRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ShippingAddress. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ShippingAddress.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetAll();

        /// <summary>
        /// Returns all instances of ShippingAddress to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ShippingAddress.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ShippingAddress against shippingAddressId. 
        /// </summary>
        /// <param name="shippingAddressId">The column "shipping_address_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ShippingAddress.</returns>
        MixERP.Net.Entities.Core.ShippingAddress Get(long shippingAddressId);

        /// <summary>
        /// Gets the first record of ShippingAddress.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ShippingAddress.</returns>
        MixERP.Net.Entities.Core.ShippingAddress GetFirst();

        /// <summary>
        /// Gets the previous record of ShippingAddress sorted by shippingAddressId. 
        /// </summary>
        /// <param name="shippingAddressId">The column "shipping_address_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ShippingAddress.</returns>
        MixERP.Net.Entities.Core.ShippingAddress GetPrevious(long shippingAddressId);

        /// <summary>
        /// Gets the next record of ShippingAddress sorted by shippingAddressId. 
        /// </summary>
        /// <param name="shippingAddressId">The column "shipping_address_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ShippingAddress.</returns>
        MixERP.Net.Entities.Core.ShippingAddress GetNext(long shippingAddressId);

        /// <summary>
        /// Gets the last record of ShippingAddress.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ShippingAddress.</returns>
        MixERP.Net.Entities.Core.ShippingAddress GetLast();

        /// <summary>
        /// Returns multiple instances of the ShippingAddress against shippingAddressIds. 
        /// </summary>
        /// <param name="shippingAddressIds">Array of column "shipping_address_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ShippingAddress.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> Get(long[] shippingAddressIds);

        /// <summary>
        /// Custom fields are user defined form elements for IShippingAddressRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ShippingAddress.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ShippingAddress.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ShippingAddress.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ShippingAddress class to IShippingAddressRepository.
        /// </summary>
        /// <param name="shippingAddress">The instance of ShippingAddress class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic shippingAddress, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ShippingAddress class to IShippingAddressRepository.
        /// </summary>
        /// <param name="shippingAddress">The instance of ShippingAddress class to insert.</param>
        object Add(dynamic shippingAddress);

        /// <summary>
        /// Inserts or updates multiple instances of ShippingAddress class to IShippingAddressRepository.;
        /// </summary>
        /// <param name="shippingAddresses">List of ShippingAddress class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> shippingAddresses);


        /// <summary>
        /// Updates IShippingAddressRepository with an instance of ShippingAddress class against the primary key value.
        /// </summary>
        /// <param name="shippingAddress">The instance of ShippingAddress class to update.</param>
        /// <param name="shippingAddressId">The value of the column "shipping_address_id" which will be updated.</param>
        void Update(dynamic shippingAddress, long shippingAddressId);

        /// <summary>
        /// Deletes ShippingAddress from  IShippingAddressRepository against the primary key value.
        /// </summary>
        /// <param name="shippingAddressId">The value of the column "shipping_address_id" which will be deleted.</param>
        void Delete(long shippingAddressId);

        /// <summary>
        /// Produces a paginated result of 10 ShippingAddress classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ShippingAddress class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ShippingAddress classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ShippingAddress class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IShippingAddressRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ShippingAddress class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IShippingAddressRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ShippingAddress class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IShippingAddressRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ShippingAddress class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IShippingAddressRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ShippingAddress class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetFiltered(long pageNumber, string filterName);



    }
}