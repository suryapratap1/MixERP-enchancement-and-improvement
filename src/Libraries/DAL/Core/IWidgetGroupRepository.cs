// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IWidgetGroupRepository
    {
        /// <summary>
        /// Counts the number of WidgetGroup in IWidgetGroupRepository.
        /// </summary>
        /// <returns>Returns the count of IWidgetGroupRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of WidgetGroup. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of WidgetGroup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> GetAll();

        /// <summary>
        /// Returns all instances of WidgetGroup to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of WidgetGroup.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the WidgetGroup against widgetGroupName. 
        /// </summary>
        /// <param name="widgetGroupName">The column "widget_group_name" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of WidgetGroup.</returns>
        MixERP.Net.Entities.Core.WidgetGroup Get(string widgetGroupName);

        /// <summary>
        /// Gets the first record of WidgetGroup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of WidgetGroup.</returns>
        MixERP.Net.Entities.Core.WidgetGroup GetFirst();

        /// <summary>
        /// Gets the previous record of WidgetGroup sorted by widgetGroupName. 
        /// </summary>
        /// <param name="widgetGroupName">The column "widget_group_name" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of WidgetGroup.</returns>
        MixERP.Net.Entities.Core.WidgetGroup GetPrevious(string widgetGroupName);

        /// <summary>
        /// Gets the next record of WidgetGroup sorted by widgetGroupName. 
        /// </summary>
        /// <param name="widgetGroupName">The column "widget_group_name" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of WidgetGroup.</returns>
        MixERP.Net.Entities.Core.WidgetGroup GetNext(string widgetGroupName);

        /// <summary>
        /// Gets the last record of WidgetGroup.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of WidgetGroup.</returns>
        MixERP.Net.Entities.Core.WidgetGroup GetLast();

        /// <summary>
        /// Returns multiple instances of the WidgetGroup against widgetGroupNames. 
        /// </summary>
        /// <param name="widgetGroupNames">Array of column "widget_group_name" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of WidgetGroup.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> Get(string[] widgetGroupNames);

        /// <summary>
        /// Custom fields are user defined form elements for IWidgetGroupRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for WidgetGroup.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding WidgetGroup.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for WidgetGroup.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of WidgetGroup class to IWidgetGroupRepository.
        /// </summary>
        /// <param name="widgetGroup">The instance of WidgetGroup class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic widgetGroup, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of WidgetGroup class to IWidgetGroupRepository.
        /// </summary>
        /// <param name="widgetGroup">The instance of WidgetGroup class to insert.</param>
        object Add(dynamic widgetGroup);

        /// <summary>
        /// Inserts or updates multiple instances of WidgetGroup class to IWidgetGroupRepository.;
        /// </summary>
        /// <param name="widgetGroups">List of WidgetGroup class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> widgetGroups);


        /// <summary>
        /// Updates IWidgetGroupRepository with an instance of WidgetGroup class against the primary key value.
        /// </summary>
        /// <param name="widgetGroup">The instance of WidgetGroup class to update.</param>
        /// <param name="widgetGroupName">The value of the column "widget_group_name" which will be updated.</param>
        void Update(dynamic widgetGroup, string widgetGroupName);

        /// <summary>
        /// Deletes WidgetGroup from  IWidgetGroupRepository against the primary key value.
        /// </summary>
        /// <param name="widgetGroupName">The value of the column "widget_group_name" which will be deleted.</param>
        void Delete(string widgetGroupName);

        /// <summary>
        /// Produces a paginated result of 10 WidgetGroup classes.
        /// </summary>
        /// <returns>Returns the first page of collection of WidgetGroup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 WidgetGroup classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of WidgetGroup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IWidgetGroupRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of WidgetGroup class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IWidgetGroupRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of WidgetGroup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IWidgetGroupRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of WidgetGroup class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IWidgetGroupRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of WidgetGroup class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> GetFiltered(long pageNumber, string filterName);



    }
}