using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Treasure : MonoBehaviour {

	bool didPlayerWin = false; // Sets player win condition to false
	public Text OnScreenText; // Creates text object on "Treasure," which I can assign to false.
	public Transform PlayerCharacter; // Creates a player object, which I will link to my player sprite
	void Update () {
		if ((PlayerCharacter.position - transform.position).magnitude < 5f) {
			
			OnScreenText.text = "Press [SPACE] to cast your vote!";

			if (Input.GetKey (KeyCode.Space)) {
				didPlayerWin = true;
			}
	
			if ( didPlayerWin ) {
				OnScreenText.text = "Thanks for helping me finding my candidate, I guess. Maybe I shouldn't have narrowed things down so quickly. I wonder what's beyond that wall...";
			}
		}
	}
}

