using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BushReactionZone : MonoBehaviour {


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