// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICompoundUnitRepository
    {
        /// <summary>
        /// Counts the number of CompoundUnit in ICompoundUnitRepository.
        /// </summary>
        /// <returns>Returns the count of ICompoundUnitRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CompoundUnit. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CompoundUnit.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetAll();

        /// <summary>
        /// Returns all instances of CompoundUnit to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CompoundUnit.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CompoundUnit against compoundUnitId. 
        /// </summary>
        /// <param name="compoundUnitId">The column "compound_unit_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CompoundUnit.</returns>
        MixERP.Net.Entities.Core.CompoundUnit Get(int compoundUnitId);

        /// <summary>
        /// Gets the first record of CompoundUnit.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CompoundUnit.</returns>
        MixERP.Net.Entities.Core.CompoundUnit GetFirst();

        /// <summary>
        /// Gets the previous record of CompoundUnit sorted by compoundUnitId. 
        /// </summary>
        /// <param name="compoundUnitId">The column "compound_unit_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CompoundUnit.</returns>
        MixERP.Net.Entities.Core.CompoundUnit GetPrevious(int compoundUnitId);

        /// <summary>
        /// Gets the next record of CompoundUnit sorted by compoundUnitId. 
        /// </summary>
        /// <param name="compoundUnitId">The column "compound_unit_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CompoundUnit.</returns>
        MixERP.Net.Entities.Core.CompoundUnit GetNext(int compoundUnitId);

        /// <summary>
        /// Gets the last record of CompoundUnit.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CompoundUnit.</returns>
        MixERP.Net.Entities.Core.CompoundUnit GetLast();

        /// <summary>
        /// Returns multiple instances of the CompoundUnit against compoundUnitIds. 
        /// </summary>
        /// <param name="compoundUnitIds">Array of column "compound_unit_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CompoundUnit.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> Get(int[] compoundUnitIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICompoundUnitRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CompoundUnit.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CompoundUnit.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CompoundUnit.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CompoundUnit class to ICompoundUnitRepository.
        /// </summary>
        /// <param name="compoundUnit">The instance of CompoundUnit class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic compoundUnit, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CompoundUnit class to ICompoundUnitRepository.
        /// </summary>
        /// <param name="compoundUnit">The instance of CompoundUnit class to insert.</param>
        object Add(dynamic compoundUnit);

        /// <summary>
        /// Inserts or updates multiple instances of CompoundUnit class to ICompoundUnitRepository.;
        /// </summary>
        /// <param name="compoundUnits">List of CompoundUnit class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> compoundUnits);


        /// <summary>
        /// Updates ICompoundUnitRepository with an instance of CompoundUnit class against the primary key value.
        /// </summary>
        /// <param name="compoundUnit">The instance of CompoundUnit class to update.</param>
        /// <param name="compoundUnitId">The value of the column "compound_unit_id" which will be updated.</param>
        void Update(dynamic compoundUnit, int compoundUnitId);

        /// <summary>
        /// Deletes CompoundUnit from  ICompoundUnitRepository against the primary key value.
        /// </summary>
        /// <param name="compoundUnitId">The value of the column "compound_unit_id" which will be deleted.</param>
        void Delete(int compoundUnitId);

        /// <summary>
        /// Produces a paginated result of 10 CompoundUnit classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CompoundUnit class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CompoundUnit classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CompoundUnit class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICompoundUnitRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CompoundUnit class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICompoundUnitRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CompoundUnit class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICompoundUnitRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CompoundUnit class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICompoundUnitRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CompoundUnit class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetFiltered(long pageNumber, string filterName);



    }
}