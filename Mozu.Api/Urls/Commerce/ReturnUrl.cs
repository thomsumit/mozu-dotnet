
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

namespace Mozu.Api.Urls.Commerce
{
	public partial class ReturnUrl 
	{

		/// <summary>
        /// Get Resource Url for GetReturns
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetReturnsUrl(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/commerce/returns/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAvailableReturnActions
        /// </summary>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAvailableReturnActionsUrl(string returnId)
		{
			var url = "/api/commerce/returns/{returnId}/actions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetReturnItem
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <param name="returnItemId">Unique identifier of the return item whose details you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetReturnItemUrl(string returnId, string returnItemId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}/items/{returnItemId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			mozuUrl.FormatUrl( "returnItemId", returnItemId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetReturnItems
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetReturnItemsUrl(string returnId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}/items?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAvailablePaymentActionsForReturn
        /// </summary>
        /// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAvailablePaymentActionsForReturnUrl(string returnId, string paymentId)
		{
			var url = "/api/commerce/returns/{returnId}/payments/{paymentId}/actions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "paymentId", paymentId);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPayment
        /// </summary>
        /// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPaymentUrl(string returnId, string paymentId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}/payments/{paymentId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "paymentId", paymentId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPayments
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPaymentsUrl(string returnId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}/payments?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetReturn
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetReturnUrl(string returnId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetReasons
        /// </summary>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetReasonsUrl(string responseFields =  null)
		{
			var url = "/api/commerce/returns/reasons?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateReturn
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateReturnUrl(string responseFields =  null)
		{
			var url = "/api/commerce/returns/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for CreateReturnItem
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateReturnItemUrl(string returnId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}/items?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for PerformPaymentActionForReturn
        /// </summary>
        /// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl PerformPaymentActionForReturnUrl(string returnId, string paymentId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}/payments/{paymentId}/actions?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "paymentId", paymentId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for CreatePaymentActionForReturn
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreatePaymentActionForReturnUrl(string returnId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}/payments/actions?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for PerformReturnActions
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl PerformReturnActionsUrl(string responseFields =  null)
		{
			var url = "/api/commerce/returns/actions?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateReturn
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateReturnUrl(string returnId, string responseFields =  null)
		{
			var url = "/api/commerce/returns/{returnId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ResendReturnEmail
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ResendReturnEmailUrl()
		{
			var url = "/api/commerce/returns/email/resend";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteOrderItem
        /// </summary>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <param name="returnItemId">Unique identifier of the return item whose details you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteOrderItemUrl(string returnId, string returnItemId)
		{
			var url = "/api/commerce/returns/{orderId}/items/{orderItemId}?updatemode={updateMode}&version={version}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			mozuUrl.FormatUrl( "returnItemId", returnItemId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DeleteReturn
        /// </summary>
        /// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteReturnUrl(string returnId)
		{
			var url = "/api/commerce/returns/{returnId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		
	}
}

