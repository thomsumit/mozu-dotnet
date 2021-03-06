
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Catalog.Admin.Discounts
{
	public partial class DiscountTargetUrl 
	{

		/// <summary>
        /// Get Resource Url for GetDiscountTarget
        /// </summary>
        /// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDiscountTargetUrl(int discountId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/discounts/{discountId}/target?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "discountId", discountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for UpdateDiscountTarget
        /// </summary>
        /// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDiscountTargetUrl(int discountId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/discounts/{discountId}/target?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "discountId", discountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				
	}
}

