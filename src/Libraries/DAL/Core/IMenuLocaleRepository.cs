// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IMenuLocaleRepository
    {
        /// <summary>
        /// Counts the number of MenuLocale in IMenuLocaleRepository.
        /// </summary>
        /// <returns>Returns the count of IMenuLocaleRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of MenuLocale. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of MenuLocale.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MenuLocale> GetAll();

        /// <summary>
        /// Returns all instances of MenuLocale to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of MenuLocale.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the MenuLocale against menuLocaleId. 
        /// </summary>
        /// <param name="menuLocaleId">The column "menu_locale_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of MenuLocale.</returns>
        MixERP.Net.Entities.Core.MenuLocale Get(int menuLocaleId);

        /// <summary>
        /// Gets the first record of MenuLocale.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of MenuLocale.</returns>
        MixERP.Net.Entities.Core.MenuLocale GetFirst();

        /// <summary>
        /// Gets the previous record of MenuLocale sorted by menuLocaleId. 
        /// </summary>
        /// <param name="menuLocaleId">The column "menu_locale_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of MenuLocale.</returns>
        MixERP.Net.Entities.Core.MenuLocale GetPrevious(int menuLocaleId);

        /// <summary>
        /// Gets the next record of MenuLocale sorted by menuLocaleId. 
        /// </summary>
        /// <param name="menuLocaleId">The column "menu_locale_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of MenuLocale.</returns>
        MixERP.Net.Entities.Core.MenuLocale GetNext(int menuLocaleId);

        /// <summary>
        /// Gets the last record of MenuLocale.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of MenuLocale.</returns>
        MixERP.Net.Entities.Core.MenuLocale GetLast();

        /// <summary>
        /// Returns multiple instances of the MenuLocale against menuLocaleIds. 
        /// </summary>
        /// <param name="menuLocaleIds">Array of column "menu_locale_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of MenuLocale.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MenuLocale> Get(int[] menuLocaleIds);

        /// <summary>
        /// Custom fields are user defined form elements for IMenuLocaleRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for MenuLocale.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding MenuLocale.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for MenuLocale.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of MenuLocale class to IMenuLocaleRepository.
        /// </summary>
        /// <param name="menuLocale">The instance of MenuLocale class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic menuLocale, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of MenuLocale class to IMenuLocaleRepository.
        /// </summary>
        /// <param name="menuLocale">The instance of MenuLocale class to insert.</param>
        object Add(dynamic menuLocale);

        /// <summary>
        /// Inserts or updates multiple instances of MenuLocale class to IMenuLocaleRepository.;
        /// </summary>
        /// <param name="menuLocales">List of MenuLocale class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> menuLocales);


        /// <summary>
        /// Updates IMenuLocaleRepository with an instance of MenuLocale class against the primary key value.
        /// </summary>
        /// <param name="menuLocale">The instance of MenuLocale class to update.</param>
        /// <param name="menuLocaleId">The value of the column "menu_locale_id" which will be updated.</param>
        void Update(dynamic menuLocale, int menuLocaleId);

        /// <summary>
        /// Deletes MenuLocale from  IMenuLocaleRepository against the primary key value.
        /// </summary>
        /// <param name="menuLocaleId">The value of the column "menu_locale_id" which will be deleted.</param>
        void Delete(int menuLocaleId);

        /// <summary>
        /// Produces a paginated result of 10 MenuLocale classes.
        /// </summary>
        /// <returns>Returns the first page of collection of MenuLocale class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MenuLocale> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 MenuLocale classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of MenuLocale class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MenuLocale> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IMenuLocaleRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of MenuLocale class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IMenuLocaleRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of MenuLocale class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MenuLocale> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IMenuLocaleRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of MenuLocale class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IMenuLocaleRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of MenuLocale class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.MenuLocale> GetFiltered(long pageNumber, string filterName);



    }
}