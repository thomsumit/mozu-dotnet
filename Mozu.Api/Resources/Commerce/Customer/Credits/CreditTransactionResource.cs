
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

namespace Mozu.Api.Resources.Commerce.Customer.Credits
{
	/// <summary>
	/// Use the Customer Credit Transactions subresource to manage the individual transactions performed using a store credit or gift card.
	/// </summary>
	public partial class CreditTransactionResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CreditTransactionResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CreditTransactionResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CreditTransactionResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of the transactions performed using a customer credit that update the balance of the credit.
		/// </summary>
		/// <param name="code">User-defined code that identifies the customer credit.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.CreditTransactionCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credittransaction = new CreditTransaction();
		///   var creditTransactionCollection = credittransaction.GetTransactions( code,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.Credit.CreditTransactionCollection GetTransactions(string code, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditTransactionCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Credits.CreditTransactionClient.GetTransactionsClient( code,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of the transactions performed using a customer credit that update the balance of the credit.
		/// </summary>
		/// <param name="code">User-defined code that identifies the customer credit.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.CreditTransactionCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credittransaction = new CreditTransaction();
		///   var creditTransactionCollection = await credittransaction.GetTransactionsAsync( code,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.Credit.CreditTransactionCollection> GetTransactionsAsync(string code, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditTransactionCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Credits.CreditTransactionClient.GetTransactionsClient( code,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new transaction and updates the amount of a store credit or gift card.
		/// </summary>
		/// <param name="code">User-defined code that identifies the customer credit to update.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="creditTransaction">Properties of the transaction to create for the customer credit.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.CreditTransaction"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credittransaction = new CreditTransaction();
		///   var creditTransaction = credittransaction.AddTransaction( creditTransaction,  code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.Credit.CreditTransaction AddTransaction(Mozu.Api.Contracts.Customer.Credit.CreditTransaction creditTransaction, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditTransaction> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Credits.CreditTransactionClient.AddTransactionClient( creditTransaction,  code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new transaction and updates the amount of a store credit or gift card.
		/// </summary>
		/// <param name="code">User-defined code that identifies the customer credit to update.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="creditTransaction">Properties of the transaction to create for the customer credit.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.CreditTransaction"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credittransaction = new CreditTransaction();
		///   var creditTransaction = await credittransaction.AddTransactionAsync( creditTransaction,  code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.Credit.CreditTransaction> AddTransactionAsync(Mozu.Api.Contracts.Customer.Credit.CreditTransaction creditTransaction, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditTransaction> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Credits.CreditTransactionClient.AddTransactionClient( creditTransaction,  code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


