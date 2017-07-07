/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelementquantity.htm
	/// </summary>
	internal  partial class ElementQuantity : QuantitySet 
	{
		public ElementQuantityQuantities Quantities {get;set;}

		public String MethodOfMeasurement {get;set;}

		public ElementQuantity(ElementQuantityQuantities quantities,
				String methodOfMeasurement) : base()
		{
			this.Quantities = quantities;
			this.MethodOfMeasurement = methodOfMeasurement;
		}
	}
}