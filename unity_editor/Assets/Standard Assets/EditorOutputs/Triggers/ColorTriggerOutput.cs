using UnityEngine;
using System.Collections;
using System.Xml;

public class ColorTriggerOutput : OutputComponent {
	
	[NoXmlExport]
	public string[] triggers;
	[NoXmlExport]
	public Color32[] colors;
	
	public ColorTriggerOutput()
	{
		outputName = "ColorTrigger";	
	}
	
	override public XmlElement ToXmlElement(XmlDocument parent)
	{
		XmlElement output = base.ToXmlElement(parent);
		
		string[] triggers_out = new string[triggers.Length];
		
		for (int i = 0; i < triggers.Length; i++)
		{
			string trigger = triggers[i];
			char[] separators = {' '};
			string[] split = trigger.Split(separators);
			int index = int.Parse(split[1]);
			
			triggers_out[i] = split[0] + " " + ColorToInt(colors[index]);
			
		}
		
		AppendArray(triggers_out,"triggers",output);
		
		return output;
	}
}
