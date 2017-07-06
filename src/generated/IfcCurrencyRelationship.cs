/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcCurrencyRelationship : IfcResourceLevelRelationship 
	{
		public IfcCurrencyRelationship(IfcMonetaryUnit relatingMonetaryUnit,
				IfcMonetaryUnit relatedMonetaryUnit,
				IfcLibraryInformation rateSource,
				Double exchangeRate,
				Boolean exchangeRateSpecified,
				String rateDateTime,
				String name,
				String description) : base(name,
				description)
		{
			this.RelatingMonetaryUnit = relatingMonetaryUnit;
			this.RelatedMonetaryUnit = relatedMonetaryUnit;
			this.RateSource = rateSource;
			this.ExchangeRate = exchangeRate;
			this.ExchangeRateSpecified = exchangeRateSpecified;
			this.RateDateTime = rateDateTime;
		}
	}
}