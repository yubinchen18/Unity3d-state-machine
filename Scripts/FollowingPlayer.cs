using UnityEngine;
using System.Collections;

public class FollowingPlayer : MonoBehaviour {

	public float cameraHeight = 17.0f;
	public float cameraDistance = 17.0f;
	
	private Transform playerPosition;
	
	// Use this for initialization
	void Start () {
		playerPosition = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = playerPosition.position + new Vector3(cameraDistance, cameraHeight,
		-cameraDistance);
		transform.LookAt (playerPosition);
		
	}
}
