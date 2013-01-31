using UnityEngine;
using System.Collections;

using System.Xml;

[RequireComponent(typeof(SpriteRepresentation))]
public class SpriteOutput : OutputComponent {
	
	public string spriteID = "id";
	public Color32 color = Color.white;
	public bool solid = true;
	public bool immovable = false;
	public bool visible = true;
	public bool unique = false;
	
	public float scrollfactor_x = 1;
	public float scrollfactor_y = 1;
	
	public float velocity_x = 0;
	public float velocity_y = 0;
	
	public SpriteOutput()
	{
		outputName = "FlxSprite";	
	}
	
	void Awake()
	{	
	}
	
	/* Results are in pixel space */
	public Vector3 GetSpriteTranslation()
	{
		Vector3 position = new Vector3();
		
		float xoffs = Mathf.Abs(transform.lossyScale.x) * SpriteRepresentation.X_SCALE / 2;
		float yoffs = Mathf.Abs(transform.lossyScale.z) * SpriteRepresentation.Z_SCALE / 2;
		
		float xl = transform.position.x - xoffs;
		float yl = transform.position.z + yoffs;
		yl *= -1;
		
		position.x = xl;
		position.y = yl;
		position.z = transform.position.y;
		
		return position;
	}
	
	public Vector3 GetSpriteOrigin()
	{
		Vector3 position = new Vector3();
		
		float xoffs = transform.lossyScale.x * SpriteRepresentation.X_SCALE / 2;
		float yoffs = transform.lossyScale.z * SpriteRepresentation.Z_SCALE / 2;
		
		float xl = transform.position.x - xoffs;
		float yl = transform.position.z + yoffs;
		//yl *= -1;
		
		position.x = xl;
		position.z = yl;
		
		return position;
	}
	
	public Vector3 GetChildOffset(Transform child)
	{
		Vector3 output = new Vector3();	
		Vector3 pixels = GetSpriteOrigin();
		
		float xoffs = child.position.x - pixels.x;
		float zoffs = child.position.z - pixels.z;
		
		output.x = xoffs;
		output.y = -zoffs;
		output.z = 0;
		
		return output;
	}
	
	public void AppendSpriteTranslation(XmlElement parent)
	{
		Vector3 spritePosition = GetSpriteTranslation();
		
		AppendXmlElement("x","" + spritePosition.x, parent);
		AppendXmlElement("y","" + spritePosition.y, parent);
		AppendXmlElement("depth","" + spritePosition.z, parent);
	}
	
	public void AppendChildOffsetPixel(string childName, string elementName, XmlElement parent)
	{
		Transform child = transform.FindChild(childName);
		
		AppendChildOffsetPixel(child, elementName, parent);	
	}
	
	public void AppendChildOffsetPixel(Transform child, string elementName, XmlElement parent)
	{
		if (child != null)
		{
			Vector3 childPixel = GetChildOffset(child);
			
			AppendXmlElement(elementName + "_x", "" + childPixel.x, parent);
			AppendXmlElement(elementName + "_y", "" + childPixel.y, parent);
		}
	}
	
	override public XmlElement ToXmlElement(XmlDocument input)
	{
		XmlElement output = base.ToXmlElement(input);
		
		AppendSpriteTranslation(output);
		AppendXmlElement("width",(transform.lossyScale.x * SpriteRepresentation.X_SCALE).ToString(),output);
		AppendXmlElement("height",(transform.lossyScale.z * SpriteRepresentation.Z_SCALE).ToString(),output);
		
		return output;
	}
}
