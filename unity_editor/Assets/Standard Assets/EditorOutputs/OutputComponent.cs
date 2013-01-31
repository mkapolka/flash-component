using UnityEngine;
using System.Collections;

using System.Xml;
using System.Reflection;
using System;

public class OutputComponent : MonoBehaviour {
	
	[NoXmlExport]
	[HideInInspector]
	public string outputName = "Component";
	
	[NoXmlExport]
	[HideInInspector]
	public int uid = 0;
	
	public void AppendXmlElement(string name, string value, XmlElement parent)
	{
		XmlElement element = parent.OwnerDocument.CreateElement(name);	
		XmlText text = parent.OwnerDocument.CreateTextNode(value);
		
		element.AppendChild(text);
		parent.AppendChild(element);
	}
	
	public void AppendTranslation(XmlElement parent)
	{
		AppendXmlElement("x","" + transform.position.x,parent);
		AppendXmlElement("y","" + -transform.position.z,parent);
	}
	
	public void AppendScale(XmlElement parent)
	{
		AppendXmlElement("xscale","" + transform.localScale.x,parent);
		AppendXmlElement("yscale","" + transform.localScale.z,parent);
	}
	
	public void AppendChildPosition(string childName, string tagName, XmlElement parent, bool relative = false)
	{
		Transform child = transform.FindChild(childName);
		
		AppendChildPosition(child,tagName,parent, relative);
	}
	
	public void AppendChildPosition(Transform child, string tagName, XmlElement parent, bool relative = false)
	{
		if (child != null)
		{
			float x = child.position.x;
			float y = -child.position.z;
			
			if (relative)
			{
				x -= transform.position.x;
				y += transform.position.z;
			}
			
			AppendXmlElement(tagName + "_x", "" + x, parent);
			AppendXmlElement(tagName + "_y", "" + y, parent);
		}
	}
	
	public void AppendArray(object[] array, string name, XmlElement parent)
	{
		XmlElement arrayElement = parent.OwnerDocument.CreateElement(name);
		
		for (int i = 0; i < array.Length; i++)
		{
			AppendXmlElement("entry", array[i].ToString(), arrayElement);
		}
		
		parent.AppendChild(arrayElement);
	}
	
	virtual public XmlElement ToXmlElement(XmlDocument input)
	{	
		XmlElement output = input.CreateElement(outputName);
		
		FieldInfo[] fields = GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
		
		for (int i = 0; i < fields.Length; i++)
		{
			FieldInfo field = fields[i];
			
			System.Object[] attributes = field.GetCustomAttributes(typeof(NoXmlExport), true);
			
			if (attributes.Length == 0)
			{
				if (field.FieldType.IsArray)
				{
					//object[] list = (object[])field.GetValue(this);
					Array list = (Array)field.GetValue(this);
					
					XmlElement arrayParent = input.CreateElement(field.Name);
					for (int j = 0; j < list.Length; j++)
					{
						//AppendField("entry", list[j], arrayParent);
						AppendField("entry", list.GetValue(j), arrayParent);
					}
					
					output.AppendChild(arrayParent);
				} else {
					AppendField(field.Name, field.GetValue(this), output);
				}				
			}
		}
		
		return output;
	}
	
	static bool DoesTypeInherit(Type toCheck, Type target) 
	{
	    while (toCheck != typeof(object)) {
	        if (target == toCheck) {
	            return true;
	        }
	        toCheck = toCheck.BaseType;
	    }
	    return false;
	}
	
	public static uint ColorToInt(System.Object o)
	{
		Color32 color;
			
		if (o.GetType() == typeof(Color))
		{
			Color c = (Color)o;
			color = c;
		} else {
			color = (Color32)o;	
		}
		
		uint output = 0;
		
		output |= (uint)(color.b);
		output |= (uint)(color.g) << 8;
		output |= (uint)(color.r) << 16;
		output |= (uint)(color.a) << 24;
		
		return output;
	}
	
	public void AppendField(string name, System.Object field, XmlElement parent)
	{
		if (DoesTypeInherit(field.GetType(), typeof(OutputComponent)))
		{
			OutputComponent oc = (OutputComponent)(field);
			AppendXmlElement(name, oc.uid.ToString(), parent);
			return;
		}
		
		if (field.GetType() == typeof(Color) || field.GetType() == typeof(Color32))
		{
			uint color = ColorToInt(field);
			
			AppendXmlElement(name, color.ToString(), parent);
			return;
		}
		
		AppendXmlElement(name, field.ToString(), parent);
		return;
	}
}
