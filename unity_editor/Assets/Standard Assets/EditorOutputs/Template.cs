using UnityEngine;
using System.Collections;

public class Template : OutputComponent {
	
	public string id;
	public bool instantiate = false;
	
	public Template()
	{
		outputName = "Template";
	}
}
