/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class TextLiteralWithExtent : TextLiteral 
	{
		public PlanarExtent Extent {get;set;}

		public String BoxAlignment {get;set;}

		public TextLiteralWithExtent(PlanarExtent extent,
				String boxAlignment,
				TextLiteralPlacement placement,
				String literal,
				TextPath path,
				Boolean pathSpecified,
				StyledItem styledByItem) : base(placement,
				literal,
				path,
				styledByItem)
		{
			this.Extent = extent;
			this.BoxAlignment = boxAlignment;
		}
	}
}