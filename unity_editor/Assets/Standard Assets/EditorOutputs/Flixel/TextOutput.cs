using UnityEngine;
using System.Collections;
using System.Xml;

public class TextOutput : OutputComponent {
	
	public enum Alignment { center, left, right };
	
	public string text = "";
	public float textSize = 10;
	public Alignment alignment = Alignment.left;
	public Color color;
	public float scrollfactor_x = 1;
	public float scrollfactor_y = 1;
	public string font = "";
	
	public TextOutput()
	{
		outputName = "FlxText";
	}
	
	override public XmlElement ToXmlElement(XmlDocument parent)
	{
		XmlElement output = base.ToXmlElement(parent);
		
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
