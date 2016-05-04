
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
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.Content
{
		///
		///	The type of documents used in the CMS such as "web_page" or "template" or "image_url".
		///
		public class DocumentType
		{
			public string AdminName { get; set; }

			public string DocumentTypeFQN { get; set; }

			public string InstallationPackage { get; set; }

			public JObject Metadata { get; set; }

			///
			///The name of the document type.
			///
			public string Name { get; set; }

			public string Namespace { get; set; }

			public List<Property> Properties { get; set; }

			public string Version { get; set; }

		}

}