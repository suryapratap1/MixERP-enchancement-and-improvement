// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPriceTypeRepository
    {
        /// <summary>
        /// Counts the number of PriceType in IPriceTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IPriceTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of PriceType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PriceType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PriceType> GetAll();

        /// <summary>
        /// Returns all instances of PriceType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PriceType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the PriceType against priceTypeId. 
        /// </summary>
        /// <param name="priceTypeId">The column "price_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of PriceType.</returns>
        MixERP.Net.Entities.Core.PriceType Get(int priceTypeId);

        /// <summary>
        /// Gets the first record of PriceType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PriceType.</returns>
        MixERP.Net.Entities.Core.PriceType GetFirst();

        /// <summary>
        /// Gets the previous record of PriceType sorted by priceTypeId. 
        /// </summary>
        /// <param name="priceTypeId">The column "price_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PriceType.</returns>
        MixERP.Net.Entities.Core.PriceType GetPrevious(int priceTypeId);

        /// <summary>
        /// Gets the next record of PriceType sorted by priceTypeId. 
        /// </summary>
        /// <param name="priceTypeId">The column "price_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PriceType.</returns>
        MixERP.Net.Entities.Core.PriceType GetNext(int priceTypeId);

        /// <summary>
        /// Gets the last record of PriceType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PriceType.</returns>
        MixERP.Net.Entities.Core.PriceType GetLast();

        /// <summary>
        /// Returns multiple instances of the PriceType against priceTypeIds. 
        /// </summary>
        /// <param name="priceTypeIds">Array of column "price_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of PriceType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PriceType> Get(int[] priceTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IPriceTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for PriceType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding PriceType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for PriceType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of PriceType class to IPriceTypeRepository.
        /// </summary>
        /// <param name="priceType">The instance of PriceType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic priceType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of PriceType class to IPriceTypeRepository.
        /// </summary>
        /// <param name="priceType">The instance of PriceType class to insert.</param>
        object Add(dynamic priceType);

        /// <summary>
        /// Inserts or updates multiple instances of PriceType class to IPriceTypeRepository.;
        /// </summary>
        /// <param name="priceTypes">List of PriceType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> priceTypes);


        /// <summary>
        /// Updates IPriceTypeRepository with an instance of PriceType class against the primary key value.
        /// </summary>
        /// <param name="priceType">The instance of PriceType class to update.</param>
        /// <param name="priceTypeId">The value of the column "price_type_id" which will be updated.</param>
        void Update(dynamic priceType, int priceTypeId);

        /// <summary>
        /// Deletes PriceType from  IPriceTypeRepository against the primary key value.
        /// </summary>
        /// <param name="priceTypeId">The value of the column "price_type_id" which will be deleted.</param>
        void Delete(int priceTypeId);

        /// <summary>
        /// Produces a paginated result of 10 PriceType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of PriceType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PriceType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 PriceType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of PriceType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PriceType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPriceTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of PriceType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IPriceTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of PriceType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PriceType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPriceTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of PriceType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IPriceTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of PriceType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PriceType> GetFiltered(long pageNumber, string filterName);



    }
}