// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IFlagTypeRepository
    {
        /// <summary>
        /// Counts the number of FlagType in IFlagTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IFlagTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of FlagType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of FlagType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FlagType> GetAll();

        /// <summary>
        /// Returns all instances of FlagType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of FlagType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the FlagType against flagTypeId. 
        /// </summary>
        /// <param name="flagTypeId">The column "flag_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of FlagType.</returns>
        MixERP.Net.Entities.Core.FlagType Get(int flagTypeId);

        /// <summary>
        /// Gets the first record of FlagType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of FlagType.</returns>
        MixERP.Net.Entities.Core.FlagType GetFirst();

        /// <summary>
        /// Gets the previous record of FlagType sorted by flagTypeId. 
        /// </summary>
        /// <param name="flagTypeId">The column "flag_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of FlagType.</returns>
        MixERP.Net.Entities.Core.FlagType GetPrevious(int flagTypeId);

        /// <summary>
        /// Gets the next record of FlagType sorted by flagTypeId. 
        /// </summary>
        /// <param name="flagTypeId">The column "flag_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of FlagType.</returns>
        MixERP.Net.Entities.Core.FlagType GetNext(int flagTypeId);

        /// <summary>
        /// Gets the last record of FlagType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of FlagType.</returns>
        MixERP.Net.Entities.Core.FlagType GetLast();

        /// <summary>
        /// Returns multiple instances of the FlagType against flagTypeIds. 
        /// </summary>
        /// <param name="flagTypeIds">Array of column "flag_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of FlagType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FlagType> Get(int[] flagTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IFlagTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for FlagType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding FlagType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for FlagType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of FlagType class to IFlagTypeRepository.
        /// </summary>
        /// <param name="flagType">The instance of FlagType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic flagType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of FlagType class to IFlagTypeRepository.
        /// </summary>
        /// <param name="flagType">The instance of FlagType class to insert.</param>
        object Add(dynamic flagType);

        /// <summary>
        /// Inserts or updates multiple instances of FlagType class to IFlagTypeRepository.;
        /// </summary>
        /// <param name="flagTypes">List of FlagType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> flagTypes);


        /// <summary>
        /// Updates IFlagTypeRepository with an instance of FlagType class against the primary key value.
        /// </summary>
        /// <param name="flagType">The instance of FlagType class to update.</param>
        /// <param name="flagTypeId">The value of the column "flag_type_id" which will be updated.</param>
        void Update(dynamic flagType, int flagTypeId);

        /// <summary>
        /// Deletes FlagType from  IFlagTypeRepository against the primary key value.
        /// </summary>
        /// <param name="flagTypeId">The value of the column "flag_type_id" which will be deleted.</param>
        void Delete(int flagTypeId);

        /// <summary>
        /// Produces a paginated result of 10 FlagType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of FlagType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FlagType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 FlagType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of FlagType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FlagType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFlagTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of FlagType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IFlagTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of FlagType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FlagType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFlagTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of FlagType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IFlagTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of FlagType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FlagType> GetFiltered(long pageNumber, string filterName);



    }
}