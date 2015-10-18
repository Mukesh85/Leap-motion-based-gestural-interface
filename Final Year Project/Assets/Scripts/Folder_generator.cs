using UnityEngine;
using System.Collections;
using System.IO;
public class Folder_generator : MonoBehaviour {
	public GameObject g;
	private float x, y, z;
	void Start () {
		DirectoryInfo d = new DirectoryInfo (@"E:\");
		x = -15;
		y = 5;
		z = 14;
		foreach (System.IO.DirectoryInfo a in d.GetDirectories("*")) 
		{
			string name = a.Name;
			Debug.Log(name);
			g.name = name;
			Instantiate(g,new Vector3(x, y, z),transform.rotation);
			x += 1;
			z += 0.5f;
		}
	}


}
