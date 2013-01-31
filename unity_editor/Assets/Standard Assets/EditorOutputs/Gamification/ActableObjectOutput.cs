using UnityEngine;
using System.Collections;

public class ActableObjectOutput : OutputComponent {
	
	public enum InteractionType
	{
		Use=1,Talk=2,Examine=3,Smartphone=4	
	}
	
	public InteractionType interactionType = ActableObjectOutput.InteractionType.Examine;
	public bool walkTo;
	
	public string mouseOverName = "Something";
	public string actionPointAnchor = "action";
	
	public ActableObjectOutput()
	{
		outputName = "ActableObject";	
	}
}
