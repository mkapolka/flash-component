using UnityEngine;
using System.Collections;

public class CursorOutput : OutputComponent {
	
	public string clickMessage = "click";
	public string releaseMessage = "release";
	public string anchor = "";
	
	public CursorOutput()
	{
		outputName = "Cursor";	
	}
}
