using UnityEngine;
using System.Collections;

public class ProgressBarOutput : SpriteOutput {

	public float progress;
	public float targetProgress;
	
	public ProgressBarOutput()
	{
		outputName = "ProgressBar";
	}
}
