using UnityEngine;
using System.Collections;
using UnityEditor;

public class MKTextureImporter : AssetPostprocessor {

	void OnPreprocessTexture()
	{
		TextureImporter textureImporter = (TextureImporter)assetImporter;
		textureImporter.npotScale = TextureImporterNPOTScale.None;
	}
}
