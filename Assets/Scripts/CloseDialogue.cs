using UnityEngine;
using System.Collections;

public class CloseDialogue : MonoBehaviour {
	public GameObject Dialogue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClick () {
		gameObject.SetActive(false);
		DialogueScript Script = Dialogue.GetComponent<DialogueScript>() as DialogueScript;
		Script.Reset();
	}
}
