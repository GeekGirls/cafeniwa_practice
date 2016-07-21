using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SearchButton : MonoBehaviour {
	public GameObject BackGroundDialogue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClick(){

		Text first = GameObject.Find ("first").GetComponent<Text>();
		Debug.Log (first.text);
		
		Text end = GameObject.Find ("end").GetComponent<Text>();
		Debug.Log (end.text);

		BackGroundDialogue.SetActive(true);


		
	}
}
