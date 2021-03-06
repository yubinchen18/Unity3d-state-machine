// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States

{
		public class PlayState : IStateBase
		{
				private StateManager manager;
				

				public PlayState (StateManager managerRef)  //Constructor
				{
					manager = managerRef;
					Debug.Log ("Constructing PlayState");
				}

				public void StateUpdate()
				{
					if (Input.GetKeyUp (KeyCode.Space)) {
						manager.SwitchState (new WonState (manager));
					}

					if (Input.GetKeyUp (KeyCode.Return)) {
						manager.SwitchState (new LostState (manager));
					}
				}

				public void ShowIt()
				{

				}

				public void StateFixedUpdate()
				{

				}
		}
}

