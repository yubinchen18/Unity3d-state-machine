using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{

	public class PlayStateScene2 : IStateBase
	{
		private StateManager manager;
		private GameObject player;
		private PlayerControl controller;
		
		
		public PlayStateScene2 (StateManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Scene 2")
				Application.LoadLevel ("Scene 2");
				
			player = GameObject.Find ("Player");
			controller = player.GetComponent<PlayerControl>();
			player.rigidbody.isKinematic = false;
			
			foreach (var camera in manager.gameDataRef.cameras)
			{
				if (camera.name != "Following Camera")
					camera.SetActive (false);
				else
					camera.SetActive (true);
			}
		}
		
		public void StateUpdate()
		{
			if(manager.gameDataRef.playerLives <=0)
			{
				manager.SwitchState (new LostStateScene2 (manager));
				manager.gameDataRef.ResetPlayer ();
				player.rigidbody.isKinematic = true;
				player.transform.position = new Vector3(50,.5f,40);
			}
			
			if(manager.gameDataRef.score >= 5)
			{
				manager.SwitchState (new WonStateScene2(manager));
				player.rigidbody.isKinematic = true;
			}
			
			if(Input.GetKey (KeyCode.LeftControl))
			{
				controller.FireEnergyPulse ();
			}
		}
		
		public void ShowIt()
		{
			GUI.Box (new Rect(10,10,100,25), string.Format ("Score: "+ manager.gameDataRef.score));
			GUI.Box (new Rect(Screen.width - 110,10,100,25), string.Format ("Lives left: "+ manager.gameDataRef.playerLives));
			
		}	
			
			
		public void StateFixedUpdate()
		{
		}
	}
}
