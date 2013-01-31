using UnityEngine;
using System.Collections;

public class MaskOutput : OutputComponent {
	
	public string maskSprite;
	public Color32[] colors;
	public int[] masks;
	public int maskWidth;
	public int maskHeight;
	
	public MaskOutput()
	{
		outputName = "Mask";	
	}
}
