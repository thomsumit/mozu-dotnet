
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

namespace Mozu.Api.Resources.Commerce.Settings.General
{
	/// <summary>
	/// Use the taxable territories subresource to manage the regional territories for this site that are subejct to sales tax.
	/// </summary>
	public partial class TaxableTerritoryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public TaxableTerritoryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public TaxableTerritoryResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new TaxableTerritoryResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of the taxable territories configured for the site.
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = taxableterritory.GetTaxableTerritories();
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> GetTaxableTerritories()
		{
			MozuClient<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.GetTaxableTerritoriesClient();
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of the taxable territories configured for the site.
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = await taxableterritory.GetTaxableTerritoriesAsync();
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> GetTaxableTerritoriesAsync()
		{
			MozuClient<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.GetTaxableTerritoriesClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new territory for which to calculate sales tax.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="taxableTerritory">Properties of the territory which is subject to sales tax.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = taxableterritory.AddTaxableTerritory( taxableTerritory,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory AddTaxableTerritory(Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory taxableTerritory, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.AddTaxableTerritoryClient( taxableTerritory,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new territory for which to calculate sales tax.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="taxableTerritory">Properties of the territory which is subject to sales tax.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = await taxableterritory.AddTaxableTerritoryAsync( taxableTerritory,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> AddTaxableTerritoryAsync(Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory taxableTerritory, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.AddTaxableTerritoryClient( taxableTerritory,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates one or more taxable territories configured for a site.
		/// </summary>
		/// <param name="taxableterritories">Properties of the territory which is subject to sales tax.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = taxableterritory.UpdateTaxableTerritories( taxableterritories);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> UpdateTaxableTerritories(List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> taxableterritories)
		{
			MozuClient<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.UpdateTaxableTerritoriesClient( taxableterritories);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates one or more taxable territories configured for a site.
		/// </summary>
		/// <param name="taxableterritories">Properties of the territory which is subject to sales tax.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = await taxableterritory.UpdateTaxableTerritoriesAsync( taxableterritories);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> UpdateTaxableTerritoriesAsync(List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> taxableterritories)
		{
			MozuClient<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.UpdateTaxableTerritoriesClient( taxableterritories);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


