/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class SIUnit : SIUnittemp 
	{
		public SIPrefix Prefix {get;set;}

		public SIUnitName Name {get;set;}

		public SIUnit(SIPrefix prefix,
				Boolean prefixSpecified,
				SIUnitName name,
				Boolean nameSpecified,
				DimensionalExponents dimensions,
				UnitEnum unitType,
				Boolean unitTypeSpecified) : base(dimensions,
				unitType)
		{
			this.Prefix = prefix;
			this.Name = name;
		}
	}
}