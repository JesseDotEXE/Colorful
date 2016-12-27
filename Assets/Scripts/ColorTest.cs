using UnityEngine;
using System.Collections;

public class ColorTest : MonoBehaviour {
	private MeshRenderer renderer;

	// Use this for initialization
	void Start () {
		renderer = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("CHANING COLOR");
		renderer.material.color = Color.red;
	}
}
