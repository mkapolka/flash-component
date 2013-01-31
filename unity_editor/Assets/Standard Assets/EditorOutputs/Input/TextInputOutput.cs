using UnityEngine;
using System.Collections;

public class TextInputOutput : OutputComponent {
	
	public Color textColor = Color.black;
	public float textSize = 12;
	public string font = "Times New Roman";
	public TextOutput.Alignment textAlignment;
	public string focusTrigger = "focus";
	
	public TextInputOutput()
	{
		outputName = "TextInput";
	}
}
