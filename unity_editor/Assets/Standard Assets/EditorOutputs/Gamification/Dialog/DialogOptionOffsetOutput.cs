using UnityEngine;
using System.Collections;

public class DialogOptionOffsetOutput : OutputComponent {

	public string trigger = "up";
	public int numOptions = 0;

	public DialogOptionOffsetOutput()
	{
		outputName = "DialogOptionOffset";
	}
}
