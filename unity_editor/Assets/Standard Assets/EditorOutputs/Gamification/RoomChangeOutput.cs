using UnityEngine;
using System.Collections;

public class RoomChangeOutput : OutputComponent {
	
	public enum TransitionType {
		None,Fade	
	}
	
	public TransitionType transitionType = TransitionType.None;
	public string trigger = "action";
	public string room = "room";
	public string entrance = "";
	
	public RoomChangeOutput()
	{
		outputName = "ChangeRoom";	
	}
}
