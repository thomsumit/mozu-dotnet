
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

using Mozu.Api.Contracts.Core.ThirdParty;

namespace Mozu.Api.Contracts.SiteSettings.Application
{
		///
		///	Properties of a capability application installed in a tenant.
		///
		public class Capability
		{
			///
			///Array list of credit types active for the capability.
			///
			public List<string> ActiveCreditTypes { get; set; }

			///
			///Array list of the countries (by country code) to which this capability can actively ship. The entered shipping country is validated against a list of supported shipping countries. Messages return if the country code is not supported or duplicated. Supported carriers are also checked per country code.
			///
			public List<ActiveShippingCountry> ActiveShippingCountries { get; set; }

			///
			///Array list of the countries (by country code) for which this capability can actively shop. All active shopping countries must be in the supported shopping country list. Validation rules determine the supported validity of the entered country against the list.
			///
			public List<string> ActiveShoppingCountries { get; set; }

			///
			///The enablement mode of the capability, typically read only.
			///
			public string CapabilityMode { get; set; }

			///
			///The capability type installed in the tenant.
			///
			public string CapabilityType { get; set; }

			///
			///Indicates if the capability or app is enabled for the tenant/site. If true, the capability/application is enabled for the tenant. System-supplied and read-only.
			///
			public bool? Enabled { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///Indicates if an app is initialized and capable of being enabled in the tenant and site. Apps will need to be installed and configured to become initialized, such as validating credentials and/or API keys with a third-party service. If true, the app is initialized and can be enabled for usage.
			///
			public bool? Initialized { get; set; }

			///
			///Array list of URL endpoints for the operations associated with this capability.
			///
			public List<OperationUrl> OperationUrls { get; set; }

			///
			///The ID of the specific scope for the object. 
			///
			public int? ScopeId { get; set; }

			///
			///The scope at which the object exists, such as "Tenant", "MasterCatalog", or "Site". Scope delineates the level and area of Mozu the object exists within or affects.
			///
			public string ScopeType { get; set; }

			///
			///List of credit types this capability supports.
			///
			public List<InitializablePropertyValue> SupportedCreditTypes { get; set; }

			///
			///Array list of countries this capability supports for shipping.
			///
			public List<InitializableShippingCountryPropertyValue> SupportedShippingCountries { get; set; }

			///
			///List of countries this capability supports for shopping.
			///
			public List<InitializablePropertyValue> SupportedShoppingCountries { get; set; }

		}

}