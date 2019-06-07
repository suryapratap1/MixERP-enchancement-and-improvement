// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAttributeRepository
    {
        /// <summary>
        /// Counts the number of Attribute in IAttributeRepository.
        /// </summary>
        /// <returns>Returns the count of IAttributeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Attribute. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Attribute.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attribute> GetAll();

        /// <summary>
        /// Returns all instances of Attribute to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Attribute.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Attribute against attributeId. 
        /// </summary>
        /// <param name="attributeId">The column "attribute_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Attribute.</returns>
        MixERP.Net.Entities.Core.Attribute Get(int attributeId);

        /// <summary>
        /// Gets the first record of Attribute.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Attribute.</returns>
        MixERP.Net.Entities.Core.Attribute GetFirst();

        /// <summary>
        /// Gets the previous record of Attribute sorted by attributeId. 
        /// </summary>
        /// <param name="attributeId">The column "attribute_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Attribute.</returns>
        MixERP.Net.Entities.Core.Attribute GetPrevious(int attributeId);

        /// <summary>
        /// Gets the next record of Attribute sorted by attributeId. 
        /// </summary>
        /// <param name="attributeId">The column "attribute_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Attribute.</returns>
        MixERP.Net.Entities.Core.Attribute GetNext(int attributeId);

        /// <summary>
        /// Gets the last record of Attribute.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Attribute.</returns>
        MixERP.Net.Entities.Core.Attribute GetLast();

        /// <summary>
        /// Returns multiple instances of the Attribute against attributeIds. 
        /// </summary>
        /// <param name="attributeIds">Array of column "attribute_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Attribute.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attribute> Get(int[] attributeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IAttributeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Attribute.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Attribute.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Attribute.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Attribute class to IAttributeRepository.
        /// </summary>
        /// <param name="attribute">The instance of Attribute class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic attribute, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Attribute class to IAttributeRepository.
        /// </summary>
        /// <param name="attribute">The instance of Attribute class to insert.</param>
        object Add(dynamic attribute);

        /// <summary>
        /// Inserts or updates multiple instances of Attribute class to IAttributeRepository.;
        /// </summary>
        /// <param name="attributes">List of Attribute class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> attributes);


        /// <summary>
        /// Updates IAttributeRepository with an instance of Attribute class against the primary key value.
        /// </summary>
        /// <param name="attribute">The instance of Attribute class to update.</param>
        /// <param name="attributeId">The value of the column "attribute_id" which will be updated.</param>
        void Update(dynamic attribute, int attributeId);

        /// <summary>
        /// Deletes Attribute from  IAttributeRepository against the primary key value.
        /// </summary>
        /// <param name="attributeId">The value of the column "attribute_id" which will be deleted.</param>
        void Delete(int attributeId);

        /// <summary>
        /// Produces a paginated result of 10 Attribute classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Attribute class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attribute> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Attribute classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Attribute class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attribute> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IAttributeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Attribute class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IAttributeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Attribute class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attribute> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IAttributeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Attribute class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IAttributeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Attribute class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Attribute> GetFiltered(long pageNumber, string filterName);



    }
}