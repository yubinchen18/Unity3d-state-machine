using UnityEngine;
using System.Collections;

public class SphereControl : MonoBehaviour {
	
	public string picked;
	
	public Color red = Color.red;
	public Color blue = Color.blue;
	public Color green = Color.green;
	public Color yellow = Color.yellow;
	public Color white = Color.white;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void SphereUpdate () {
		
	}
	
	public void PickedColor (Color playerColor)
	{
		renderer.material.color = playerColor;
	}
}
