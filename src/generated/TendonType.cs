/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class TendonType : ReinforcingElementType 
	{
		public TendonTypeEnum PredefinedType {get;set;}

		public Double NominalDiameter {get;set;}

		public Double CrossSectionArea {get;set;}

		public Double SheathDiameter {get;set;}

		public TendonType(TendonTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				Double nominalDiameter,
				Boolean nominalDiameterSpecified,
				Double crossSectionArea,
				Boolean crossSectionAreaSpecified,
				Double sheathDiameter,
				Boolean sheathDiameterSpecified,
				String elementType,
				TypeProductRepresentationMaps representationMaps,
				String tag,
				TypeObjectHasPropertySets hasPropertySets,
				String applicableOccurrence,
				ObjectDefinitionIsNestedBy isNestedBy,
				ObjectDefinitionIsDecomposedBy isDecomposedBy) : base(elementType,
				representationMaps,
				tag,
				hasPropertySets,
				applicableOccurrence,
				isNestedBy,
				isDecomposedBy)
		{
			this.PredefinedType = predefinedType;
			this.NominalDiameter = nominalDiameter;
			this.CrossSectionArea = crossSectionArea;
			this.SheathDiameter = sheathDiameter;
		}
	}
}