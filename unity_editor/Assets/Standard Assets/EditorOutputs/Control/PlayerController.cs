using UnityEngine;
using System.Collections;

public class PlayerController : OutputComponent {
	
	public string upKey;
	public string downKey;
	public string leftKey;
	public string rightKey;
	public float speed;
	
	public PlayerController()
	{
		outputName = "PlayerController";	
	}
}
