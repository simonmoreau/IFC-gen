/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcIShapeProfileDef : IfcParameterizedProfileDef 
	{
		public IfcIShapeProfileDef(Double overallWidth,
				Boolean overallWidthSpecified,
				Double overallDepth,
				Boolean overallDepthSpecified,
				Double webThickness,
				Boolean webThicknessSpecified,
				Double flangeThickness,
				Boolean flangeThicknessSpecified,
				Double filletRadius,
				Boolean filletRadiusSpecified,
				Double flangeEdgeRadius,
				Boolean flangeEdgeRadiusSpecified,
				Double flangeSlope,
				Boolean flangeSlopeSpecified,
				IfcAxis2Placement2D position,
				IfcProfileDefHasProperties hasProperties,
				IfcProfileTypeEnum profileType,
				Boolean profileTypeSpecified,
				String profileName) : base(position,
				hasProperties,
				profileType,
				profileTypeSpecified,
				profileName)
		{
			this.OverallWidth = overallWidth;
			this.OverallWidthSpecified = overallWidthSpecified;
			this.OverallDepth = overallDepth;
			this.OverallDepthSpecified = overallDepthSpecified;
			this.WebThickness = webThickness;
			this.WebThicknessSpecified = webThicknessSpecified;
			this.FlangeThickness = flangeThickness;
			this.FlangeThicknessSpecified = flangeThicknessSpecified;
			this.FilletRadius = filletRadius;
			this.FilletRadiusSpecified = filletRadiusSpecified;
			this.FlangeEdgeRadius = flangeEdgeRadius;
			this.FlangeEdgeRadiusSpecified = flangeEdgeRadiusSpecified;
			this.FlangeSlope = flangeSlope;
			this.FlangeSlopeSpecified = flangeSlopeSpecified;
		}
	}
}