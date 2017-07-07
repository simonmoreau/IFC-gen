/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class RationalBSplineSurfaceWithKnots : BSplineSurfaceWithKnots 
	{
		public RationalBSplineSurfaceWithKnotsWeightsData WeightsData {get;set;}

		public RationalBSplineSurfaceWithKnots(RationalBSplineSurfaceWithKnotsWeightsData weightsData,
				Int64[] uMultiplicities,
				Int64[] vMultiplicities,
				Double[] uKnots,
				Double[] vKnots,
				KnotType knotSpec,
				Boolean knotSpecSpecified,
				BSplineSurfaceControlPointsList controlPointsList,
				Int64 uDegree,
				Boolean uDegreeSpecified,
				Int64 vDegree,
				Boolean vDegreeSpecified,
				BSplineSurfaceForm surfaceForm,
				Boolean surfaceFormSpecified,
				Logical uClosed,
				Boolean uClosedSpecified,
				Logical vClosed,
				Boolean vClosedSpecified,
				Logical selfIntersect,
				Boolean selfIntersectSpecified,
				StyledItem styledByItem) : base(uMultiplicities,
				vMultiplicities,
				uKnots,
				vKnots,
				knotSpec,
				controlPointsList,
				uDegree,
				vDegree,
				surfaceForm,
				uClosed,
				vClosed,
				selfIntersect,
				styledByItem)
		{
			this.WeightsData = weightsData;
		}
	}
}