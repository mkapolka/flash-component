using UnityEngine;
using System.Collections;

public class DialogInitiatorOutput : OutputComponent {
	
	public string trigger;
	public string dialogPartnerID;
	
	public DialogInitiatorOutput()
	{
		outputName = "DialogInitiator";	
	}
}
