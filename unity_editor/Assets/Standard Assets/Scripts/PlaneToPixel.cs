using UnityEngine;
using System.Collections;

public class PlaneToPixel : MonoBehaviour {
	
	/* X and Y Values from -1 to +1*/
	public static Vector3 GetPixelPoint(float x, float y, Transform parent)
	{
		Vector3 output = new Vector3();
		
		float xoffs = parent.lossyScale.x * SpriteRepresentation.X_SCALE / 2 * x;
		float yoffs = parent.lossyScale.z * SpriteRepresentation.Z_SCALE / 2 * -y;
		
		float xl = parent.position.x + xoffs;
		float yl = parent.position.z + yoffs;
		//yl *= -1;
		
		output.x = xl;
		output.y = -yl;
		
		return output;
	}
	
	public static Vector3 GetSpriteOrigin(Transform parent)
	{
		Vector3 position = new Vector3();
		
		float xoffs = parent.lossyScale.x * SpriteRepresentation.X_SCALE / 2;
		float yoffs = parent.lossyScale.z * SpriteRepresentation.Z_SCALE / 2;
		
		float xl = parent.position.x - xoffs;
		float yl = parent.position.z + yoffs;
		//yl *= -1;
		
		position.x = xl;
		position.z = yl;
		
		return position;	
	}
	
	public static Vector3 GetSpriteTranslation(Transform parent)
	{
		Vector3 position = new Vector3();
		
		float xoffs = parent.localScale.x * SpriteRepresentation.X_SCALE / 2;
		float yoffs = parent.localScale.z * SpriteRepresentation.Z_SCALE / 2;
		
		float xl = parent.position.x - xoffs;
		float yl = parent.position.z + yoffs;
		yl *= -1;
		
		position.x = xl;
		position.y = yl;
		position.z = 0;
		
		return position;	
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
