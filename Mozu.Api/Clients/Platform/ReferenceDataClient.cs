
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Platform
{
	/// <summary>
	/// The Reference resource retrieves collections of standards the Mozu system currently supports. This includes content locales, top-level domains, units of measure, countries, currencies, time zones, and shipping or billing address schemas.
	/// </summary>
	public partial class ReferenceDataClient 	{
		
		/// <summary>
		/// Retrieves a specific address schema based on the country code provided. This operation allows the creation of custom shipping and billing address fields.
		/// </summary>
		/// <param name="countryCode">The 2-letter geographic code representing the country for the physical or mailing address. Currently limited to the US.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Reference.AddressSchema"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAddressSchema( countryCode,  responseFields);
		///   var addressSchemaClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Reference.AddressSchema> GetAddressSchemaClient(string countryCode =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetAddressSchemaUrl(countryCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Reference.AddressSchema>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the entire list of address schemas that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Reference.AddressSchemaCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAddressSchemas( responseFields);
		///   var addressSchemaCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Reference.AddressSchemaCollection> GetAddressSchemasClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetAddressSchemasUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Reference.AddressSchemaCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a behavior based on the behavior ID specified in the request.
		/// </summary>
		/// <param name="behaviorId">Unique identifier of the behavior.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.Behavior"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetBehavior( behaviorId,  responseFields);
		///   var behaviorClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.Behavior> GetBehaviorClient(int behaviorId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetBehaviorUrl(behaviorId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Core.Behavior>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of the behavior category specified in the request.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.BehaviorCategory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetBehaviorCategory( categoryId,  responseFields);
		///   var behaviorCategoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.BehaviorCategory> GetBehaviorCategoryClient(int categoryId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetBehaviorCategoryUrl(categoryId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Core.BehaviorCategory>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the list of behavior categories.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.BehaviorCategoryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetBehaviorCategories( responseFields);
		///   var behaviorCategoryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.BehaviorCategoryCollection> GetBehaviorCategoriesClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetBehaviorCategoriesUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Core.BehaviorCategoryCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of application behaviors.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userType">The user type associated with the behaviors to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.BehaviorCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetBehaviors( userType,  responseFields);
		///   var behaviorCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.BehaviorCollection> GetBehaviorsClient(string userType =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetBehaviorsUrl(userType, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Core.BehaviorCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the list of content locales the system supports. Content locales indicate the language used and the country where the language is used.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Reference.ContentLocaleCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetContentLocales( responseFields);
		///   var contentLocaleCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Reference.ContentLocaleCollection> GetContentLocalesClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetContentLocalesUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Reference.ContentLocaleCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the entire list of countries that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Reference.CountryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCountries( responseFields);
		///   var countryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Reference.CountryCollection> GetCountriesClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetCountriesUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Reference.CountryCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the entire list of countries that the system supports.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Reference.CountryWithStatesCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCountriesWithStates( responseFields);
		///   var countryWithStatesCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Reference.CountryWithStatesCollection> GetCountriesWithStatesClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetCountriesWithStatesUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Reference.CountryWithStatesCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the entire list of currencies that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Reference.CurrencyCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCurrencies( responseFields);
		///   var currencyCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Reference.CurrencyCollection> GetCurrenciesClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetCurrenciesUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Reference.CurrencyCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the entire list of time zones that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Reference.TimeZoneCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetTimeZones( responseFields);
		///   var timeZoneCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Reference.TimeZoneCollection> GetTimeZonesClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetTimeZonesUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Reference.TimeZoneCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the entire list of top-level internet domains that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Reference.TopLevelDomainCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetTopLevelDomains( responseFields);
		///   var topLevelDomainCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Reference.TopLevelDomainCollection> GetTopLevelDomainsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetTopLevelDomainsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Reference.TopLevelDomainCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves an array list of all units of measure the system supports.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Reference.UnitOfMeasureCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetUnitsOfMeasure( filter,  responseFields);
		///   var unitOfMeasureCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Reference.UnitOfMeasureCollection> GetUnitsOfMeasureClient(string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ReferenceDataUrl.GetUnitsOfMeasureUrl(filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Reference.UnitOfMeasureCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


