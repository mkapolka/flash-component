using UnityEngine;
using System.Collections;

public class CollisionComponent : OutputComponent {
	
	public string identity;
	public string collideWith;
	
	public CollisionComponent()
	{
		outputName = "Collision";	
	}
}
