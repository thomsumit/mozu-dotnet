
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.SiteSettings.General
{
		///
		///	Mozu.SiteSettings.General.Contracts.EmailTypeSetting ApiType DOCUMENT_HERE 
		///
		public class EmailTypeSetting
		{
			///
			///Email Address used to bcc in emails
			///
			public string BccEmailAddressOverride { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///Email address to display on email messages sent from your site.
			///
			public string ReplyToEmailAddressOverride { get; set; }

			///
			///Email address used in emails sent to your shoppers
			///
			public string SenderEmailAddressOverride { get; set; }

			///
			///Email Alais used in emails sent to your shoppers
			///
			public string SenderEmailAliasOverride { get; set; }

		}

}