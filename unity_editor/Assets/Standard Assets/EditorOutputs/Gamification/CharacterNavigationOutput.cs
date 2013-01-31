using UnityEngine;
using System.Collections;
using System.Xml;

public class CharacterNavigationOutput : OutputComponent {
	
	public float speed_x;
	public float speed_y;
	public float graceDistance;
	
	[NoXmlExport]
	public Transform target;
	public string anchor;
	
	public string walkingMessage = "walk";
	public string stoppedMessage = "stop";
	
	public bool startWalking = false;
	
	public CharacterNavigationOutput()
	{
		outputName = "CharacterNavigation";
	}
	
	override public XmlElement ToXmlElement(XmlDocument input)
	{
		XmlElement output = base.ToXmlElement(input);
		
		if (target != null)
		{
			AppendXmlElement("target_x",target.position.x.ToString(),output);
			AppendXmlElement("target_y",(-target.position.z).ToString(),output);
		}
		
		return output;
	}
}
