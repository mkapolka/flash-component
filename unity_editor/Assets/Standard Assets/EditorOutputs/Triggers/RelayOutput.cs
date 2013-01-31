using UnityEngine;
using System.Collections;

public class RelayOutput : OutputComponent {
	
	public OutputComponent target;
	public string[] relays;
	
	public RelayOutput()
	{
		outputName = "Relay";	
	}
}
