using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime.Misc;
using IFC4.Generators;

namespace Express
{
	/// <summary>
	/// AttributeData store information about an attribute.
	/// </summary>
	public class AttributeData
	{
		private ILanguageGenerator generator;

		public string Name{get;set;}

		internal string type;
		public string Type
		{
			get
			{
				return generator.AttributeDataType(this);
			}
			set
			{
				type = value;
			}
		}

		public bool IsInverse{get;set;}

		public bool IsDerived{get;set;}

		public bool IsOptional{get;set;}

		public bool IsCollection{get;set;}

		public int Rank{get;set;}

		public AttributeData (ILanguageGenerator generator)
		{
			this.generator = generator;
		}

		/// <summary>
		/// A string representing the parameter corresponding to an attribute's info.
		/// </summary>
		/// <returns></returns>
		public string ParameterName
		{
			get
			{
				var name = Name;
				if(name == "Operator")
				{
					name = "op";
				}

				// Sometimes the name will be of the format SELF\IfcGeometricRepresentationContext.TrueNorth
				// This won't work as a parameter name. Split it and takes the last part.
				var split = name.Split('.');
				if(split.Count() > 1)
				{
					name = split.Last();
				}
				return Char.ToLowerInvariant(name[0]) + name.Substring(1);
			}
		}

		public override string ToString()
		{
			return generator.AttributeDataString(this);
		}

		public string ToStepString()
		{
			return generator.AttributeStepString(this);
		}

		public string Assignment()
		{
			return generator.AttributeDataAssignment(this);
		}

		public string Allocation(){
			return generator.AttributeDataAllocation(this);
		}
	}

	public abstract class TypeData
	{
		public string Name {get;set;}
		protected ILanguageGenerator generator;

		public TypeData(string name, ILanguageGenerator generator)
		{
			this.generator = generator;
			Name = name;
		}
	}

	public abstract class CollectionTypeData : TypeData
	{
		/// <summary>
		/// For a TypeData which wraps a Select or an Enum, the Values
		/// collection will contain the items that are enumerated or selected.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<string> Values{get;set;}

		public CollectionTypeData(string name, ILanguageGenerator generator) : base(name, generator)
		{
			Values = new List<string>();
		}
	}

	public class SimpleType : TypeData
	{
		public bool IsCollectionType{get;set;}

		/// <summary>
		/// For a TypeData which wraps a collection, the rank is the depth of
		/// the collection. Ex: A collection with Rank=1 will be a List<List<object>>.
		/// </summary>
		/// <returns></returns>
		public int Rank{get;set;}
		
		internal string wrappedType;
		/// <summary>
		/// In the case of a simple type, the WrappedType
		/// will be the name of type which is wrapped in an IfcType.
		/// </summary>
		/// <returns></returns>
		public string WrappedType
		{
			get
			{
				return generator.SimpleTypeWrappedType(this);
			}
			set
			{
				wrappedType = value;
			}
		}

		public SimpleType(string name, ILanguageGenerator generator) : base(name, generator){}

		private string AsCollection()
		{
			return generator.SimpleTypeAsCollection(this);
		}

