
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

namespace Mozu.Api.Clients.Platform
{
	/// <summary>
	/// platform/extensions related resources. DOCUMENT_HERE 
	/// </summary>
	public partial class TenantExtensionsClient 	{
		
		/// <summary>
		/// platform-extensions Get GetExtensions description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.InstalledApplications.TenantExtensions"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetExtensions( responseFields);
		///   var tenantExtensionsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.InstalledApplications.TenantExtensions> GetExtensionsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.TenantExtensionsUrl.GetExtensionsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.InstalledApplications.TenantExtensions>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// platform-extensions Put UpdateExtensions description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="extensions">Mozu.InstalledApplications.Contracts.TenantExtensions ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.InstalledApplications.TenantExtensions"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateExtensions( extensions,  responseFields);
		///   var tenantExtensionsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.InstalledApplications.TenantExtensions> UpdateExtensionsClient(Mozu.Api.Contracts.InstalledApplications.TenantExtensions extensions, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.TenantExtensionsUrl.UpdateExtensionsUrl(responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.InstalledApplications.TenantExtensions>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.InstalledApplications.TenantExtensions>(extensions);
			return mozuClient;

		}


	}

}


