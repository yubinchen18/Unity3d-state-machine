using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class WonStateScene1 : IStateBase
	{
		private StateManager manager;
		
		public WonStateScene1 (StateManager managerRef)
		{
			manager = managerRef;
			if(Application.loadedLevelName != "Scene 0")
				Application.LoadLevel ("Scene 0");
			
			manager.gameDataRef.SetScore ();
		}
		
		public void StateUpdate()
		{
		}
		
		public void ShowIt()
		{
			GUI.DrawTexture (new Rect(0,0,Screen.width,Screen.height),
			manager.gameDataRef.wonStateSplash,ScaleMode.StretchToFill);
			
			if(GUI.Button (new Rect(10,10,250,30), "Click Here or Space key for next Level") 
			|| Input.GetKeyUp (KeyCode.Space))
			{
				manager.SwitchState (new PlayStateScene2 (manager));
			}
		}
			
			
			

	
	// Update is called once per frame
		public void StateFixedUpdate () {
	
		}
	}
}
