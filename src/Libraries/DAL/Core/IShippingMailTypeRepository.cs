// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IShippingMailTypeRepository
    {
        /// <summary>
        /// Counts the number of ShippingMailType in IShippingMailTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IShippingMailTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ShippingMailType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ShippingMailType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> GetAll();

        /// <summary>
        /// Returns all instances of ShippingMailType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ShippingMailType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ShippingMailType against shippingMailTypeId. 
        /// </summary>
        /// <param name="shippingMailTypeId">The column "shipping_mail_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ShippingMailType.</returns>
        MixERP.Net.Entities.Core.ShippingMailType Get(int shippingMailTypeId);

        /// <summary>
        /// Gets the first record of ShippingMailType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ShippingMailType.</returns>
        MixERP.Net.Entities.Core.ShippingMailType GetFirst();

        /// <summary>
        /// Gets the previous record of ShippingMailType sorted by shippingMailTypeId. 
        /// </summary>
        /// <param name="shippingMailTypeId">The column "shipping_mail_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ShippingMailType.</returns>
        MixERP.Net.Entities.Core.ShippingMailType GetPrevious(int shippingMailTypeId);

        /// <summary>
        /// Gets the next record of ShippingMailType sorted by shippingMailTypeId. 
        /// </summary>
        /// <param name="shippingMailTypeId">The column "shipping_mail_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ShippingMailType.</returns>
        MixERP.Net.Entities.Core.ShippingMailType GetNext(int shippingMailTypeId);

        /// <summary>
        /// Gets the last record of ShippingMailType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ShippingMailType.</returns>
        MixERP.Net.Entities.Core.ShippingMailType GetLast();

        /// <summary>
        /// Returns multiple instances of the ShippingMailType against shippingMailTypeIds. 
        /// </summary>
        /// <param name="shippingMailTypeIds">Array of column "shipping_mail_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ShippingMailType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> Get(int[] shippingMailTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IShippingMailTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ShippingMailType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ShippingMailType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ShippingMailType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ShippingMailType class to IShippingMailTypeRepository.
        /// </summary>
        /// <param name="shippingMailType">The instance of ShippingMailType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic shippingMailType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ShippingMailType class to IShippingMailTypeRepository.
        /// </summary>
        /// <param name="shippingMailType">The instance of ShippingMailType class to insert.</param>
        object Add(dynamic shippingMailType);

        /// <summary>
        /// Inserts or updates multiple instances of ShippingMailType class to IShippingMailTypeRepository.;
        /// </summary>
        /// <param name="shippingMailTypes">List of ShippingMailType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> shippingMailTypes);


        /// <summary>
        /// Updates IShippingMailTypeRepository with an instance of ShippingMailType class against the primary key value.
        /// </summary>
        /// <param name="shippingMailType">The instance of ShippingMailType class to update.</param>
        /// <param name="shippingMailTypeId">The value of the column "shipping_mail_type_id" which will be updated.</param>
        void Update(dynamic shippingMailType, int shippingMailTypeId);

        /// <summary>
        /// Deletes ShippingMailType from  IShippingMailTypeRepository against the primary key value.
        /// </summary>
        /// <param name="shippingMailTypeId">The value of the column "shipping_mail_type_id" which will be deleted.</param>
        void Delete(int shippingMailTypeId);

        /// <summary>
        /// Produces a paginated result of 10 ShippingMailType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ShippingMailType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ShippingMailType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ShippingMailType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IShippingMailTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ShippingMailType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IShippingMailTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ShippingMailType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IShippingMailTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ShippingMailType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IShippingMailTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ShippingMailType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> GetFiltered(long pageNumber, string filterName);



    }
}