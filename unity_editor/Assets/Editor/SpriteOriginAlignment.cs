using UnityEngine;
using UnityEditor;
using System.Collections;

public class SpriteOriginAlignment : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	[MenuItem ("Marek/Align With Origin")]
	static void alignSpriteWithOrigin()
	{
		Transform selection = Selection.activeTransform;
		
		float xoffs = selection.localScale.x * SpriteRepresentation.X_SCALE / 2;
		float zoffs = selection.localScale.z * SpriteRepresentation.Z_SCALE / 2;
		
		Vector3 newPosition = new Vector3(selection.position.x, selection.position.y, selection.position.z);
		newPosition.x = xoffs;
		newPosition.z = -zoffs;
		
		selection.position = newPosition;
	}
}
