using UnityEngine;
using System.Collections;

public class WaitTrigger : OutputComponent {
	
	public string trigger;
	public string outMessage;
	public float time;
	
	public WaitTrigger()
	{
		outputName = "WaitTrigger";
	}
}
