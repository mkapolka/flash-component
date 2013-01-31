using UnityEngine;
using System.Collections;

public class TimerOutput : OutputComponent {
	
	public float delay = 1;
	public string message = "";
	public bool repeat = false;
	
	
	public TimerOutput()
	{
		outputName = "Timer";	
	}
}
