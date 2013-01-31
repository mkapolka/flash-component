using UnityEngine;
using System.Collections;
using System.Xml;

public class ButtonOutput : OutputComponent {
	
	public string overMessage = "over";
	public string outMessage = "out";
	public string downMessage = "down";
	public string upMessage = "up";
	public string enabledMessage = "enabled";
	public string disabledMessage = "disabled";
	
	public ButtonOutput()
	{
		outputName = "Button";	
	}
}
