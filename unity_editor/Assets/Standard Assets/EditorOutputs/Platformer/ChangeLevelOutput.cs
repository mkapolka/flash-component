using UnityEngine;
using System.Collections;

public class ChangeLevelOutput : OutputComponent {
	
	public string trigger = "collide";
	public string nextLevel = "test_level";
	public string nextDialogID = "p1";
	public float timer = 3;
	
	public ChangeLevelOutput()
	{
		outputName = "ChangeLevel";
	}
}
