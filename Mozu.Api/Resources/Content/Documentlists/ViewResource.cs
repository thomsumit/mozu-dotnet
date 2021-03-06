
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

namespace Mozu.Api.Resources.Content.Documentlists
{
	/// <summary>
	/// Properties and content for views within a site/tenant. Views provide the schema, formatting, and associated content and entities for displaying content within a site/tenant.
	/// </summary>
	public partial class ViewResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ViewResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ViewResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ViewResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a collection of documents associated with a view.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="includeInactive">Include inactive content.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/applications/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <param name="viewName">The name for a view. Views are used to render data in Mozu, such as document and entity lists. Each view includes a schema, format, name, ID, and associated data types to render.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var view = new View();
		///   var documentCollection = view.GetViewDocuments( documentListName,  viewName,  filter,  sortBy,  pageSize,  startIndex,  includeInactive,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.DocumentCollection GetViewDocuments(string documentListName, string viewName, string filter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, bool? includeInactive =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentCollection> response;
			var client = Mozu.Api.Clients.Content.Documentlists.ViewClient.GetViewDocumentsClient( documentListName,  viewName,  filter,  sortBy,  pageSize,  startIndex,  includeInactive,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a collection of documents associated with a view.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="includeInactive">Include inactive content.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/applications/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <param name="viewName">The name for a view. Views are used to render data in Mozu, such as document and entity lists. Each view includes a schema, format, name, ID, and associated data types to render.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var view = new View();
		///   var documentCollection = await view.GetViewDocumentsAsync( documentListName,  viewName,  filter,  sortBy,  pageSize,  startIndex,  includeInactive,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Content.DocumentCollection> GetViewDocumentsAsync(string documentListName, string viewName, string filter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, bool? includeInactive =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentCollection> response;
			var client = Mozu.Api.Clients.Content.Documentlists.ViewClient.GetViewDocumentsClient( documentListName,  viewName,  filter,  sortBy,  pageSize,  startIndex,  includeInactive,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


