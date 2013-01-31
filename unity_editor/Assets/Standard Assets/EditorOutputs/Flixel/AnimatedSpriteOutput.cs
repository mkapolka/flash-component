using UnityEngine;
using System.Collections;

public class AnimatedSpriteOutput : SpriteOutput {
	
	public string[] animations;
	public int spriteWidth = 1;
	public int spriteHeight = 1;
	public bool reverseSprite = true;
	public int frameRate = 30;
	public bool loop = true;
	public float drag_x;
	public float drag_y;
	public float acceleration_x;
	public float acceleration_y;
	public string startingAnimation;
	
	public AnimatedSpriteOutput()
	{
		outputName = "AnimatedFlxSprite";	
	}
}
