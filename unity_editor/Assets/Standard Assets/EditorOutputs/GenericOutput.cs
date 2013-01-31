using UnityEngine;
using System.Collections;
using System.Xml;

public class GenericOutput : OutputComponent {
	
	[NoXmlExport]
	public string overrideOutputName = "Component";
	
	public GenericOutput()
	{
		outputName = "Component";
	}
	
	override public XmlElement ToXmlElement(XmlDocument input)
	{
		outputName = overrideOutputName;
		
		return base.ToXmlElement(input);
	}
}
