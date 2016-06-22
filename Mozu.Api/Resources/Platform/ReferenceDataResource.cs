
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

namespace Mozu.Api.Resources.Platform
{
	/// <summary>
	/// The Reference resource retrieves collections of standards the Mozu system currently supports. This includes content locales, top-level domains, units of measure, countries, currencies, time zones, and shipping or billing address schemas.
	/// </summary>
	public partial class ReferenceDataResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ReferenceDataResource() 
		{
			_apiContext = null;
		}
		 public ReferenceDataResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ReferenceDataResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ReferenceDataResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a specific address schema based on the country code provided. This operation allows the creation of custom shipping and billing address fields.
		/// </summary>
		/// <param name="countryCode">The 2-letter geographic code representing the country for the physical or mailing address. Currently limited to the US.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.AddressSchema"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var addressSchema = referencedata.GetAddressSchema( countryCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Reference.AddressSchema GetAddressSchema(string countryCode =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.AddressSchema> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetAddressSchemaClient( countryCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a specific address schema based on the country code provided. This operation allows the creation of custom shipping and billing address fields.
		/// </summary>
		/// <param name="countryCode">The 2-letter geographic code representing the country for the physical or mailing address. Currently limited to the US.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.AddressSchema"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var addressSchema = await referencedata.GetAddressSchemaAsync( countryCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Reference.AddressSchema> GetAddressSchemaAsync(string countryCode =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.AddressSchema> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetAddressSchemaClient( countryCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the entire list of address schemas that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.AddressSchemaCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var addressSchemaCollection = referencedata.GetAddressSchemas( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Reference.AddressSchemaCollection GetAddressSchemas(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.AddressSchemaCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetAddressSchemasClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the entire list of address schemas that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.AddressSchemaCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var addressSchemaCollection = await referencedata.GetAddressSchemasAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Reference.AddressSchemaCollection> GetAddressSchemasAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.AddressSchemaCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetAddressSchemasClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a behavior based on the behavior ID specified in the request.
		/// </summary>
		/// <param name="behaviorId">Unique identifier of the behavior.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.Behavior"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behavior = referencedata.GetBehavior( behaviorId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Core.Behavior GetBehavior(int behaviorId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.Behavior> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorClient( behaviorId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a behavior based on the behavior ID specified in the request.
		/// </summary>
		/// <param name="behaviorId">Unique identifier of the behavior.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.Behavior"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behavior = await referencedata.GetBehaviorAsync( behaviorId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Core.Behavior> GetBehaviorAsync(int behaviorId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.Behavior> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorClient( behaviorId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the behavior category specified in the request.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.BehaviorCategory"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behaviorCategory = referencedata.GetBehaviorCategory( categoryId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Core.BehaviorCategory GetBehaviorCategory(int categoryId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.BehaviorCategory> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorCategoryClient( categoryId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of the behavior category specified in the request.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.BehaviorCategory"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behaviorCategory = await referencedata.GetBehaviorCategoryAsync( categoryId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Core.BehaviorCategory> GetBehaviorCategoryAsync(int categoryId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.BehaviorCategory> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorCategoryClient( categoryId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the list of behavior categories.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.BehaviorCategoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behaviorCategoryCollection = referencedata.GetBehaviorCategories( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Core.BehaviorCategoryCollection GetBehaviorCategories(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.BehaviorCategoryCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorCategoriesClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the list of behavior categories.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.BehaviorCategoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behaviorCategoryCollection = await referencedata.GetBehaviorCategoriesAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Core.BehaviorCategoryCollection> GetBehaviorCategoriesAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.BehaviorCategoryCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorCategoriesClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a list of application behaviors.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userType">The user type associated with the behaviors to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.BehaviorCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behaviorCollection = referencedata.GetBehaviors( userType,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Core.BehaviorCollection GetBehaviors(string userType =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.BehaviorCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorsClient( userType,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of application behaviors.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userType">The user type associated with the behaviors to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.BehaviorCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behaviorCollection = await referencedata.GetBehaviorsAsync( userType,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Core.BehaviorCollection> GetBehaviorsAsync(string userType =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.BehaviorCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorsClient( userType,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the list of content locales the system supports. Content locales indicate the language used and the country where the language is used.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.ContentLocaleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var contentLocaleCollection = referencedata.GetContentLocales( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Reference.ContentLocaleCollection GetContentLocales(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.ContentLocaleCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetContentLocalesClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the list of content locales the system supports. Content locales indicate the language used and the country where the language is used.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.ContentLocaleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var contentLocaleCollection = await referencedata.GetContentLocalesAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Reference.ContentLocaleCollection> GetContentLocalesAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.ContentLocaleCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetContentLocalesClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the entire list of countries that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.CountryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var countryCollection = referencedata.GetCountries( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Reference.CountryCollection GetCountries(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.CountryCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetCountriesClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the entire list of countries that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.CountryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var countryCollection = await referencedata.GetCountriesAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Reference.CountryCollection> GetCountriesAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.CountryCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetCountriesClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the entire list of countries that the system supports.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.CountryWithStatesCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var countryWithStatesCollection = referencedata.GetCountriesWithStates( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Reference.CountryWithStatesCollection GetCountriesWithStates(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.CountryWithStatesCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetCountriesWithStatesClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the entire list of countries that the system supports.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.CountryWithStatesCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var countryWithStatesCollection = await referencedata.GetCountriesWithStatesAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Reference.CountryWithStatesCollection> GetCountriesWithStatesAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.CountryWithStatesCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetCountriesWithStatesClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the entire list of currencies that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.CurrencyCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var currencyCollection = referencedata.GetCurrencies( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Reference.CurrencyCollection GetCurrencies(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.CurrencyCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetCurrenciesClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the entire list of currencies that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.CurrencyCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var currencyCollection = await referencedata.GetCurrenciesAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Reference.CurrencyCollection> GetCurrenciesAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.CurrencyCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetCurrenciesClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the entire list of time zones that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.TimeZoneCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var timeZoneCollection = referencedata.GetTimeZones( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Reference.TimeZoneCollection GetTimeZones(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.TimeZoneCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetTimeZonesClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the entire list of time zones that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.TimeZoneCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var timeZoneCollection = await referencedata.GetTimeZonesAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Reference.TimeZoneCollection> GetTimeZonesAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.TimeZoneCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetTimeZonesClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the entire list of top-level internet domains that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.TopLevelDomainCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var topLevelDomainCollection = referencedata.GetTopLevelDomains( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Reference.TopLevelDomainCollection GetTopLevelDomains(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.TopLevelDomainCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetTopLevelDomainsClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the entire list of top-level internet domains that the system supports.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.TopLevelDomainCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var topLevelDomainCollection = await referencedata.GetTopLevelDomainsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Reference.TopLevelDomainCollection> GetTopLevelDomainsAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.TopLevelDomainCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetTopLevelDomainsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves an array list of all units of measure the system supports.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.UnitOfMeasureCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var unitOfMeasureCollection = referencedata.GetUnitsOfMeasure( filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Reference.UnitOfMeasureCollection GetUnitsOfMeasure(string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.UnitOfMeasureCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetUnitsOfMeasureClient( filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves an array list of all units of measure the system supports.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.UnitOfMeasureCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var unitOfMeasureCollection = await referencedata.GetUnitsOfMeasureAsync( filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Reference.UnitOfMeasureCollection> GetUnitsOfMeasureAsync(string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.UnitOfMeasureCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetUnitsOfMeasureClient( filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


