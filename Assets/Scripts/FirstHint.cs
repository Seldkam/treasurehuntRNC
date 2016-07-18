using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Creates text object on "Treasure," which I can assign to false.


public class FirstHint: MonoBehaviour {

	public Transform PlayerCharacter;
	public Text OnScreenText;
	public string EnterText;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ((PlayerCharacter.position - transform.position).magnitude < 5f) {
			OnScreenText.text = EnterText;
		}
	}
}
