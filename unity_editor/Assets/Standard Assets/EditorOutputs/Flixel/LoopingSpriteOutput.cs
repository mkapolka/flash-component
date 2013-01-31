using UnityEngine;
using System.Collections;

public class LoopingSpriteOutput : OutputComponent {

	public bool loopVertical = true;
	public bool loopHorizontal = true;
	
	public LoopingSpriteOutput()
	{
		outputName = "LoopingSprite";	
	}
}
