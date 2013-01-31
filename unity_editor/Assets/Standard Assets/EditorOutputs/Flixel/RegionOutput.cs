using UnityEngine;
using System.Collections;
using System.Xml;

public class RegionOutput : OutputComponent {
	
	
	
	public string id;
	
	public RegionOutput()
	{
		outputName = "Region";	
		id = "Region";
	}
	
	override public XmlElement ToXmlElement(XmlDocument input)
	{
		XmlElement output = base.ToXmlElement(input);
		
		return output;
	}
}
