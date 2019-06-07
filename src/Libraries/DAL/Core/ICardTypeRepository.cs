// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICardTypeRepository
    {
        /// <summary>
        /// Counts the number of CardType in ICardTypeRepository.
        /// </summary>
        /// <returns>Returns the count of ICardTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of CardType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CardType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CardType> GetAll();

        /// <summary>
        /// Returns all instances of CardType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of CardType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the CardType against cardTypeId. 
        /// </summary>
        /// <param name="cardTypeId">The column "card_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of CardType.</returns>
        MixERP.Net.Entities.Core.CardType Get(int cardTypeId);

        /// <summary>
        /// Gets the first record of CardType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CardType.</returns>
        MixERP.Net.Entities.Core.CardType GetFirst();

        /// <summary>
        /// Gets the previous record of CardType sorted by cardTypeId. 
        /// </summary>
        /// <param name="cardTypeId">The column "card_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CardType.</returns>
        MixERP.Net.Entities.Core.CardType GetPrevious(int cardTypeId);

        /// <summary>
        /// Gets the next record of CardType sorted by cardTypeId. 
        /// </summary>
        /// <param name="cardTypeId">The column "card_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of CardType.</returns>
        MixERP.Net.Entities.Core.CardType GetNext(int cardTypeId);

        /// <summary>
        /// Gets the last record of CardType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of CardType.</returns>
        MixERP.Net.Entities.Core.CardType GetLast();

        /// <summary>
        /// Returns multiple instances of the CardType against cardTypeIds. 
        /// </summary>
        /// <param name="cardTypeIds">Array of column "card_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of CardType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CardType> Get(int[] cardTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for ICardTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for CardType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding CardType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for CardType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of CardType class to ICardTypeRepository.
        /// </summary>
        /// <param name="cardType">The instance of CardType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic cardType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of CardType class to ICardTypeRepository.
        /// </summary>
        /// <param name="cardType">The instance of CardType class to insert.</param>
        object Add(dynamic cardType);

        /// <summary>
        /// Inserts or updates multiple instances of CardType class to ICardTypeRepository.;
        /// </summary>
        /// <param name="cardTypes">List of CardType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> cardTypes);


        /// <summary>
        /// Updates ICardTypeRepository with an instance of CardType class against the primary key value.
        /// </summary>
        /// <param name="cardType">The instance of CardType class to update.</param>
        /// <param name="cardTypeId">The value of the column "card_type_id" which will be updated.</param>
        void Update(dynamic cardType, int cardTypeId);

        /// <summary>
        /// Deletes CardType from  ICardTypeRepository against the primary key value.
        /// </summary>
        /// <param name="cardTypeId">The value of the column "card_type_id" which will be deleted.</param>
        void Delete(int cardTypeId);

        /// <summary>
        /// Produces a paginated result of 10 CardType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of CardType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CardType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 CardType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of CardType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CardType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICardTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of CardType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ICardTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of CardType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CardType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICardTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of CardType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ICardTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of CardType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CardType> GetFiltered(long pageNumber, string filterName);



    }
}