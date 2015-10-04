using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
	
{
	public class PlayStateScene1_1 : IStateBase
	{
		private StateManager manager;
		private GameObject player;
		private PlayerControl controller;
		
		public PlayStateScene1_1 (StateManager managerRef)  //Constructor
		{
			manager = managerRef;
			player = GameObject.Find ("Player");
			player.rigidbody.isKinematic = false;
			controller = player.GetComponent<PlayerControl>();
			
			if(Application.loadedLevelName != "Scene 1")
				Application.LoadLevel("Scene 1");
			
			
			
			foreach(GameObject camera in manager.gameDataRef.cameras)
			{
				if(camera.name != "LookAt Camera")
					camera.SetActive (false);
				else
					camera.SetActive (true);
			}
		}
		
		public void StateUpdate()
		{
			if(manager.gameDataRef.playerLives <=0)
			{
				manager.SwitchState (new LostStateScene1 (manager));
				manager.gameDataRef.ResetPlayer ();
				player.rigidbody.isKinematic = true;
				player.transform.position = new Vector3(50, 1, 40);
			}
			
			if(manager.gameDataRef.score >= 2)
			{
				manager.SwitchState (new WonStateScene1(manager));
				player.rigidbody.isKinematic = true;
				player.transform.position = new Vector3(50, 1, 40);
			}
			
			if (Input.GetKeyDown (KeyCode.A))
			{
				controller.FireEnergyPulse();
			}
		}
		
		public void ShowIt()
		{
			GUI.Box (new Rect(10,10,100,25), string.Format ("Score: " + manager.gameDataRef.score));
			
			if(GUI.Button (new Rect(Screen.width/2 -130, 10, 260, 30), string.Format ("Click here or Press 2 for Level 1, State 2"))
			|| Input.GetKeyUp (KeyCode.Alpha2))
			{
				manager.SwitchState (new PlayStateScene1_2(manager));
			}
			
			GUI.Box (new Rect(Screen.width - 110,10,100,25), string.Format ("Lives left: " + manager.gameDataRef.playerLives));
			
		}
		
		public void StateFixedUpdate()
		{
			
		}
	}
}
