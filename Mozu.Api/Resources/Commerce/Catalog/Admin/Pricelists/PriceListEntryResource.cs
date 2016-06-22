
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Pricelists
{
	/// <summary>
	/// Use the Entries sub-resource to interact with price list entries. Price list entries enable you to override product pricing as well as control what products shoppers can view and purchase when the price list is exclusive. Refer to the [Price Lists](../../../guides/catalog/price-lists.htm) guides topic for more information.
	/// </summary>
	public partial class PriceListEntryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PriceListEntryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PriceListEntryResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PriceListEntryResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the details of a price list entry.
		/// </summary>
		/// <param name="currencyCode">The three character ISO currency code, such as USD for US Dollars.</param>
		/// <param name="priceListCode">The unique code of the price list associated with the price list entry.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout Mozu to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="startDate">The start date of the price list entry.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntry"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelistentry = new PriceListEntry();
		///   var priceListEntry = pricelistentry.GetPriceListEntry( priceListCode,  productCode,  currencyCode,  startDate,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.PriceListEntry GetPriceListEntry(string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Pricelists.PriceListEntryClient.GetPriceListEntryClient( priceListCode,  productCode,  currencyCode,  startDate,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a price list entry.
		/// </summary>
		/// <param name="currencyCode">The three character ISO currency code, such as USD for US Dollars.</param>
		/// <param name="priceListCode">The unique code of the price list associated with the price list entry.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout Mozu to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="startDate">The start date of the price list entry.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntry"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelistentry = new PriceListEntry();
		///   var priceListEntry = await pricelistentry.GetPriceListEntryAsync( priceListCode,  productCode,  currencyCode,  startDate,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> GetPriceListEntryAsync(string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Pricelists.PriceListEntryClient.GetPriceListEntryClient( priceListCode,  productCode,  currencyCode,  startDate,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a list of price list entries associated with the specified price list according to any specified facets, filter criteria, and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/applications/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="priceListCode">The unique code of the price list associated with the price list entry.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/applications/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelistentry = new PriceListEntry();
		///   var priceListEntryCollection = pricelistentry.GetPriceListEntries( priceListCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.PriceListEntryCollection GetPriceListEntries(string priceListCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Pricelists.PriceListEntryClient.GetPriceListEntriesClient( priceListCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of price list entries associated with the specified price list according to any specified facets, filter criteria, and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/applications/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="priceListCode">The unique code of the price list associated with the price list entry.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/applications/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelistentry = new PriceListEntry();
		///   var priceListEntryCollection = await pricelistentry.GetPriceListEntriesAsync( priceListCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceListEntryCollection> GetPriceListEntriesAsync(string priceListCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Pricelists.PriceListEntryClient.GetPriceListEntriesClient( priceListCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Adds a new price list entry to the specified price list.
		/// </summary>
		/// <param name="priceListCode">The specified price list to which you want to add the price list entry.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="priceListEntryIn">Mozu.ProductAdmin.Contracts.PriceListEntry ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntry"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelistentry = new PriceListEntry();
		///   var priceListEntry = pricelistentry.AddPriceListEntry( priceListEntryIn,  priceListCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.PriceListEntry AddPriceListEntry(Mozu.Api.Contracts.ProductAdmin.PriceListEntry priceListEntryIn, string priceListCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Pricelists.PriceListEntryClient.AddPriceListEntryClient( priceListEntryIn,  priceListCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Adds a new price list entry to the specified price list.
		/// </summary>
		/// <param name="priceListCode">The specified price list to which you want to add the price list entry.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="priceListEntryIn">Mozu.ProductAdmin.Contracts.PriceListEntry ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntry"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelistentry = new PriceListEntry();
		///   var priceListEntry = await pricelistentry.AddPriceListEntryAsync( priceListEntryIn,  priceListCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> AddPriceListEntryAsync(Mozu.Api.Contracts.ProductAdmin.PriceListEntry priceListEntryIn, string priceListCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Pricelists.PriceListEntryClient.AddPriceListEntryClient( priceListEntryIn,  priceListCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the details of a price list entry.
		/// </summary>
		/// <param name="currencyCode">The three character ISO currency code, such as USD for US Dollars.</param>
		/// <param name="priceListCode">The unique code of the price list associated with the price list entry.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout Mozu to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="startDate">The start date of the price list entry.</param>
		/// <param name="priceListEntryIn">Mozu.ProductAdmin.Contracts.PriceListEntry ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntry"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelistentry = new PriceListEntry();
		///   var priceListEntry = pricelistentry.UpdatePriceListEntry( priceListEntryIn,  priceListCode,  productCode,  currencyCode,  startDate,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.PriceListEntry UpdatePriceListEntry(Mozu.Api.Contracts.ProductAdmin.PriceListEntry priceListEntryIn, string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Pricelists.PriceListEntryClient.UpdatePriceListEntryClient( priceListEntryIn,  priceListCode,  productCode,  currencyCode,  startDate,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates the details of a price list entry.
		/// </summary>
		/// <param name="currencyCode">The three character ISO currency code, such as USD for US Dollars.</param>
		/// <param name="priceListCode">The unique code of the price list associated with the price list entry.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout Mozu to reference and associate to a product.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="startDate">The start date of the price list entry.</param>
		/// <param name="priceListEntryIn">Mozu.ProductAdmin.Contracts.PriceListEntry ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.PriceListEntry"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelistentry = new PriceListEntry();
		///   var priceListEntry = await pricelistentry.UpdatePriceListEntryAsync( priceListEntryIn,  priceListCode,  productCode,  currencyCode,  startDate,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> UpdatePriceListEntryAsync(Mozu.Api.Contracts.ProductAdmin.PriceListEntry priceListEntryIn, string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.PriceListEntry> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Pricelists.PriceListEntryClient.UpdatePriceListEntryClient( priceListEntryIn,  priceListCode,  productCode,  currencyCode,  startDate,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes a price list entry.
		/// </summary>
		/// <param name="currencyCode">The three character ISO currency code, such as USD for US Dollars.</param>
		/// <param name="priceListCode">The code of the specified price list associated with the price list entry.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout Mozu to reference and associate to a product.</param>
		/// <param name="startDate">The start date of the price list entry.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelistentry = new PriceListEntry();
		///   pricelistentry.DeletePriceListEntry( priceListCode,  productCode,  currencyCode,  startDate);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeletePriceListEntry(string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Pricelists.PriceListEntryClient.DeletePriceListEntryClient( priceListCode,  productCode,  currencyCode,  startDate);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes a price list entry.
		/// </summary>
		/// <param name="currencyCode">The three character ISO currency code, such as USD for US Dollars.</param>
		/// <param name="priceListCode">The code of the specified price list associated with the price list entry.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout Mozu to reference and associate to a product.</param>
		/// <param name="startDate">The start date of the price list entry.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelistentry = new PriceListEntry();
		///   await pricelistentry.DeletePriceListEntryAsync( priceListCode,  productCode,  currencyCode,  startDate);
		/// </code>
		/// </example>
		public virtual async Task DeletePriceListEntryAsync(string priceListCode, string productCode, string currencyCode, DateTime? startDate =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Pricelists.PriceListEntryClient.DeletePriceListEntryClient( priceListCode,  productCode,  currencyCode,  startDate);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


