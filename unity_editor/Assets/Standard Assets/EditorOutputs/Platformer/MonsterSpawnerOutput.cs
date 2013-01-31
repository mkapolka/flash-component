using UnityEngine;
using System.Collections;

public class MonsterSpawnerOutput : OutputComponent {
	
	public string template;
	public float timer = 10;
	public int maxMonsters = 5;
	
	public MonsterSpawnerOutput()
	{
		outputName = "MonsterSpawner";	
	}
}
