// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IMenuRepository
    {
        /// <summary>
        /// Counts the number of Menu in IMenuRepository.
        /// </summary>
        /// <returns>Returns the count of IMenuRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Menu. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Menu.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Menu> GetAll();

        /// <summary>
        /// Returns all instances of Menu to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Menu.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Menu against menuId. 
        /// </summary>
        /// <param name="menuId">The column "menu_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Menu.</returns>
        MixERP.Net.Entities.Core.Menu Get(int menuId);

        /// <summary>
        /// Gets the first record of Menu.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Menu.</returns>
        MixERP.Net.Entities.Core.Menu GetFirst();

        /// <summary>
        /// Gets the previous record of Menu sorted by menuId. 
        /// </summary>
        /// <param name="menuId">The column "menu_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Menu.</returns>
        MixERP.Net.Entities.Core.Menu GetPrevious(int menuId);

        /// <summary>
        /// Gets the next record of Menu sorted by menuId. 
        /// </summary>
        /// <param name="menuId">The column "menu_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Menu.</returns>
        MixERP.Net.Entities.Core.Menu GetNext(int menuId);

        /// <summary>
        /// Gets the last record of Menu.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Menu.</returns>
        MixERP.Net.Entities.Core.Menu GetLast();

        /// <summary>
        /// Returns multiple instances of the Menu against menuIds. 
        /// </summary>
        /// <param name="menuIds">Array of column "menu_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Menu.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Menu> Get(int[] menuIds);

        /// <summary>
        /// Custom fields are user defined form elements for IMenuRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Menu.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Menu.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Menu.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Menu class to IMenuRepository.
        /// </summary>
        /// <param name="menu">The instance of Menu class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic menu, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Menu class to IMenuRepository.
        /// </summary>
        /// <param name="menu">The instance of Menu class to insert.</param>
        object Add(dynamic menu);

        /// <summary>
        /// Inserts or updates multiple instances of Menu class to IMenuRepository.;
        /// </summary>
        /// <param name="menus">List of Menu class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> menus);


        /// <summary>
        /// Updates IMenuRepository with an instance of Menu class against the primary key value.
        /// </summary>
        /// <param name="menu">The instance of Menu class to update.</param>
        /// <param name="menuId">The value of the column "menu_id" which will be updated.</param>
        void Update(dynamic menu, int menuId);

        /// <summary>
        /// Deletes Menu from  IMenuRepository against the primary key value.
        /// </summary>
        /// <param name="menuId">The value of the column "menu_id" which will be deleted.</param>
        void Delete(int menuId);

        /// <summary>
        /// Produces a paginated result of 10 Menu classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Menu class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Menu> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Menu classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Menu class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Menu> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IMenuRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Menu class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IMenuRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Menu class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Menu> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IMenuRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Menu class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IMenuRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Menu class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Menu> GetFiltered(long pageNumber, string filterName);



    }
}