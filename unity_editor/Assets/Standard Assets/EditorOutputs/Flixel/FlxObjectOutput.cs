using UnityEngine;
using System.Collections;
using System.Xml;

public class FlxObjectOutput : OutputComponent {
	
	public bool solid = true;
	public bool immovable = false;
	public float scrollfactor_x = 1;
	public float scrollfactor_y = 1;
	
	public FlxObjectOutput()
	{
		outputName = "FlxObject";
	}
	
	override public XmlElement ToXmlElement(XmlDocument input)
	{
		XmlElement output = base.ToXmlElement(input);
		
		Vector3 upperLeft = PlaneToPixel.GetPixelPoint(-1,-1,transform);
		Vector3 lowerRight = PlaneToPixel.GetPixelPoint(1,1,transform);
		
		AppendXmlElement("x","" + upperLeft.x, output);
		AppendXmlElement("y","" + upperLeft.y, output);
		AppendXmlElement("width","" + (lowerRight.x - upperLeft.x), output);
		AppendXmlElement("height","" + (lowerRight.y - upperLeft.y), output);
		AppendXmlElement("depth","" + transform.position.y, output);
		
		return output;
	}
}
