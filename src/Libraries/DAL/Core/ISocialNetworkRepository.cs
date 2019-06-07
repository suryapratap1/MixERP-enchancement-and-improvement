// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ISocialNetworkRepository
    {
        /// <summary>
        /// Counts the number of SocialNetwork in ISocialNetworkRepository.
        /// </summary>
        /// <returns>Returns the count of ISocialNetworkRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of SocialNetwork. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SocialNetwork.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetAll();

        /// <summary>
        /// Returns all instances of SocialNetwork to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of SocialNetwork.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the SocialNetwork against socialNetworkName. 
        /// </summary>
        /// <param name="socialNetworkName">The column "social_network_name" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of SocialNetwork.</returns>
        MixERP.Net.Entities.Core.SocialNetwork Get(string socialNetworkName);

        /// <summary>
        /// Gets the first record of SocialNetwork.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SocialNetwork.</returns>
        MixERP.Net.Entities.Core.SocialNetwork GetFirst();

        /// <summary>
        /// Gets the previous record of SocialNetwork sorted by socialNetworkName. 
        /// </summary>
        /// <param name="socialNetworkName">The column "social_network_name" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SocialNetwork.</returns>
        MixERP.Net.Entities.Core.SocialNetwork GetPrevious(string socialNetworkName);

        /// <summary>
        /// Gets the next record of SocialNetwork sorted by socialNetworkName. 
        /// </summary>
        /// <param name="socialNetworkName">The column "social_network_name" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of SocialNetwork.</returns>
        MixERP.Net.Entities.Core.SocialNetwork GetNext(string socialNetworkName);

        /// <summary>
        /// Gets the last record of SocialNetwork.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of SocialNetwork.</returns>
        MixERP.Net.Entities.Core.SocialNetwork GetLast();

        /// <summary>
        /// Returns multiple instances of the SocialNetwork against socialNetworkNames. 
        /// </summary>
        /// <param name="socialNetworkNames">Array of column "social_network_name" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of SocialNetwork.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> Get(string[] socialNetworkNames);

        /// <summary>
        /// Custom fields are user defined form elements for ISocialNetworkRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for SocialNetwork.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding SocialNetwork.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for SocialNetwork.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of SocialNetwork class to ISocialNetworkRepository.
        /// </summary>
        /// <param name="socialNetwork">The instance of SocialNetwork class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic socialNetwork, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of SocialNetwork class to ISocialNetworkRepository.
        /// </summary>
        /// <param name="socialNetwork">The instance of SocialNetwork class to insert.</param>
        object Add(dynamic socialNetwork);

        /// <summary>
        /// Inserts or updates multiple instances of SocialNetwork class to ISocialNetworkRepository.;
        /// </summary>
        /// <param name="socialNetworks">List of SocialNetwork class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> socialNetworks);


        /// <summary>
        /// Updates ISocialNetworkRepository with an instance of SocialNetwork class against the primary key value.
        /// </summary>
        /// <param name="socialNetwork">The instance of SocialNetwork class to update.</param>
        /// <param name="socialNetworkName">The value of the column "social_network_name" which will be updated.</param>
        void Update(dynamic socialNetwork, string socialNetworkName);

        /// <summary>
        /// Deletes SocialNetwork from  ISocialNetworkRepository against the primary key value.
        /// </summary>
        /// <param name="socialNetworkName">The value of the column "social_network_name" which will be deleted.</param>
        void Delete(string socialNetworkName);

        /// <summary>
        /// Produces a paginated result of 10 SocialNetwork classes.
        /// </summary>
        /// <returns>Returns the first page of collection of SocialNetwork class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 SocialNetwork classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of SocialNetwork class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ISocialNetworkRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of SocialNetwork class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against ISocialNetworkRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of SocialNetwork class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ISocialNetworkRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of SocialNetwork class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of ISocialNetworkRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of SocialNetwork class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.SocialNetwork> GetFiltered(long pageNumber, string filterName);



    }
}