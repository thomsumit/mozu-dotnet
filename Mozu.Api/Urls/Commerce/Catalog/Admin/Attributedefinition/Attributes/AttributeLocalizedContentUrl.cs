
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

namespace Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes
{
	public partial class AttributeLocalizedContentUrl 
	{

		/// <summary>
        /// Get Resource Url for GetAttributeLocalizedContents
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAttributeLocalizedContentsUrl(string attributeFQN)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/LocalizedContent";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAttributeLocalizedContent
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <param name="localeCode">Language used for the entity. Currently, only "en-US" is supported.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAttributeLocalizedContentUrl(string attributeFQN, string localeCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/LocalizedContent/{localeCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "localeCode", localeCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddLocalizedContent
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddLocalizedContentUrl(string attributeFQN, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/LocalizedContent?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateLocalizedContents
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateLocalizedContentsUrl(string attributeFQN)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/LocalizedContent";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateLocalizedContent
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <param name="localeCode">Language used for the entity. Currently, only "en-US" is supported.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateLocalizedContentUrl(string attributeFQN, string localeCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/LocalizedContent/{localeCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "localeCode", localeCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteLocalizedContent
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <param name="localeCode">Language used for the entity. Currently, only "en-US" is supported.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteLocalizedContentUrl(string attributeFQN, string localeCode)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/LocalizedContent/{localeCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "localeCode", localeCode);
			return mozuUrl;
		}

		
	}
}

