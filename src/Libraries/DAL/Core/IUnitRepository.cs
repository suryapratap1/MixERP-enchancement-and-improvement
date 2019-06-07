// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IUnitRepository
    {
        /// <summary>
        /// Counts the number of Unit in IUnitRepository.
        /// </summary>
        /// <returns>Returns the count of IUnitRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Unit. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Unit.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Unit> GetAll();

        /// <summary>
        /// Returns all instances of Unit to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Unit.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Unit against unitId. 
        /// </summary>
        /// <param name="unitId">The column "unit_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Unit.</returns>
        MixERP.Net.Entities.Core.Unit Get(int unitId);

        /// <summary>
        /// Gets the first record of Unit.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Unit.</returns>
        MixERP.Net.Entities.Core.Unit GetFirst();

        /// <summary>
        /// Gets the previous record of Unit sorted by unitId. 
        /// </summary>
        /// <param name="unitId">The column "unit_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Unit.</returns>
        MixERP.Net.Entities.Core.Unit GetPrevious(int unitId);

        /// <summary>
        /// Gets the next record of Unit sorted by unitId. 
        /// </summary>
        /// <param name="unitId">The column "unit_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Unit.</returns>
        MixERP.Net.Entities.Core.Unit GetNext(int unitId);

        /// <summary>
        /// Gets the last record of Unit.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Unit.</returns>
        MixERP.Net.Entities.Core.Unit GetLast();

        /// <summary>
        /// Returns multiple instances of the Unit against unitIds. 
        /// </summary>
        /// <param name="unitIds">Array of column "unit_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Unit.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Unit> Get(int[] unitIds);

        /// <summary>
        /// Custom fields are user defined form elements for IUnitRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Unit.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Unit.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Unit.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Unit class to IUnitRepository.
        /// </summary>
        /// <param name="unit">The instance of Unit class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic unit, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Unit class to IUnitRepository.
        /// </summary>
        /// <param name="unit">The instance of Unit class to insert.</param>
        object Add(dynamic unit);

        /// <summary>
        /// Inserts or updates multiple instances of Unit class to IUnitRepository.;
        /// </summary>
        /// <param name="units">List of Unit class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> units);


        /// <summary>
        /// Updates IUnitRepository with an instance of Unit class against the primary key value.
        /// </summary>
        /// <param name="unit">The instance of Unit class to update.</param>
        /// <param name="unitId">The value of the column "unit_id" which will be updated.</param>
        void Update(dynamic unit, int unitId);

        /// <summary>
        /// Deletes Unit from  IUnitRepository against the primary key value.
        /// </summary>
        /// <param name="unitId">The value of the column "unit_id" which will be deleted.</param>
        void Delete(int unitId);

        /// <summary>
        /// Produces a paginated result of 10 Unit classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Unit class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Unit> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Unit classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Unit class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Unit> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IUnitRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Unit class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IUnitRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Unit class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Unit> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IUnitRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Unit class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IUnitRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Unit class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Unit> GetFiltered(long pageNumber, string filterName);



    }
}