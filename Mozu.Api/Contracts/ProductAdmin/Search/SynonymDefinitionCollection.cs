
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


namespace Mozu.Api.Contracts.ProductAdmin.Search
{
		public class SynonymDefinitionCollection
		{
			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public string LocaleCode { get; set; }

			public int SiteId { get; set; }

			public List<SynonymDefinition> SynonymDefinitions { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int TenantId { get; set; }

		}

}