// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IExitTypeRepository
    {
        /// <summary>
        /// Counts the number of ExitType in IExitTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IExitTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ExitType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ExitType.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ExitType> GetAll();

        /// <summary>
        /// Returns all instances of ExitType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ExitType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ExitType against exitTypeId. 
        /// </summary>
        /// <param name="exitTypeId">The column "exit_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ExitType.</returns>
        MixERP.Net.Entities.HRM.ExitType Get(int exitTypeId);

        /// <summary>
        /// Gets the first record of ExitType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ExitType.</returns>
        MixERP.Net.Entities.HRM.ExitType GetFirst();

        /// <summary>
        /// Gets the previous record of ExitType sorted by exitTypeId. 
        /// </summary>
        /// <param name="exitTypeId">The column "exit_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ExitType.</returns>
        MixERP.Net.Entities.HRM.ExitType GetPrevious(int exitTypeId);

        /// <summary>
        /// Gets the next record of ExitType sorted by exitTypeId. 
        /// </summary>
        /// <param name="exitTypeId">The column "exit_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ExitType.</returns>
        MixERP.Net.Entities.HRM.ExitType GetNext(int exitTypeId);

        /// <summary>
        /// Gets the last record of ExitType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ExitType.</returns>
        MixERP.Net.Entities.HRM.ExitType GetLast();

        /// <summary>
        /// Returns multiple instances of the ExitType against exitTypeIds. 
        /// </summary>
        /// <param name="exitTypeIds">Array of column "exit_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ExitType.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ExitType> Get(int[] exitTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IExitTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ExitType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ExitType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ExitType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ExitType class to IExitTypeRepository.
        /// </summary>
        /// <param name="exitType">The instance of ExitType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic exitType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ExitType class to IExitTypeRepository.
        /// </summary>
        /// <param name="exitType">The instance of ExitType class to insert.</param>
        object Add(dynamic exitType);

        /// <summary>
        /// Inserts or updates multiple instances of ExitType class to IExitTypeRepository.;
        /// </summary>
        /// <param name="exitTypes">List of ExitType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> exitTypes);


        /// <summary>
        /// Updates IExitTypeRepository with an instance of ExitType class against the primary key value.
        /// </summary>
        /// <param name="exitType">The instance of ExitType class to update.</param>
        /// <param name="exitTypeId">The value of the column "exit_type_id" which will be updated.</param>
        void Update(dynamic exitType, int exitTypeId);

        /// <summary>
        /// Deletes ExitType from  IExitTypeRepository against the primary key value.
        /// </summary>
        /// <param name="exitTypeId">The value of the column "exit_type_id" which will be deleted.</param>
        void Delete(int exitTypeId);

        /// <summary>
        /// Produces a paginated result of 10 ExitType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ExitType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ExitType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ExitType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ExitType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ExitType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IExitTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ExitType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IExitTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ExitType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ExitType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IExitTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ExitType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IExitTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ExitType class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.ExitType> GetFiltered(long pageNumber, string filterName);



    }
}