using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour {

	public void SpinLeft()
	{
		transform.Rotate (0, 0, 60 * Time.deltaTime);
	}

	public void SpinRight()
	{
		transform.Rotate (0, 0, - 60 * Time.deltaTime);
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
