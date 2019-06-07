// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICustomFieldDataTypeRepository
    {
        /// <summary>
        /// Counts the number of CustomFieldDataType in ICustomFieldDataTypeRepository.
        /// </summary>
        /// <returns>Returns the count of ICustomFieldDataTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CustomFieldDataType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CustomFieldDataType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetAll();

        /// <summary>
        /// Returns all instances of CustomFieldDataType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CustomFieldDataType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CustomFieldDataType against dataType. 
        /// </summary>
        /// <param name="dataType">The column "data_type" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CustomFieldDataType.</returns>
        MixERP.Net.Entities.Core.CustomFieldDataType Get(string dataType);

        /// <summary>
        /// Gets the first record of CustomFieldDataType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CustomFieldDataType.</returns>
        MixERP.Net.Entities.Core.CustomFieldDataType GetFirst();

        /// <summary>
        /// Gets the previous record of CustomFieldDataType sorted by dataType. 
        /// </summary>
        /// <param name="dataType">The column "data_type" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CustomFieldDataType.</returns>
        MixERP.Net.Entities.Core.CustomFieldDataType GetPrevious(string dataType);

        /// <summary>
        /// Gets the next record of CustomFieldDataType sorted by dataType. 
        /// </summary>
        /// <param name="dataType">The column "data_type" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CustomFieldDataType.</returns>
        MixERP.Net.Entities.Core.CustomFieldDataType GetNext(string dataType);

        /// <summary>
        /// Gets the last record of CustomFieldDataType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CustomFieldDataType.</returns>
        MixERP.Net.Entities.Core.CustomFieldDataType GetLast();

        /// <summary>
        /// Returns multiple instances of the CustomFieldDataType against dataTypes. 
        /// </summary>
        /// <param name="dataTypes">Array of column "data_type" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CustomFieldDataType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> Get(string[] dataTypes);

        /// <summary>
        /// Custom fields are user defined form elements for ICustomFieldDataTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CustomFieldDataType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CustomFieldDataType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CustomFieldDataType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CustomFieldDataType class to ICustomFieldDataTypeRepository.
        /// </summary>
        /// <param name="customFieldDataType">The instance of CustomFieldDataType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic customFieldDataType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CustomFieldDataType class to ICustomFieldDataTypeRepository.
        /// </summary>
        /// <param name="customFieldDataType">The instance of CustomFieldDataType class to insert.</param>
        object Add(dynamic customFieldDataType);

        /// <summary>
        /// Inserts or updates multiple instances of CustomFieldDataType class to ICustomFieldDataTypeRepository.;
        /// </summary>
        /// <param name="customFieldDataTypes">List of CustomFieldDataType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> customFieldDataTypes);


        /// <summary>
        /// Updates ICustomFieldDataTypeRepository with an instance of CustomFieldDataType class against the primary key value.
        /// </summary>
        /// <param name="customFieldDataType">The instance of CustomFieldDataType class to update.</param>
        /// <param name="dataType">The value of the column "data_type" which will be updated.</param>
        void Update(dynamic customFieldDataType, string dataType);

        /// <summary>
        /// Deletes CustomFieldDataType from  ICustomFieldDataTypeRepository against the primary key value.
        /// </summary>
        /// <param name="dataType">The value of the column "data_type" which will be deleted.</param>
        void Delete(string dataType);

        /// <summary>
        /// Produces a paginated result of 10 CustomFieldDataType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CustomFieldDataType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CustomFieldDataType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CustomFieldDataType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICustomFieldDataTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CustomFieldDataType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICustomFieldDataTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CustomFieldDataType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICustomFieldDataTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CustomFieldDataType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICustomFieldDataTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CustomFieldDataType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetFiltered(long pageNumber, string filterName);



    }
}