// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IFrequencyRepository
    {
        /// <summary>
        /// Counts the number of Frequency in IFrequencyRepository.
        /// </summary>
        /// <returns>Returns the count of IFrequencyRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Frequency. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Frequency.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Frequency> GetAll();

        /// <summary>
        /// Returns all instances of Frequency to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Frequency.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Frequency against frequencyId. 
        /// </summary>
        /// <param name="frequencyId">The column "frequency_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Frequency.</returns>
        MixERP.Net.Entities.Core.Frequency Get(int frequencyId);

        /// <summary>
        /// Gets the first record of Frequency.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Frequency.</returns>
        MixERP.Net.Entities.Core.Frequency GetFirst();

        /// <summary>
        /// Gets the previous record of Frequency sorted by frequencyId. 
        /// </summary>
        /// <param name="frequencyId">The column "frequency_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Frequency.</returns>
        MixERP.Net.Entities.Core.Frequency GetPrevious(int frequencyId);

        /// <summary>
        /// Gets the next record of Frequency sorted by frequencyId. 
        /// </summary>
        /// <param name="frequencyId">The column "frequency_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Frequency.</returns>
        MixERP.Net.Entities.Core.Frequency GetNext(int frequencyId);

        /// <summary>
        /// Gets the last record of Frequency.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Frequency.</returns>
        MixERP.Net.Entities.Core.Frequency GetLast();

        /// <summary>
        /// Returns multiple instances of the Frequency against frequencyIds. 
        /// </summary>
        /// <param name="frequencyIds">Array of column "frequency_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Frequency.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Frequency> Get(int[] frequencyIds);

        /// <summary>
        /// Custom fields are user defined form elements for IFrequencyRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Frequency.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Frequency.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Frequency.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Frequency class to IFrequencyRepository.
        /// </summary>
        /// <param name="frequency">The instance of Frequency class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic frequency, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Frequency class to IFrequencyRepository.
        /// </summary>
        /// <param name="frequency">The instance of Frequency class to insert.</param>
        object Add(dynamic frequency);

        /// <summary>
        /// Inserts or updates multiple instances of Frequency class to IFrequencyRepository.;
        /// </summary>
        /// <param name="frequencies">List of Frequency class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> frequencies);


        /// <summary>
        /// Updates IFrequencyRepository with an instance of Frequency class against the primary key value.
        /// </summary>
        /// <param name="frequency">The instance of Frequency class to update.</param>
        /// <param name="frequencyId">The value of the column "frequency_id" which will be updated.</param>
        void Update(dynamic frequency, int frequencyId);

        /// <summary>
        /// Deletes Frequency from  IFrequencyRepository against the primary key value.
        /// </summary>
        /// <param name="frequencyId">The value of the column "frequency_id" which will be deleted.</param>
        void Delete(int frequencyId);

        /// <summary>
        /// Produces a paginated result of 10 Frequency classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Frequency class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Frequency> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Frequency classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Frequency class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Frequency> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFrequencyRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Frequency class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IFrequencyRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Frequency class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Frequency> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFrequencyRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Frequency class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IFrequencyRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Frequency class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Frequency> GetFiltered(long pageNumber, string filterName);



    }
}