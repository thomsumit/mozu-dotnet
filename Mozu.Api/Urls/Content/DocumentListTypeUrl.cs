
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

namespace Mozu.Api.Urls.Content
{
	public partial class DocumentListTypeUrl 
	{

		/// <summary>
        /// Get Resource Url for GetDocumentListTypes
        /// </summary>
        /// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDocumentListTypesUrl(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			var url = "/api/content/documentlistTypes/{documentListTypeFQN}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetDocumentListType
        /// </summary>
        /// <param name="documentListTypeFQN"></param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDocumentListTypeUrl(string documentListTypeFQN, string responseFields =  null)
		{
			var url = "/api/content/documentlistTypes/{documentListTypeFQN}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListTypeFQN", documentListTypeFQN);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateDocumentListType
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateDocumentListTypeUrl(string responseFields =  null)
		{
			var url = "/api/content/documentlistTypes/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateDocumentListType
        /// </summary>
        /// <param name="documentListTypeFQN"></param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDocumentListTypeUrl(string documentListTypeFQN, string responseFields =  null)
		{
			var url = "/api/content/documentlistTypes/{documentListTypeFQN}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListTypeFQN", documentListTypeFQN);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				
	}
}

