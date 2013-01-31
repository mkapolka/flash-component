using UnityEngine;
using System.Collections;

public class MonsterControllerOutput : OutputComponent {
	
	public bool startLeft = true;
	public float speed = 0;
	
	public MonsterControllerOutput()
	{
		outputName = "MonsterController";	
	}
}
