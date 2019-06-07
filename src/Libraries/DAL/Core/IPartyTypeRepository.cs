// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IPartyTypeRepository
    {
        /// <summary>
        /// Counts the number of PartyType in IPartyTypeRepository.
        /// </summary>
        /// <returns>Returns the count of IPartyTypeRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of PartyType. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PartyType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyType> GetAll();

        /// <summary>
        /// Returns all instances of PartyType to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of PartyType.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the PartyType against partyTypeId. 
        /// </summary>
        /// <param name="partyTypeId">The column "party_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of PartyType.</returns>
        MixERP.Net.Entities.Core.PartyType Get(int partyTypeId);

        /// <summary>
        /// Gets the first record of PartyType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PartyType.</returns>
        MixERP.Net.Entities.Core.PartyType GetFirst();

        /// <summary>
        /// Gets the previous record of PartyType sorted by partyTypeId. 
        /// </summary>
        /// <param name="partyTypeId">The column "party_type_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PartyType.</returns>
        MixERP.Net.Entities.Core.PartyType GetPrevious(int partyTypeId);

        /// <summary>
        /// Gets the next record of PartyType sorted by partyTypeId. 
        /// </summary>
        /// <param name="partyTypeId">The column "party_type_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of PartyType.</returns>
        MixERP.Net.Entities.Core.PartyType GetNext(int partyTypeId);

        /// <summary>
        /// Gets the last record of PartyType.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of PartyType.</returns>
        MixERP.Net.Entities.Core.PartyType GetLast();

        /// <summary>
        /// Returns multiple instances of the PartyType against partyTypeIds. 
        /// </summary>
        /// <param name="partyTypeIds">Array of column "party_type_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of PartyType.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyType> Get(int[] partyTypeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IPartyTypeRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for PartyType.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding PartyType.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for PartyType.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of PartyType class to IPartyTypeRepository.
        /// </summary>
        /// <param name="partyType">The instance of PartyType class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic partyType, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of PartyType class to IPartyTypeRepository.
        /// </summary>
        /// <param name="partyType">The instance of PartyType class to insert.</param>
        object Add(dynamic partyType);

        /// <summary>
        /// Inserts or updates multiple instances of PartyType class to IPartyTypeRepository.;
        /// </summary>
        /// <param name="partyTypes">List of PartyType class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> partyTypes);


        /// <summary>
        /// Updates IPartyTypeRepository with an instance of PartyType class against the primary key value.
        /// </summary>
        /// <param name="partyType">The instance of PartyType class to update.</param>
        /// <param name="partyTypeId">The value of the column "party_type_id" which will be updated.</param>
        void Update(dynamic partyType, int partyTypeId);

        /// <summary>
        /// Deletes PartyType from  IPartyTypeRepository against the primary key value.
        /// </summary>
        /// <param name="partyTypeId">The value of the column "party_type_id" which will be deleted.</param>
        void Delete(int partyTypeId);

        /// <summary>
        /// Produces a paginated result of 10 PartyType classes.
        /// </summary>
        /// <returns>Returns the first page of collection of PartyType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyType> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 PartyType classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of PartyType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyType> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IPartyTypeRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of PartyType class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IPartyTypeRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of PartyType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyType> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IPartyTypeRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of PartyType class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IPartyTypeRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of PartyType class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.PartyType> GetFiltered(long pageNumber, string filterName);



    }
}