// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IWidgetSetupRepository
    {
        /// <summary>
        /// Counts the number of WidgetSetup in IWidgetSetupRepository.
        /// </summary>
        /// <returns>Returns the count of IWidgetSetupRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of WidgetSetup. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of WidgetSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> GetAll();

        /// <summary>
        /// Returns all instances of WidgetSetup to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of WidgetSetup.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the WidgetSetup against widgetSetupId. 
        /// </summary>
        /// <param name="widgetSetupId">The column "widget_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of WidgetSetup.</returns>
        MixERP.Net.Entities.Core.WidgetSetup Get(int widgetSetupId);

        /// <summary>
        /// Gets the first record of WidgetSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of WidgetSetup.</returns>
        MixERP.Net.Entities.Core.WidgetSetup GetFirst();

        /// <summary>
        /// Gets the previous record of WidgetSetup sorted by widgetSetupId. 
        /// </summary>
        /// <param name="widgetSetupId">The column "widget_setup_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of WidgetSetup.</returns>
        MixERP.Net.Entities.Core.WidgetSetup GetPrevious(int widgetSetupId);

        /// <summary>
        /// Gets the next record of WidgetSetup sorted by widgetSetupId. 
        /// </summary>
        /// <param name="widgetSetupId">The column "widget_setup_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of WidgetSetup.</returns>
        MixERP.Net.Entities.Core.WidgetSetup GetNext(int widgetSetupId);

        /// <summary>
        /// Gets the last record of WidgetSetup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of WidgetSetup.</returns>
        MixERP.Net.Entities.Core.WidgetSetup GetLast();

        /// <summary>
        /// Returns multiple instances of the WidgetSetup against widgetSetupIds. 
        /// </summary>
        /// <param name="widgetSetupIds">Array of column "widget_setup_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of WidgetSetup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> Get(int[] widgetSetupIds);

        /// <summary>
        /// Custom fields are user defined form elements for IWidgetSetupRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for WidgetSetup.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding WidgetSetup.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for WidgetSetup.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of WidgetSetup class to IWidgetSetupRepository.
        /// </summary>
        /// <param name="widgetSetup">The instance of WidgetSetup class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic widgetSetup, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of WidgetSetup class to IWidgetSetupRepository.
        /// </summary>
        /// <param name="widgetSetup">The instance of WidgetSetup class to insert.</param>
        object Add(dynamic widgetSetup);

        /// <summary>
        /// Inserts or updates multiple instances of WidgetSetup class to IWidgetSetupRepository.;
        /// </summary>
        /// <param name="widgetSetups">List of WidgetSetup class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> widgetSetups);


        /// <summary>
        /// Updates IWidgetSetupRepository with an instance of WidgetSetup class against the primary key value.
        /// </summary>
        /// <param name="widgetSetup">The instance of WidgetSetup class to update.</param>
        /// <param name="widgetSetupId">The value of the column "widget_setup_id" which will be updated.</param>
        void Update(dynamic widgetSetup, int widgetSetupId);

        /// <summary>
        /// Deletes WidgetSetup from  IWidgetSetupRepository against the primary key value.
        /// </summary>
        /// <param name="widgetSetupId">The value of the column "widget_setup_id" which will be deleted.</param>
        void Delete(int widgetSetupId);

        /// <summary>
        /// Produces a paginated result of 10 WidgetSetup classes.
        /// </summary>
        /// <returns>Returns the first page of collection of WidgetSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 WidgetSetup classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of WidgetSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IWidgetSetupRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of WidgetSetup class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IWidgetSetupRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of WidgetSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IWidgetSetupRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of WidgetSetup class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IWidgetSetupRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of WidgetSetup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> GetFiltered(long pageNumber, string filterName);



    }
}