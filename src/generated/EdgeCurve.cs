/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class EdgeCurve : Edge 
	{
		public Curve EdgeGeometry {get;set;}

		public Boolean SameSense {get;set;}

		public EdgeCurve(Curve edgeGeometry,
				Boolean sameSense,
				Boolean sameSenseSpecified,
				Vertex edgeStart,
				Vertex edgeEnd,
				StyledItem styledByItem) : base(edgeStart,
				edgeEnd,
				styledByItem)
		{
			this.EdgeGeometry = edgeGeometry;
			this.SameSense = sameSense;
		}
	}
}