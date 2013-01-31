using UnityEngine;
using System.Collections;

public class FloatingHeadTriggerOutput : OutputComponent {
	
	public string headTemplate = "floating_head_left";
	public string headText = "";
	public bool fireOnce = true;
	public string doneMessage = "";
	public bool fireAtStart = false;
	
	public FloatingHeadTriggerOutput()
	{
		outputName = "FloatingHeadTrigger";
	}
}
