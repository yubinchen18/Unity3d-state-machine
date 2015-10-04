using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {

	private Transform playerPosition;
	
	// Use this for initialization
	void Start () {
		playerPosition = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.LookAt (playerPosition);
	}
}
