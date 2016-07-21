using UnityEngine;
using System.Collections;

public class CloseDialogue : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClick () {
		Debug.Log("Button clicked");
		gameObject.SetActive(false);
	}
}
