
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

namespace Mozu.Api.Urls.Commerce.Customer
{
	public partial class CustomerAuthTicketUrl 
	{

		/// <summary>
        /// Get Resource Url for CreateAnonymousShopperAuthTicket
        /// </summary>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateAnonymousShopperAuthTicketUrl(string responseFields =  null)
		{
			var url = "/api/commerce/customer/authtickets/anonymousshopper?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateUserAuthTicket
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateUserAuthTicketUrl(string responseFields =  null)
		{
			var url = "/api/commerce/customer/authtickets/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for RefreshUserAuthTicket
        /// </summary>
        /// <param name="refreshToken">Alphanumeric string used for access tokens. This token refreshes access for accounts by generating a new developer or application account authentication ticket after an access token expires.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RefreshUserAuthTicketUrl(string refreshToken, string responseFields =  null)
		{
			var url = "/api/commerce/customer/authtickets/refresh?refreshToken={refreshToken}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "refreshToken", refreshToken);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				
	}
}