		/// <summary>
		/// Return a string representing the TypeData as an IfcType.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{	
			return generator.SimpleTypeString(this);
		}
	}

	public class EnumType : CollectionTypeData
	{
		public EnumType(string name, ILanguageGenerator generator) : base(name, generator){}

		/// <summary>
		/// Returns a string representing the TypeData as an Enum.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return generator.EnumTypeString(this);
		}
	}

	public class SelectType : CollectionTypeData
	{
		public SelectType(string name, ILanguageGenerator generator) : base(name, generator){}

		/// <summary>
		/// Return a string representing the TypeData as a Select.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return generator.SelectTypeString(this);
		}
	}

	/// <summary>
	/// TypeData stores information about a type.
	/// </summary>
	public class Entity : TypeData
	{
		public List<Entity> Supers{get;set;}
		public List<Entity> Subs{get;set;}

		public List<AttributeData> Attributes{get;set;}

		public bool IsAbstract{get;set;}

		public Entity(string name, ILanguageGenerator generator) : base(name, generator)
		{
			Name = name;
			Supers = new List<Entity>();
			Subs = new List<Entity>();
			Attributes = new List<AttributeData>();
		}

		/// <summary>
		/// Return all parents to this type all the way to the root.
		/// </summary>
		/// <returns></returns>
		internal IEnumerable<Entity> Parents()
		{
			var parents = new List<Entity>();
			parents.AddRange(Subs);

			foreach(var s in Subs)
			{
				parents.AddRange(s.Parents());
			}

			return parents;
		}

		internal IEnumerable<Entity> ParentsAndSelf()
		{
			var parents = new List<Entity>();
			parents.Add(this);

			parents.AddRange(Subs);

			foreach(var s in Subs)
			{
				parents.AddRange(s.Parents());
			}

			return parents;
		}

		/// <summary>
		/// Return a set of constructor parameters in the form 'Type name1, Type name2'
		/// </summary>
		/// <returns></returns>
		internal string ConstructorParams(bool includeOptional)
		{
			return generator.EntityConstructorParams(this, includeOptional);
		}
		
		/// <summary>
		/// Return a set of constructor params in the form `name1, name2`.
		/// </summary>
		/// <returns></returns>
		internal string BaseConstructorParams(bool includeOptional)
		{
			return generator.EntityBaseConstructorParams(this, includeOptional);
		}

		/// <summary>
		/// Determine whether this is the provided type or a sub-type of the provided type.
		/// </summary>
		/// <param name="typeName"></param>
		/// <returns></returns>
		public bool IsTypeOrSubtypeOfEntity(string typeName)
		{
			if(this.Name == typeName)
			{
				return true;
			}

			foreach(var s in Subs)
			{
				var found = s.IsTypeOrSubtypeOfEntity(typeName);
				if(found)
				{
					return true;
				}
			}

			return false;
		}

		public string Properties()
		{
			var attrs = Attributes.Where(a=>!a.IsDerived);
			if(!attrs.Any())
			{
				return string.Empty;
			}

			var propBuilder = new StringBuilder();
			propBuilder.AppendLine();
			foreach(var a in attrs)
			{
				var prop = a.ToString();
				if(!string.IsNullOrEmpty(prop))
				{
					propBuilder.Append(prop);
				}
			}
			return propBuilder.ToString();
		}

		public string StepProperties()
		{
			var attrs = Attributes.Where(a=>!a.IsDerived);
			if(!attrs.Any())
			{
				return string.Empty;
			}

			var propBuilder = new StringBuilder();
			propBuilder.AppendLine();
			foreach(var a in attrs)
			{
				var prop = a.ToStepString();
				if(!string.IsNullOrEmpty(prop))
				{
					propBuilder.Append(prop);
				}
			}
			return propBuilder.ToString();
		}
		internal IEnumerable<AttributeData> AttributesWithOptional(IEnumerable<AttributeData> ad)
		{
			return  ad	.Where(a=>!a.IsInverse)
						.Where(a=>!a.IsDerived);
		}

		internal IEnumerable<AttributeData> AttributesWithoutOptional(IEnumerable<AttributeData> ad)
		{
			return  ad	.Where(a=>!a.IsInverse)
						.Where(a=>!a.IsDerived)
						.Where(a=>!a.IsOptional);
		}

		public string Assignments(bool includeOptional)
		{
			var attrs = includeOptional?AttributesWithOptional(Attributes):AttributesWithoutOptional(Attributes);
			if(!attrs.Any())
			{
				return string.Empty;
			}

			var assignBuilder = new StringBuilder();
			foreach(var a in attrs)
			{
				var assign = a.Assignment();
				if(!string.IsNullOrEmpty(assign))
				{
					assignBuilder.Append(assign);
				}
			}
			return assignBuilder.ToString();
		}

		public string Allocations(){

			var allocBuilder = new StringBuilder();
			foreach(var a in Attributes.Where(a=>!a.IsDerived)){
				var alloc = a.Allocation();
				if(!string.IsNullOrEmpty(alloc)){
					allocBuilder.Append(alloc);
				}
			}
			return allocBuilder.ToString();
		}
		
		/// <summary>
		/// Return a string representing the TypeData as a Class.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return generator.EntityString(this);
		}
	}
}