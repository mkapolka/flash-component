using UnityEngine;
using System.Collections;

public class AnimatedCloseOutput : OutputComponent {
	
	public enum closeDirection 
	{
		Up,Down,Left,Right	
	}
	
	public closeDirection direction;
	
	public AnimatedCloseOutput()
	{
		outputName = "AnimatedClose";	
	}
}
