// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IWidgetRepository
    {
        /// <summary>
        /// Counts the number of Widget in IWidgetRepository.
        /// </summary>
        /// <returns>Returns the count of IWidgetRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Widget. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Widget.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Widget> GetAll();

        /// <summary>
        /// Returns all instances of Widget to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Widget.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Widget against widgetName. 
        /// </summary>
        /// <param name="widgetName">The column "widget_name" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Widget.</returns>
        MixERP.Net.Entities.Core.Widget Get(string widgetName);

        /// <summary>
        /// Gets the first record of Widget.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Widget.</returns>
        MixERP.Net.Entities.Core.Widget GetFirst();

        /// <summary>
        /// Gets the previous record of Widget sorted by widgetName. 
        /// </summary>
        /// <param name="widgetName">The column "widget_name" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Widget.</returns>
        MixERP.Net.Entities.Core.Widget GetPrevious(string widgetName);

        /// <summary>
        /// Gets the next record of Widget sorted by widgetName. 
        /// </summary>
        /// <param name="widgetName">The column "widget_name" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Widget.</returns>
        MixERP.Net.Entities.Core.Widget GetNext(string widgetName);

        /// <summary>
        /// Gets the last record of Widget.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Widget.</returns>
        MixERP.Net.Entities.Core.Widget GetLast();

        /// <summary>
        /// Returns multiple instances of the Widget against widgetNames. 
        /// </summary>
        /// <param name="widgetNames">Array of column "widget_name" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Widget.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Widget> Get(string[] widgetNames);

        /// <summary>
        /// Custom fields are user defined form elements for IWidgetRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Widget.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Widget.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Widget.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Widget class to IWidgetRepository.
        /// </summary>
        /// <param name="widget">The instance of Widget class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic widget, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Widget class to IWidgetRepository.
        /// </summary>
        /// <param name="widget">The instance of Widget class to insert.</param>
        object Add(dynamic widget);

        /// <summary>
        /// Inserts or updates multiple instances of Widget class to IWidgetRepository.;
        /// </summary>
        /// <param name="widgets">List of Widget class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> widgets);


        /// <summary>
        /// Updates IWidgetRepository with an instance of Widget class against the primary key value.
        /// </summary>
        /// <param name="widget">The instance of Widget class to update.</param>
        /// <param name="widgetName">The value of the column "widget_name" which will be updated.</param>
        void Update(dynamic widget, string widgetName);

        /// <summary>
        /// Deletes Widget from  IWidgetRepository against the primary key value.
        /// </summary>
        /// <param name="widgetName">The value of the column "widget_name" which will be deleted.</param>
        void Delete(string widgetName);

        /// <summary>
        /// Produces a paginated result of 10 Widget classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Widget class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Widget> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Widget classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Widget class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Widget> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IWidgetRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Widget class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IWidgetRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Widget class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Widget> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IWidgetRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Widget class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IWidgetRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Widget class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Widget> GetFiltered(long pageNumber, string filterName);



    }
}