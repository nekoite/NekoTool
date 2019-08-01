using System;
using System.Linq;

namespace NekoTool.Lang.Reflection
{
	public static class AttributeUtil
	{
		/// <summary>
		/// Returns the value of a class attribute for a class.
		/// https://stackoverflow.com/questions/2656189/how-do-i-read-an-attribute-on-a-class-at-runtime
		/// </summary>
		/// <typeparam name="TAttribute"></typeparam>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="type"></param>
		/// <param name="valueSelector"></param>
		/// <returns></returns>
		public static TValue GetAttributeValue<TAttribute, TValue>(
			Type type,
			Func<TAttribute, TValue> valueSelector) where TAttribute : Attribute
		{
			TAttribute att = (TAttribute) type.GetCustomAttributes(
				typeof(TAttribute), true
			).FirstOrDefault();

			if (att != null)
			{
				return valueSelector(att);
			}
			return default(TValue);
		}

		/// <summary>
		/// Returns the value of a member attribute for any member in a class.
		///     (a member is a Field, Property, Method, etc...)    
		/// <remarks>
		/// If there is more than one member of the same name in the class, it will return the first one (this applies to overloaded methods)
		/// </remarks>
		/// <example>
		/// Read System.ComponentModel Description Attribute from method 'MyMethodName' in class 'MyClass': 
		///     var Attribute = typeof(MyClass).GetAttribute("MyMethodName", (DescriptionAttribute d) => d.Description);
		/// </example>
		/// <param name="type">The class that contains the member as a type</param>
		/// <param name="MemberName">Name of the member in the class</param>
		/// <param name="valueSelector">Attribute type and property to get (will return first instance if there are multiple attributes of the same type)</param>
		/// <param name="inherit">true to search this member's inheritance chain to find the attributes; otherwise, false. This parameter is ignored for properties and events</param>
		/// </summary>
		public static TValue GetAttributeValue<TAttribute, TValue>(
			Type type, 
			string memberName, 
			Func<TAttribute, TValue> valueSelector, 
			bool inherit = false) where TAttribute : Attribute
		{
			TAttribute att = (TAttribute) type
				.GetMember(memberName)
				.FirstOrDefault()
				.GetCustomAttributes(typeof(TAttribute), inherit)
				.FirstOrDefault();
			if (att != null)
			{
				return valueSelector(att);
			}
			return default(TValue);
		}
	}
}
