/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcConnectionPointEccentricity : IfcConnectionPointGeometry 
	{
		public IfcConnectionPointEccentricity(Double eccentricityInX,
				Boolean eccentricityInXSpecified,
				Double eccentricityInY,
				Boolean eccentricityInYSpecified,
				Double eccentricityInZ,
				Boolean eccentricityInZSpecified,
				IfcConnectionPointGeometryPointOnRelatingElement pointOnRelatingElement,
				IfcConnectionPointGeometryPointOnRelatedElement pointOnRelatedElement) : base(pointOnRelatingElement,
				pointOnRelatedElement)
		{
			this.EccentricityInX = eccentricityInX;
			this.EccentricityInXSpecified = eccentricityInXSpecified;
			this.EccentricityInY = eccentricityInY;
			this.EccentricityInYSpecified = eccentricityInYSpecified;
			this.EccentricityInZ = eccentricityInZ;
			this.EccentricityInZSpecified = eccentricityInZSpecified;
		}
	}
}