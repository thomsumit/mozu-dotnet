
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.SiteSettings.Order
{
		///
		///	The properties of the customer checkout settings such as whether shoppers must be logged in.
		///
		public class CustomerCheckoutSettings
		{
			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The type of customer checking out in the order such as a guest who has not logged in or a customer who has logged in. Valid strings are either "LoginOptional," where shoppers are prompted to sign in but are not required to do so, or "LoginRequired," where shopppers must login before purchasing.
			///
			public string CustomerCheckoutType { get; set; }

		}

}