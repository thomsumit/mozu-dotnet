
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

namespace Mozu.Api.Resources.Commerce.Settings.Checkout
{
	/// <summary>
	/// Use the Payment Settings resource to specify settings when creating payments for order checkout on the site.
	/// </summary>
	public partial class PaymentSettingsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PaymentSettingsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PaymentSettingsResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PaymentSettingsResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the schema and definition along with the actual instance values of the third-party payment service workflow configured for the corresponding fully qualified name.
		/// </summary>
		/// <param name="fullyQualifiedName">Fully qualified name of the attribute for the third-party payment workflow.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var externalPaymentWorkflowDefinition = paymentsettings.GetThirdPartyPaymentWorkflowWithValues( fullyQualifiedName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition GetThirdPartyPaymentWorkflowWithValues(string fullyQualifiedName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetThirdPartyPaymentWorkflowWithValuesClient( fullyQualifiedName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the schema and definition along with the actual instance values of the third-party payment service workflow configured for the corresponding fully qualified name.
		/// </summary>
		/// <param name="fullyQualifiedName">Fully qualified name of the attribute for the third-party payment workflow.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var externalPaymentWorkflowDefinition = await paymentsettings.GetThirdPartyPaymentWorkflowWithValuesAsync( fullyQualifiedName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition> GetThirdPartyPaymentWorkflowWithValuesAsync(string fullyQualifiedName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetThirdPartyPaymentWorkflowWithValuesClient( fullyQualifiedName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the schema and definition of all third-party payment service workflows configured for the site.
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var externalPaymentWorkflowDefinition = paymentsettings.GetThirdPartyPaymentWorkflows();
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition> GetThirdPartyPaymentWorkflows()
		{
			MozuClient<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetThirdPartyPaymentWorkflowsClient();
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the schema and definition of all third-party payment service workflows configured for the site.
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var externalPaymentWorkflowDefinition = await paymentsettings.GetThirdPartyPaymentWorkflowsAsync();
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>> GetThirdPartyPaymentWorkflowsAsync()
		{
			MozuClient<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetThirdPartyPaymentWorkflowsClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Adds a third-party payment workflow to the site. A third-party payment workflow is a definition of a process by which a third-party payment provider (such as Amazon Payments or PayPal Express) interacts with the Mozu platform.
		/// </summary>
		/// <param name="definition">Properties of an external payment processing workflow defined for the site. At this time, only PayPal Express is supported.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   paymentsettings.AddThirdPartyPaymentWorkflow( definition);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void AddThirdPartyPaymentWorkflow(Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition definition)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.AddThirdPartyPaymentWorkflowClient( definition);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Adds a third-party payment workflow to the site. A third-party payment workflow is a definition of a process by which a third-party payment provider (such as Amazon Payments or PayPal Express) interacts with the Mozu platform.
		/// </summary>
		/// <param name="definition">Properties of an external payment processing workflow defined for the site. At this time, only PayPal Express is supported.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   await paymentsettings.AddThirdPartyPaymentWorkflowAsync( definition);
		/// </code>
		/// </example>
		public virtual async Task AddThirdPartyPaymentWorkflowAsync(Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition definition)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.AddThirdPartyPaymentWorkflowClient( definition);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Deletes a third-party payment workflow. A third-party payment workflow is a definition of a process by which a third-party payment provider (such as Amazon Payments or PayPal Express) interacts with the Mozu platform. 
		/// </summary>
		/// <param name="fullyQualifiedName">Fully qualified name of the attribute for the third-party payment workflow.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   paymentsettings.DeleteThirdPartyPaymentWorkflow( fullyQualifiedName);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteThirdPartyPaymentWorkflow(string fullyQualifiedName)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.DeleteThirdPartyPaymentWorkflowClient( fullyQualifiedName);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes a third-party payment workflow. A third-party payment workflow is a definition of a process by which a third-party payment provider (such as Amazon Payments or PayPal Express) interacts with the Mozu platform. 
		/// </summary>
		/// <param name="fullyQualifiedName">Fully qualified name of the attribute for the third-party payment workflow.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   await paymentsettings.DeleteThirdPartyPaymentWorkflowAsync( fullyQualifiedName);
		/// </code>
		/// </example>
		public virtual async Task DeleteThirdPartyPaymentWorkflowAsync(string fullyQualifiedName)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.DeleteThirdPartyPaymentWorkflowClient( fullyQualifiedName);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


