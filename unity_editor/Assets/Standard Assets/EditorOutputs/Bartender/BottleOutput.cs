using UnityEngine;
using System.Collections;
using System.Xml;

public class BottleOutput : OutputComponent {
	
	[NoXmlExport]
	public Transform pourPoint;
	
	[NoXmlExport]
	public Transform holdPoint;
	
	public BottleOutput()
	{
		outputName = "BottleComponent";	
	}
	
	override public XmlElement ToXmlElement(XmlDocument parent)
	{
		XmlElement output = base.ToXmlElement(parent);
		
		SpriteOutput spriteOutput = (SpriteOutput)gameObject.GetComponent(typeof(SpriteOutput));
		
		if (spriteOutput != null)
		{
			spriteOutput.AppendChildOffsetPixel(pourPoint,"pour",output);
			spriteOutput.AppendChildOffsetPixel(holdPoint,"hold",output);
		} else {
			AppendChildPosition(pourPoint,"pour",output, true);
			AppendChildPosition(holdPoint,"hold",output, true);
		}
		
		
		return output;
	}
}
