/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcRelCoversSpaces : IfcRelConnects 
	{
		public IfcRelCoversSpaces(IfcSpace relatingSpace,
				IfcRelCoversSpacesRelatedCoverings relatedCoverings) : base()
		{
			this.RelatingSpace = relatingSpace;
			this.RelatedCoverings = relatedCoverings;
		}
	}
}