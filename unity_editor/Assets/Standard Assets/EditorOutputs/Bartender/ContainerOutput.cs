using UnityEngine;
using System.Collections;
using System.Xml;

public class ContainerOutput : OutputComponent {
	
	[NoXmlExport]
	public AnchorOutput mouthPoint;
	
	public float capacity;
	public float contentsVolume;
	
	public string contents;
	
	public bool infinite;
	public bool receive;
	
	public ContainerOutput()
	{
		outputName = "Container";	
	}
	
	override public XmlElement ToXmlElement(XmlDocument parent)
	{
		XmlElement output = base.ToXmlElement(parent);
		
		//SpriteOutput spriteOutput = (SpriteOutput)gameObject.GetComponent(typeof(SpriteOutput));
		
		/*if (spriteOutput != null)
		{
			spriteOutput.AppendChildOffsetPixel(mouthPoint, "mouth", output);	
		} else {
			AppendChildPosition(mouthPoint, "mouth",output);	
		}*/
		
		AppendXmlElement("mouthPoint","" + mouthPoint.uid, output);
		
		return output;
	}
}
