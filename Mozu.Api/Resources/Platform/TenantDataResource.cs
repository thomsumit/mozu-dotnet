
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

namespace Mozu.Api.Resources.Platform
{
	/// <summary>
	/// Use the tenant data resource to store tenant-level information required for a third-party application in the Mozu database.
	/// </summary>
	public partial class TenantDataResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public TenantDataResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public TenantDataResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new TenantDataResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the value of a record in the Mozu database.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// string
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   var string = tenantdata.GetDBValue( dbEntryQuery,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual string GetDBValue(string dbEntryQuery, string responseFields =  null)
		{
			MozuClient<string> response;
			var client = Mozu.Api.Clients.Platform.TenantDataClient.GetDBValueClient( dbEntryQuery,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the value of a record in the Mozu database.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// string
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   var string = await tenantdata.GetDBValueAsync( dbEntryQuery,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<string> GetDBValueAsync(string dbEntryQuery, string responseFields =  null)
		{
			MozuClient<string> response;
			var client = Mozu.Api.Clients.Platform.TenantDataClient.GetDBValueClient( dbEntryQuery,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new record in the Mozu database based on the information supplied in the request.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="value">The value string to create.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   tenantdata.CreateDBValue( value,  dbEntryQuery);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void CreateDBValue(string value, string dbEntryQuery)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.TenantDataClient.CreateDBValueClient( value,  dbEntryQuery);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Creates a new record in the Mozu database based on the information supplied in the request.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="value">The value string to create.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   await tenantdata.CreateDBValueAsync( value,  dbEntryQuery);
		/// </code>
		/// </example>
		public virtual async Task CreateDBValueAsync(string value, string dbEntryQuery)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.TenantDataClient.CreateDBValueClient( value,  dbEntryQuery);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Updates a record in the Mozu database based on the information supplied in the request.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="value">The value string to create.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   tenantdata.UpdateDBValue( value,  dbEntryQuery);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void UpdateDBValue(string value, string dbEntryQuery)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.TenantDataClient.UpdateDBValueClient( value,  dbEntryQuery);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Updates a record in the Mozu database based on the information supplied in the request.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="value">The value string to create.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   await tenantdata.UpdateDBValueAsync( value,  dbEntryQuery);
		/// </code>
		/// </example>
		public virtual async Task UpdateDBValueAsync(string value, string dbEntryQuery)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.TenantDataClient.UpdateDBValueClient( value,  dbEntryQuery);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Removes a previously defined record in the Mozu database.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   tenantdata.DeleteDBValue( dbEntryQuery);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteDBValue(string dbEntryQuery)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.TenantDataClient.DeleteDBValueClient( dbEntryQuery);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Removes a previously defined record in the Mozu database.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   await tenantdata.DeleteDBValueAsync( dbEntryQuery);
		/// </code>
		/// </example>
		public virtual async Task DeleteDBValueAsync(string dbEntryQuery)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.TenantDataClient.DeleteDBValueClient( dbEntryQuery);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


