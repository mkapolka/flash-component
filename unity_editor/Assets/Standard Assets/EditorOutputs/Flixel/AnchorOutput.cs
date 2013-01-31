using UnityEngine;
using System.Collections;
using System.Xml;

public class AnchorOutput : OutputComponent {
	
	[NoXmlExport]
	public Transform point;
	
	public string id;
	
	public AnchorOutput()
	{
		outputName = "Anchor";	
	}
	
	public override XmlElement ToXmlElement(XmlDocument input)
	{
		XmlElement output = base.ToXmlElement(input);
		
		Vector3 spriteOrigin = PlaneToPixel.GetSpriteOrigin(transform);
		
		float xOffset = (point.position.x - spriteOrigin.x) / (transform.lossyScale.x * SpriteRepresentation.X_SCALE);
		float yOffset = -(point.position.z - spriteOrigin.z) / (transform.lossyScale.z * SpriteRepresentation.Z_SCALE);
		
		AppendXmlElement("xOffset", "" + xOffset, output);
		AppendXmlElement("yOffset", "" + yOffset, output);
		
		return output;
	}
}
