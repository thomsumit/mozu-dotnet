
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	The price of the product in the specified currency code (USD). This price can either be the sale price or the price for which the merchant intends to sell the product.
		///
		public class ProductPrice
		{
			///
			///The list price of the product in the catalog.
			///
			public decimal? CatalogListPrice { get; set; }

			///
			///The sale price defined for the product in the catalog.
			///
			public decimal? CatalogSalePrice { get; set; }

			public decimal? CreditValue { get; set; }

			///
			///The discount applied to the product price.
			///
			public AppliedDiscount Discount { get; set; }

			///
			///The manufacturer's suggested retail price for the product.
			///
			public decimal? Msrp { get; set; }

			///
			///The price the merchant intends to charge for the product.
			///
			public decimal? Price { get; set; }

			///
			///The price type that displays on the storefront website for the Price field, which is List, MAP, or CatalogSalePrice
			///
			public string PriceType { get; set; }

			///
			///The sale price defined for the product.
			///
			public decimal? SalePrice { get; set; }

			///
			///The price type that displays on the storefront website for the Sale Price field, which is CatalogSalePrice, DiscountedList, or DiscountedCatalogSalePrice
			///
			public string SalePriceType { get; set; }

		}

}