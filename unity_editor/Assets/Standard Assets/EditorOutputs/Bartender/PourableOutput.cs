using UnityEngine;
using System.Collections;
using System.Xml;

public class PourableOutput : OutputComponent {
	
	[NoXmlExport]
	public Transform pourPoint;
	
	public string pourRegion;
	
	public float buffer = 50;
	
	public PourableOutput()
	{
		outputName = "Pourable";	
	}
	
	override public XmlElement ToXmlElement(XmlDocument parent)
	{
		XmlElement output = base.ToXmlElement(parent);
		
		AppendXmlElement("pour_height","" + -pourPoint.position.z, output);
		
		return output;
	}
}
