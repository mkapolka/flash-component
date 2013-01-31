using UnityEngine;
using System.Collections;

public class EchoToParentOutput : OutputComponent {
	
	public string[] messages;
	
	public EchoToParentOutput()
	{
		outputName = "EchoToParent";	
	}
}
