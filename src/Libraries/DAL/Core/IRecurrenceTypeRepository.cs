// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IRecurrenceTypeRepository
    {
        /// <summary>
        /// Counts the number of RecurrenceType in IRecurrenceTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IRecurrenceTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of RecurrenceType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of RecurrenceType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> GetAll();

        /// <summary>
        /// Returns all instances of RecurrenceType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of RecurrenceType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the RecurrenceType against recurrenceTypeId. 
        /// </summary>
        /// <param name="recurrenceTypeId">The column "recurrence_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of RecurrenceType.</returns>
        MixERP.Net.Entities.Core.RecurrenceType Get(int recurrenceTypeId);

        /// <summary>
        /// Gets the first record of RecurrenceType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of RecurrenceType.</returns>
        MixERP.Net.Entities.Core.RecurrenceType GetFirst();

        /// <summary>
        /// Gets the previous record of RecurrenceType sorted by recurrenceTypeId. 
        /// </summary>
        /// <param name="recurrenceTypeId">The column "recurrence_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of RecurrenceType.</returns>
        MixERP.Net.Entities.Core.RecurrenceType GetPrevious(int recurrenceTypeId);

        /// <summary>
        /// Gets the next record of RecurrenceType sorted by recurrenceTypeId. 
        /// </summary>
        /// <param name="recurrenceTypeId">The column "recurrence_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of RecurrenceType.</returns>
        MixERP.Net.Entities.Core.RecurrenceType GetNext(int recurrenceTypeId);

        /// <summary>
        /// Gets the last record of RecurrenceType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of RecurrenceType.</returns>
        MixERP.Net.Entities.Core.RecurrenceType GetLast();

        /// <summary>
        /// Returns multiple instances of the RecurrenceType against recurrenceTypeIds. 
        /// </summary>
        /// <param name="recurrenceTypeIds">Array of column "recurrence_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of RecurrenceType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> Get(int[] recurrenceTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IRecurrenceTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for RecurrenceType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding RecurrenceType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for RecurrenceType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of RecurrenceType class to IRecurrenceTypeRepository.
        /// </summary>
        /// <param name="recurrenceType">The instance of RecurrenceType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic recurrenceType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of RecurrenceType class to IRecurrenceTypeRepository.
        /// </summary>
        /// <param name="recurrenceType">The instance of RecurrenceType class to insert.</param>
        object Add(dynamic recurrenceType);

        /// <summary>
        /// Inserts or updates multiple instances of RecurrenceType class to IRecurrenceTypeRepository.;
        /// </summary>
        /// <param name="recurrenceTypes">List of RecurrenceType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> recurrenceTypes);


        /// <summary>
        /// Updates IRecurrenceTypeRepository with an instance of RecurrenceType class against the primary key value.
        /// </summary>
        /// <param name="recurrenceType">The instance of RecurrenceType class to update.</param>
        /// <param name="recurrenceTypeId">The value of the column "recurrence_type_id" which will be updated.</param>
        void Update(dynamic recurrenceType, int recurrenceTypeId);

        /// <summary>
        /// Deletes RecurrenceType from  IRecurrenceTypeRepository against the primary key value.
        /// </summary>
        /// <param name="recurrenceTypeId">The value of the column "recurrence_type_id" which will be deleted.</param>
        void Delete(int recurrenceTypeId);

        /// <summary>
        /// Produces a paginated result of 10 RecurrenceType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of RecurrenceType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 RecurrenceType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of RecurrenceType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IRecurrenceTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of RecurrenceType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IRecurrenceTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of RecurrenceType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IRecurrenceTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of RecurrenceType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IRecurrenceTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of RecurrenceType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> GetFiltered(long pageNumber, string filterName);



    }
}