
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

namespace Mozu.Api.Urls.Content.Documentlists
{
	public partial class DocumentTreeUrl 
	{

		/// <summary>
        /// Get Resource Url for GetTreeDocumentContent
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the document.</param>
        /// <param name="documentName">The name of the document, which is unique within its folder.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetTreeDocumentContentUrl(string documentListName, string documentName)
		{
			var url = "/api/content/documentlists/{documentListName}/documentTree/{documentName}/content";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "documentName", documentName);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for TransformTreeDocumentContent
        /// </summary>
        /// <param name="crop"></param>
        /// <param name="documentListName"></param>
        /// <param name="documentName"></param>
        /// <param name="height"></param>
        /// <param name="max"></param>
        /// <param name="maxHeight"></param>
        /// <param name="maxWidth"></param>
        /// <param name="quality"></param>
        /// <param name="width"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl TransformTreeDocumentContentUrl(string documentListName, string documentName, int? width =  null, int? height =  null, int? max =  null, int? maxWidth =  null, int? maxHeight =  null, string crop =  null, int? quality =  null)
		{
			var url = "/api/content/documentlists/{documentListName}/documentTree/{documentName}/transform?width={width}&height={height}&maxWidth={maxWidth}&maxHeight={maxHeight}&crop={crop}&quality={quality}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "crop", crop);
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "documentName", documentName);
			mozuUrl.FormatUrl( "height", height);
			mozuUrl.FormatUrl( "max", max);
			mozuUrl.FormatUrl( "maxHeight", maxHeight);
			mozuUrl.FormatUrl( "maxWidth", maxWidth);
			mozuUrl.FormatUrl( "quality", quality);
			mozuUrl.FormatUrl( "width", width);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetTreeDocument
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the document.</param>
        /// <param name="documentName">The name of the document, which is unique within its folder.</param>
        /// <param name="includeInactive"></param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetTreeDocumentUrl(string documentListName, string documentName, bool? includeInactive =  null, string responseFields =  null)
		{
			var url = "/api/content/documentlists/{documentListName}/documentTree/{documentName}?includeInactive={includeInactive}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "documentName", documentName);
			mozuUrl.FormatUrl( "includeInactive", includeInactive);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for UpdateTreeDocumentContent
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the document.</param>
        /// <param name="documentName">The name of the document, which is unique within its folder.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateTreeDocumentContentUrl(string documentListName, string documentName)
		{
			var url = "/api/content/documentlists/{documentListName}/documentTree/{documentName}/content?folderPath={folderPath}&folderId={folderId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "documentName", documentName);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteTreeDocumentContent
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the document.</param>
        /// <param name="documentName">The name of the document, which is unique within its folder.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteTreeDocumentContentUrl(string documentListName, string documentName)
		{
			var url = "/api/content/documentlists/{documentListName}/documentTree/{documentName}/content?folderPath={folderPath}&folderId={folderId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "documentName", documentName);
			return mozuUrl;
		}

		
	}
}

