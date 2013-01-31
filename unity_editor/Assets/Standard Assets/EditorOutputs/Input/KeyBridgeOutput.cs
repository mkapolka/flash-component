using UnityEngine;
using System.Collections;

public class KeyBridgeOutput : OutputComponent {
	
	public string[] downBridges;
	public string[] upBridges;
	public string[] pressedBridges;
	
	public KeyBridgeOutput()
	{
		outputName = "KeyboardBridge";	
	}
}
