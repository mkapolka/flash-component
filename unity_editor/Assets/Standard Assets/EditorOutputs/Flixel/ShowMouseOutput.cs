using UnityEngine;
using System.Collections;

public class ShowMouseOutput : OutputComponent {
	
	public bool systemMouse = false;
	public string flixelMouseClass = "";
	public bool showMouse = true;
	
	public ShowMouseOutput()
	{
		outputName = "ShowMouse";
	}
}
