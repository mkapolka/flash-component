using UnityEngine;
using System.Collections;
using System.Xml;

public class SnapToHeightOutput : OutputComponent {
	
	public string trigger;
	
	[NoXmlExport]
	public Transform heightPoint;
	
	public SnapToHeightOutput()
	{
		outputName = "SnapToHeight";	
	}
	
	override public XmlElement ToXmlElement(XmlDocument input)
	{
		XmlElement output = base.ToXmlElement(input);
		
		AppendXmlElement("height","" + -heightPoint.position.z, output);
		
		return output;
	}
}
