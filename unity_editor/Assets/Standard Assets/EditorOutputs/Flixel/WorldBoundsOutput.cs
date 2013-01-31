using UnityEngine;
using System.Collections;
using System.Xml;


public class WorldBoundsOutput : OutputComponent {
	
	public bool cameraBounds = true;
	public bool worldBounds = true;
	
	public WorldBoundsOutput()
	{
		outputName = "WorldBounds";	
	}
	
	public override XmlElement ToXmlElement(XmlDocument input)
	{
		XmlElement output = base.ToXmlElement(input);
		
		Vector3 upperLeft = PlaneToPixel.GetPixelPoint(-1,-1,transform);
		Vector3 lowerRight = PlaneToPixel.GetPixelPoint(1,1,transform);
		
		AppendXmlElement("x","" + upperLeft.x, output);
		AppendXmlElement("y","" + upperLeft.y, output);
		AppendXmlElement("width","" + (lowerRight.x - upperLeft.x), output);
		AppendXmlElement("height","" + (lowerRight.y - upperLeft.y), output);
		
		return output;
	}
}
