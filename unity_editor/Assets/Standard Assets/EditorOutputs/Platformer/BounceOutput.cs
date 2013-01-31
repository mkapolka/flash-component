using UnityEngine;
using System.Collections;

public class BounceOutput : OutputComponent {
	
	public float distance = 0;
	public float speed = 1;
	public float offset = 0;
	
	public BounceOutput()
	{
		outputName = "Bounce";	
	}
}
