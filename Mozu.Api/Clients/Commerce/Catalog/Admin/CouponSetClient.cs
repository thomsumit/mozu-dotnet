
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Coupon Sets resource to view and create coupon sets. You can use coupon sets to group multiple coupon codes together and associate them with one or more discounts.
	/// </summary>
	public partial class CouponSetClient 	{
		
		/// <summary>
		/// Retrieves a list of coupon sets according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/applications/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="includeCounts">Specifies whether to include the number of redeemed coupons, existing coupon codes, and assigned discounts in the response body.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/applications/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.CouponSetCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCouponSets( startIndex,  pageSize,  sortBy,  filter,  includeCounts,  responseFields);
		///   var couponSetCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponSetCollection> GetCouponSetsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, bool? includeCounts =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CouponSetUrl.GetCouponSetsUrl(startIndex, pageSize, sortBy, filter, includeCounts, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponSetCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Returns a single
		/// </summary>
		/// <param name="couponSetCode">The unique identifier of the coupon set.</param>
		/// <param name="includeCounts">Specifies whether to include the number of redeemed coupons, existing coupon codes, and assigned discounts in the response body.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.CouponSet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCouponSet( couponSetCode,  includeCounts,  responseFields);
		///   var couponSetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponSet> GetCouponSetClient(string couponSetCode, bool? includeCounts =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CouponSetUrl.GetCouponSetUrl(couponSetCode, includeCounts, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponSet>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Returns a random, unique four character coupon set code.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetUniqueCouponSetCode( responseFields);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<string> GetUniqueCouponSetCodeClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CouponSetUrl.GetUniqueCouponSetCodeUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<string>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Adds a new coupon set.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="couponSet">Mozu.ProductAdmin.Contracts.CouponSet ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.CouponSet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddCouponSet( couponSet,  responseFields);
		///   var couponSetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponSet> AddCouponSetClient(Mozu.Api.Contracts.ProductAdmin.CouponSet couponSet, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CouponSetUrl.AddCouponSetUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponSet>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.CouponSet>(couponSet);
			return mozuClient;

		}

		/// <summary>
		/// Validates the coupon set code and tests it for uniqueness.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ValidateUniqueCouponSetCode( code);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient ValidateUniqueCouponSetCodeClient(string code)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CouponSetUrl.ValidateUniqueCouponSetCodeUrl(code);
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Update a representation. You can not update the Code or ID once the set is created.
		/// </summary>
		/// <param name="couponSetCode">The unique identifier of the coupon set.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="couponSet">Mozu.ProductAdmin.Contracts.CouponSet ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.CouponSet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCouponSet( couponSet,  couponSetCode,  responseFields);
		///   var couponSetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponSet> UpdateCouponSetClient(Mozu.Api.Contracts.ProductAdmin.CouponSet couponSet, string couponSetCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CouponSetUrl.UpdateCouponSetUrl(couponSetCode, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.CouponSet>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.CouponSet>(couponSet);
			return mozuClient;

		}

		/// <summary>
		/// admin-couponsets Delete DeleteCouponSet description DOCUMENT_HERE 
		/// </summary>
		/// <param name="couponSetCode">The unique identifier of the coupon set.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteCouponSet( couponSetCode);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteCouponSetClient(string couponSetCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.CouponSetUrl.DeleteCouponSetUrl(couponSetCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


