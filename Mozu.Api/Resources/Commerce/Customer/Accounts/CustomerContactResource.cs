
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

namespace Mozu.Api.Resources.Commerce.Customer.Accounts
{
	/// <summary>
	/// Merchants and customers can create, view, update, and delete a contact for a customer account. A customer account may have multiple contacts for billing and shipping addresses.
	/// </summary>
	public partial class CustomerContactResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CustomerContactResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CustomerContactResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CustomerContactResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the specified contact for a customer account such as a billing or shipping contact.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account whose contact information is being retrieved.</param>
		/// <param name="contactId">Unique identifier of the customer account contact to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContact = customercontact.GetAccountContact( accountId,  contactId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerContact GetAccountContact(int accountId, int contactId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.GetAccountContactClient( accountId,  contactId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the specified contact for a customer account such as a billing or shipping contact.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account whose contact information is being retrieved.</param>
		/// <param name="contactId">Unique identifier of the customer account contact to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContact = await customercontact.GetAccountContactAsync( accountId,  contactId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerContact> GetAccountContactAsync(int accountId, int contactId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.GetAccountContactClient( accountId,  contactId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a list of contacts for a customer according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account associated with the contact information to retrieve.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContactCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContactCollection = customercontact.GetAccountContacts( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerContactCollection GetAccountContacts(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContactCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.GetAccountContactsClient( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of contacts for a customer according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account associated with the contact information to retrieve.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContactCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContactCollection = await customercontact.GetAccountContactsAsync( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerContactCollection> GetAccountContactsAsync(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContactCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.GetAccountContactsClient( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new contact for a customer account such as a new shipping address.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account containing the new contact.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="contact">Properties of the new contact. Required properties: Contact.Email, ContactType.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContact = customercontact.AddAccountContact( contact,  accountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerContact AddAccountContact(Mozu.Api.Contracts.Customer.CustomerContact contact, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.AddAccountContactClient( contact,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new contact for a customer account such as a new shipping address.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account containing the new contact.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="contact">Properties of the new contact. Required properties: Contact.Email, ContactType.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContact = await customercontact.AddAccountContactAsync( contact,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerContact> AddAccountContactAsync(Mozu.Api.Contracts.Customer.CustomerContact contact, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.AddAccountContactClient( contact,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates a contact for a specified customer account such as to update addresses or change which contact is the primary contact for billing.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account whose contact information is being updated.</param>
		/// <param name="contactId">Unique identifer of the customer account contact being updated.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="contact">All properties the updated contact will have. Required properties: Name and email address.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContact = customercontact.UpdateAccountContact( contact,  accountId,  contactId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerContact UpdateAccountContact(Mozu.Api.Contracts.Customer.CustomerContact contact, int accountId, int contactId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.UpdateAccountContactClient( contact,  accountId,  contactId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates a contact for a specified customer account such as to update addresses or change which contact is the primary contact for billing.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account whose contact information is being updated.</param>
		/// <param name="contactId">Unique identifer of the customer account contact being updated.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="contact">All properties the updated contact will have. Required properties: Name and email address.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContact = await customercontact.UpdateAccountContactAsync( contact,  accountId,  contactId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerContact> UpdateAccountContactAsync(Mozu.Api.Contracts.Customer.CustomerContact contact, int accountId, int contactId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.UpdateAccountContactClient( contact,  accountId,  contactId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes a contact for the specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="contactId">Unique identifier of the customer account contact to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   customercontact.DeleteAccountContact( accountId,  contactId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteAccountContact(int accountId, int contactId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.DeleteAccountContactClient( accountId,  contactId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes a contact for the specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="contactId">Unique identifier of the customer account contact to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   await customercontact.DeleteAccountContactAsync( accountId,  contactId);
		/// </code>
		/// </example>
		public virtual async Task DeleteAccountContactAsync(int accountId, int contactId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.DeleteAccountContactClient( accountId,  contactId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


