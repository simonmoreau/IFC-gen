/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreinforcingbar.htm
	/// </summary>
	internal  partial class ReinforcingBar : ReinforcingElement 
	{
		public Double NominalDiameter {get;set;}

		public Double CrossSectionArea {get;set;}

		public Double BarLength {get;set;}

		public ReinforcingBarTypeEnum PredefinedType {get;set;}

		public ReinforcingBarSurfaceEnum BarSurface {get;set;}

		public ReinforcingBar(Double nominalDiameter,
				Double crossSectionArea,
				Double barLength,
				ReinforcingBarTypeEnum predefinedType,
				ReinforcingBarSurfaceEnum barSurface,
				String steelGrade,
				RelProjectsElement hasProjections,
				RelVoidsElement hasOpenings,
				String tag,
				ObjectPlacement objectPlacement,
				ProductRepresentation representation,
				RelDefinesByObject isDeclaredBy,
				RelDefinesByType isTypedBy,
				ObjectIsDefinedBy isDefinedBy,
				String objectType,
				ObjectDefinitionIsNestedBy isNestedBy,
				ObjectDefinitionIsDecomposedBy isDecomposedBy) : base(steelGrade,
				hasProjections,
				hasOpenings,
				tag,
				objectPlacement,
				representation,
				isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.NominalDiameter = nominalDiameter;
			this.CrossSectionArea = crossSectionArea;
			this.BarLength = barLength;
			this.PredefinedType = predefinedType;
			this.BarSurface = barSurface;
		}
	}
}