
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

namespace Mozu.Api.Clients.Content
{
	/// <summary>
	/// Use the Document List Types resource to manage the types of document lists in your site's document hierarchy. The type denotes a content type for that list of folders, sub-folders, and documents such as `web_pages`.
	/// </summary>
	public partial class DocumentListTypeClient 	{
		
		/// <summary>
		/// content-documentlistTypes Get GetDocumentListTypes description DOCUMENT_HERE 
		/// </summary>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=50`.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentListTypeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocumentListTypes(dataViewMode,  pageSize,  startIndex,  responseFields);
		///   var documentListTypeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentListTypeCollection> GetDocumentListTypesClient(DataViewMode dataViewMode, int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentListTypeUrl.GetDocumentListTypesUrl(pageSize, startIndex, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentListTypeCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// content-documentlistTypes Get GetDocumentListType description DOCUMENT_HERE 
		/// </summary>
		/// <param name="documentListTypeFQN"></param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentListType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocumentListType(dataViewMode,  documentListTypeFQN,  responseFields);
		///   var documentListTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentListType> GetDocumentListTypeClient(DataViewMode dataViewMode, string documentListTypeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentListTypeUrl.GetDocumentListTypeUrl(documentListTypeFQN, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentListType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new documentListType
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="list">Properties for the document list type. Document lists contain documents with an associated document type, such as web pages.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentListType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDocumentListType(dataViewMode,  list,  responseFields);
		///   var documentListTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentListType> CreateDocumentListTypeClient(DataViewMode dataViewMode, Mozu.Api.Contracts.Content.DocumentListType list, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentListTypeUrl.CreateDocumentListTypeUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentListType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Content.DocumentListType>(list)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Updates a DocumentListType
		/// </summary>
		/// <param name="documentListTypeFQN"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="list">Properties for the document list type. Document lists contain documents with an associated document type, such as web pages.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentListType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDocumentListType( list,  documentListTypeFQN,  responseFields);
		///   var documentListTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentListType> UpdateDocumentListTypeClient(Mozu.Api.Contracts.Content.DocumentListType list, string documentListTypeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentListTypeUrl.UpdateDocumentListTypeUrl(documentListTypeFQN, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentListType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Content.DocumentListType>(list);
			return mozuClient;

		}


	}

}


