
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

using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.ShippingAdmin;

namespace Mozu.Api.Contracts.ShippingAdmin.Profile
{
		///
		///	Mozu.ShippingAdmin.Contracts.Profile.ShippingInclusionRule ApiType DOCUMENT_HERE 
		///
		public class ShippingInclusionRule
		{
			///
			///Basic audit info about the object, including date, time, and user account. Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///the product target rule codes associated with this rule leave empty or null to denote all products
			///
			public List<string> ProductTargetRuleCodes { get; set; }

			///
			///The numeric order of objects, used by a vocabulary value defined for an extensible attribute, images, and categories.
			///
			public int Sequence { get; set; }

			///
			///the servicetypes associated with this rule leave empty or null to denote all carriers and subsequent service types
			///
			public List<ServiceType> ServiceTypes { get; set; }

			///
			///The shipping target rule codes associated with this rule leave empty or null to denote all destinations
			///
			public List<string> ShippingTargetRuleCodes { get; set; }

		}

}