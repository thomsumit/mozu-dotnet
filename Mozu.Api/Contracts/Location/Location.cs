
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

namespace Mozu.Api.Contracts.Location
{
		///
		///	Properties of a physical location a tenant uses to manage inventory and fulfills orders, provide store finder functionality, or both.
		///
		public class Location
		{
			///
			///The physical address properties of the location.
			///
			public Address Address { get; set; }

			public bool AllowFulfillmentWithNoStock { get; set; }

			public AuditInfo AuditInfo { get; set; }

			///
			///User-defined code to assign to this location.
			///
			public string Code { get; set; }

			///
			///User-defined description of this location.
			///
			public string Description { get; set; }

			///
			///The fax number associated with this location.
			///
			public string Fax { get; set; }

			///
			///List of order fulfillment types associated with this location. The location can have fulfillment types of direct ship (DS), in-store pickup (SP), or both.
			///
			public List<FulfillmentType> FulfillmentTypes { get; set; }

			///
			///The geographical coordinates associated with this location.
			///
			public Coordinates Geo { get; set; }

			public bool IsDisabled { get; set; }

			///
			///List of location types associated with this location. You can associate individual locations with any number of location types.
			///
			public List<LocationType> LocationTypes { get; set; }

			///
			///The user-defined name of the location.
			///
			public string Name { get; set; }

			///
			///Any tenant-defined notes associated with this location.
			///
			public string Note { get; set; }

			///
			///The phone number associated with this location.
			///
			public string Phone { get; set; }

			///
			///List of standard operating hours for each day of the week this location is open for shopper business.
			///
			public RegularHours RegularHours { get; set; }

			///
			///Properties of a fulfillment contact for the shipping origin address associated with a location.
			///
			public ShippingOriginContact ShippingOriginContact { get; set; }

			///
			///If true, this location maintains its own product inventory. If the location uses the direct ship fulfillment type, it must also support inventory.
			///
			public bool SupportsInventory { get; set; }

			///
			///List of tenant-defined tags associated with this location.
			///
			public List<string> Tags { get; set; }

		}

}