using UnityEngine;
using System.Collections;

public class AS2DialogInitiatorOutput : DialogInitiatorOutput {	
	public enum PartnerType {
		Default, Person, Smartphone, Dresser
	}
	
	public PartnerType partnerType = PartnerType.Default;
	public string partnerName;
	public int partnerPortraitID;
	public string initialTopic;
	
	public AS2DialogInitiatorOutput()
	{
		outputName = "AS2DialogInitiator";	
	}
}
