using UnityEngine;
using System.Collections;
using System.Xml;

public class SnapToOutput : OutputComponent {
	
	public string trigger;
	
	public string anchor;
	
	[NoXmlExport]
	public FlxObjectOutput[] snapToPoints;
	
	public SnapToOutput()
	{
		outputName = "SnapTo";
	}
	
	public override XmlElement ToXmlElement(XmlDocument parent)
	{
		XmlElement output = base.ToXmlElement(parent);
		
		string[] snapUIDs = new string[snapToPoints.Length];
		
		for (int i = 0; i < snapUIDs.Length; i++)
		{
			snapUIDs[i] = "" + snapToPoints[i].uid;	
		}
		
		AppendArray(snapUIDs, "snapPoints", output);
		
		return output;
	}
}