/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelflowcontrolelements.htm
	/// </summary>
	internal  partial class RelFlowControlElements : RelConnects 
	{
		public RelFlowControlElementsRelatedControlElements RelatedControlElements {get;set;}

		public DistributionFlowElement RelatingFlowElement {get;set;}

		public RelFlowControlElements(RelFlowControlElementsRelatedControlElements relatedControlElements,
				DistributionFlowElement relatingFlowElement) : base()
		{
			this.RelatedControlElements = relatedControlElements;
			this.RelatingFlowElement = relatingFlowElement;
		}
	}
}