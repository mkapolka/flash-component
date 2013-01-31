using UnityEngine;
using System.Collections;
using System.Xml;

public class HoldableOutput : OutputComponent {
	
	[NoXmlExport]
	public AnchorOutput holdPoint;
	
	public string dropRegions;
	
	public HoldableOutput()
	{
		outputName = "Holdable";
	}
	
	override public XmlElement ToXmlElement(XmlDocument parent)
	{
		XmlElement output = base.ToXmlElement(parent);
		
		//SpriteOutput spriteOutput = (SpriteOutput)gameObject.GetComponent(typeof(SpriteOutput));
		
		/*if (spriteOutput != null)
		{
			spriteOutput.AppendChildOffsetPixel(holdPoint, "hold", output);	
		} else {
			AppendChildPosition(holdPoint, "hold",output);	
		}*/
		
		AppendXmlElement("holdPoint","" + holdPoint.uid, output);
		
		return output;
	}
}
