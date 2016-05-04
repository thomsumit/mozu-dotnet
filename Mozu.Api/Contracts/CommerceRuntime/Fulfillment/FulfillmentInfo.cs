
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Fulfillment
{
		///
		///	Properties of the information needed to fulfill an order, whether via in-store pickup or direct shipping.
		///
		public class FulfillmentInfo
		{
			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			public JObject Data { get; set; }

			///
			///The contact information of the person receiving the shipment or performing the pickup.
			///
			public Contact FulfillmentContact { get; set; }

			///
			///If true, the shipping destination for a shipment is a commercial address.
			///
			public bool? IsDestinationCommercial { get; set; }

			///
			///The code associated with the carrier's shipping method service type. Service type codes include a prefix that indicates the carrier. For example: FEDEX_INTERNATIONAL_STANDARD
			///
			public string ShippingMethodCode { get; set; }

			///
			///The carrier-supplied name for the shipping service type, such as "UPS Ground" or "2nd Day Air".
			///
			public string ShippingMethodName { get; set; }

		}

}