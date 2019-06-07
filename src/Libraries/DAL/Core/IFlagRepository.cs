// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IFlagRepository
    {
        /// <summary>
        /// Counts the number of Flag in IFlagRepository.
        /// </summary>
        /// <returns>Returns the count of IFlagRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Flag. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Flag.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Flag> GetAll();

        /// <summary>
        /// Returns all instances of Flag to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Flag.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Flag against flagId. 
        /// </summary>
        /// <param name="flagId">The column "flag_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Flag.</returns>
        MixERP.Net.Entities.Core.Flag Get(long flagId);

        /// <summary>
        /// Gets the first record of Flag.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Flag.</returns>
        MixERP.Net.Entities.Core.Flag GetFirst();

        /// <summary>
        /// Gets the previous record of Flag sorted by flagId. 
        /// </summary>
        /// <param name="flagId">The column "flag_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Flag.</returns>
        MixERP.Net.Entities.Core.Flag GetPrevious(long flagId);

        /// <summary>
        /// Gets the next record of Flag sorted by flagId. 
        /// </summary>
        /// <param name="flagId">The column "flag_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Flag.</returns>
        MixERP.Net.Entities.Core.Flag GetNext(long flagId);

        /// <summary>
        /// Gets the last record of Flag.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Flag.</returns>
        MixERP.Net.Entities.Core.Flag GetLast();

        /// <summary>
        /// Returns multiple instances of the Flag against flagIds. 
        /// </summary>
        /// <param name="flagIds">Array of column "flag_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Flag.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Flag> Get(long[] flagIds);

        /// <summary>
        /// Custom fields are user defined form elements for IFlagRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Flag.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Flag.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Flag.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Flag class to IFlagRepository.
        /// </summary>
        /// <param name="flag">The instance of Flag class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic flag, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Flag class to IFlagRepository.
        /// </summary>
        /// <param name="flag">The instance of Flag class to insert.</param>
        object Add(dynamic flag);

        /// <summary>
        /// Inserts or updates multiple instances of Flag class to IFlagRepository.;
        /// </summary>
        /// <param name="flags">List of Flag class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> flags);


        /// <summary>
        /// Updates IFlagRepository with an instance of Flag class against the primary key value.
        /// </summary>
        /// <param name="flag">The instance of Flag class to update.</param>
        /// <param name="flagId">The value of the column "flag_id" which will be updated.</param>
        void Update(dynamic flag, long flagId);

        /// <summary>
        /// Deletes Flag from  IFlagRepository against the primary key value.
        /// </summary>
        /// <param name="flagId">The value of the column "flag_id" which will be deleted.</param>
        void Delete(long flagId);

        /// <summary>
        /// Produces a paginated result of 10 Flag classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Flag class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Flag> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Flag classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Flag class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Flag> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFlagRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Flag class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IFlagRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Flag class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Flag> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFlagRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Flag class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IFlagRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Flag class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Flag> GetFiltered(long pageNumber, string filterName);



    }
}