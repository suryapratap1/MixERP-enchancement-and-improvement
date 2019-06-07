// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPartyRepository
    {
        /// <summary>
        /// Counts the number of Party in IPartyRepository.
        /// </summary>
        /// <returns>Returns the count of IPartyRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Party. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Party.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Party> GetAll();

        /// <summary>
        /// Returns all instances of Party to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Party.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Party against partyId. 
        /// </summary>
        /// <param name="partyId">The column "party_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Party.</returns>
        MixERP.Net.Entities.Core.Party Get(long partyId);

        /// <summary>
        /// Gets the first record of Party.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Party.</returns>
        MixERP.Net.Entities.Core.Party GetFirst();

        /// <summary>
        /// Gets the previous record of Party sorted by partyId. 
        /// </summary>
        /// <param name="partyId">The column "party_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Party.</returns>
        MixERP.Net.Entities.Core.Party GetPrevious(long partyId);

        /// <summary>
        /// Gets the next record of Party sorted by partyId. 
        /// </summary>
        /// <param name="partyId">The column "party_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Party.</returns>
        MixERP.Net.Entities.Core.Party GetNext(long partyId);

        /// <summary>
        /// Gets the last record of Party.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Party.</returns>
        MixERP.Net.Entities.Core.Party GetLast();

        /// <summary>
        /// Returns multiple instances of the Party against partyIds. 
        /// </summary>
        /// <param name="partyIds">Array of column "party_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Party.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Party> Get(long[] partyIds);

        /// <summary>
        /// Custom fields are user defined form elements for IPartyRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Party.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Party.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Party.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Party class to IPartyRepository.
        /// </summary>
        /// <param name="party">The instance of Party class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic party, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Party class to IPartyRepository.
        /// </summary>
        /// <param name="party">The instance of Party class to insert.</param>
        object Add(dynamic party);

        /// <summary>
        /// Inserts or updates multiple instances of Party class to IPartyRepository.;
        /// </summary>
        /// <param name="parties">List of Party class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> parties);


        /// <summary>
        /// Updates IPartyRepository with an instance of Party class against the primary key value.
        /// </summary>
        /// <param name="party">The instance of Party class to update.</param>
        /// <param name="partyId">The value of the column "party_id" which will be updated.</param>
        void Update(dynamic party, long partyId);

        /// <summary>
        /// Deletes Party from  IPartyRepository against the primary key value.
        /// </summary>
        /// <param name="partyId">The value of the column "party_id" which will be deleted.</param>
        void Delete(long partyId);

        /// <summary>
        /// Produces a paginated result of 10 Party classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Party class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Party> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Party classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Party class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Party> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPartyRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Party class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IPartyRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Party class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Party> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPartyRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Party class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IPartyRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Party class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Party> GetFiltered(long pageNumber, string filterName);



    }
}