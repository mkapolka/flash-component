using UnityEngine;
using System.Collections;

public class SpriteRepresentation : MonoBehaviour {
	
	public static float X_SCALE = 10;
	public static float Z_SCALE = 10;
	
	public Texture2D texture;
	
	@RequireComponent MeshRenderer;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	[ContextMenu("Update Texture")]
	void UpdateTexture()
	{		
		MeshRenderer renderer = (MeshRenderer)GetComponent("MeshRenderer");
		Material material = new Material(Shader.Find("Transparent/Diffuse"));
		//Material material = renderer.material;
		material.shader = Shader.Find("Transparent/Diffuse");
		
		renderer.sharedMaterial = material;
		
		material.mainTextureScale = new Vector2(-1,-1);
		//renderer.material = material;
		material.mainTexture = texture;
		
		if (texture != null)
		{
			Vector3 scale = new Vector3((float)texture.width / X_SCALE,1,(float)texture.height / Z_SCALE);
			
			Transform oldParent = transform.parent;
			transform.parent = null;
			
			transform.localScale = scale;
			
			transform.parent = oldParent;
		} else {
			Vector3 scale = new Vector3(1,1,1);	
			transform.localScale = scale;
		}
		
		Vector3 position = transform.position;
		transform.position = position;	
	}
	
	[ContextMenu("Update Texture (Retain Scale)")]
	void UpdateTexture2()
	{
		MeshRenderer renderer = (MeshRenderer)GetComponent("MeshRenderer");
		Material material = new Material(Shader.Find("Transparent/Diffuse"));
		//Material material = renderer.material;
		material.shader = Shader.Find("Transparent/Diffuse");
		
		renderer.sharedMaterial = material;
		
		material.mainTextureScale = new Vector2(-1,-1);
		//renderer.material = material;
		material.mainTexture = texture;
	}
}
