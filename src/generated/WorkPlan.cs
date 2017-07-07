/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class WorkPlan : WorkControl 
	{
		public WorkPlanTypeEnum PredefinedType {get;set;}

		public WorkPlan(WorkPlanTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				WorkControlCreators creators,
				String creationDate,
				String purpose,
				String duration,
				String totalFloat,
				String startTime,
				String finishTime,
				String identification,
				RelDefinesByObject isDeclaredBy,
				RelDefinesByType isTypedBy,
				ObjectIsDefinedBy isDefinedBy,
				String objectType,
				ObjectDefinitionIsNestedBy isNestedBy,
				ObjectDefinitionIsDecomposedBy isDecomposedBy) : base(creators,
				creationDate,
				purpose,
				duration,
				totalFloat,
				startTime,
				finishTime,
				identification,
				isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.PredefinedType = predefinedType;
		}
	}
}