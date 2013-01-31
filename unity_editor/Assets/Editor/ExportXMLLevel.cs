using UnityEngine;
using UnityEditor;
using System.Collections;

using System.Xml;

public class ExportXMLLevel : MonoBehaviour {
	
	public static string getFilePath()
	{
		Object sio = Object.FindObjectOfType(typeof(SerializationInfo));	
		
		if (sio != null)
		{
			SerializationInfo si = (SerializationInfo)sio;
			
			return si.exportFile;
		} else {
			return null;	
		}
	}
	
	public static void setFilePath(string path)
	{
		Object sio = Object.FindObjectOfType(typeof(SerializationInfo));
		
		if (sio != null)
		{
			SerializationInfo si = (SerializationInfo)sio;
			
			si.exportFile = path;
		} else {
			GameObject go = new GameObject("SerializationInfo");
			
			SerializationInfo si = (SerializationInfo)go.AddComponent(typeof(SerializationInfo));
			si.exportFile = path;
		}
	}
	
	private static XmlElement GameObjectToXmlElement(GameObject gameObject, XmlDocument document)
	{
		XmlElement entityElement = document.CreateElement("entity");
		entityElement.SetAttribute("name",gameObject.name);
		
		Object[] outputComponents = gameObject.GetComponents(typeof(OutputComponent));
		
		for (int j = 0; j < outputComponents.Length; j++)
		{
			OutputComponent oc = (OutputComponent)outputComponents[j];
			XmlElement outputElement = oc.ToXmlElement(document);
			
			entityElement.AppendChild(outputElement);
			outputElement.SetAttribute("uid","" + oc.uid);
		}
		
		for (int i = 0; i < gameObject.transform.GetChildCount(); i++)
		{
			GameObject child = gameObject.transform.GetChild(i).gameObject;
			
			int childOutputComponents = child.GetComponents(typeof(OutputComponent)).Length;
			
			if (childOutputComponents > 0)
			{
				XmlElement childXmlElement = GameObjectToXmlElement(child, document);
				entityElement.AppendChild(childXmlElement);
			}
		}
		
		return entityElement;
	}
	
	private static XmlDocument GetXml()
	{
		XmlDocument outputDocument = new XmlDocument();
		XmlElement rootElement = outputDocument.CreateElement("level");
		outputDocument.AppendChild(rootElement);
		
		//Assign UIDs to components
		//int uid = 0;
		
		Object[] outputComponents = Component.FindObjectsOfType(typeof(OutputComponent));
		
		for (int i = 0; i < outputComponents.Length; i++)
		{
			OutputComponent oc = (OutputComponent)outputComponents[i];
			
			oc.uid = Mathf.FloorToInt(Random.value * Mathf.Pow(2,31));//uid++;
		}
		
		Object[] objects = GameObject.FindObjectsOfType(typeof(GameObject));
		
		int entity_uid = 0;
		
		for (int i = 0; i < objects.Length; i++)
		{
			GameObject go = (GameObject)objects[i];
			
			if (go.GetComponent(typeof(OutputComponent)) != null 
			    && (go.transform.parent == null || go.transform.parent.GetComponent(typeof(OutputComponent)) == null))
			{
				XmlElement entityElement = GameObjectToXmlElement(go, outputDocument);
				entityElement.SetAttribute("uid",entity_uid.ToString());
				entity_uid++;
				
				rootElement.AppendChild(entityElement);
			}
		}
		
		return outputDocument;
	}
	
	[MenuItem ("Marek/Export XML (Save)")]
	static void ExportXMLAuto()
	{
		if (getFilePath() != null)
		{
			XmlDocument outputDocument = GetXml();
			outputDocument.Save(getFilePath());
			Debug.Log("File successfully Created.");
		} else {
			ExportXML();	
		}
	}
	
	[MenuItem ("Marek/Export XML (Save As)")]
	static void ExportXML()
	{
		XmlDocument outputDocument = GetXml();
		
		string path = EditorUtility.SaveFilePanel("Export Level as XML","","level","xml");	
		
		if (path.Length != 0)
		{
			setFilePath(path);
			outputDocument.Save(path);
			Debug.Log("File successfully Created.");
		}
	}
}
