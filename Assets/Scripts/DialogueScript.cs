using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class DialogueScript : MonoBehaviour {
	public GameObject imageButton;
	public List<GameObject> array;
	
	public void Reset(){
		for (int i = 0; i < array.Count; i++){
			Destroy(array[i]);
		}
		array.Clear();
	}

	// Use this for initialization
	public void ShowDialogue () {

		//GameObject tmp = (GameObject)Resources.Load ("Prefab/ImageButton");
		float y = 180;

			Text first = GameObject.Find ("first").GetComponent<Text>();
			Debug.Log (first.text);
			int firstInteger = Int32.Parse(first.text); 
		
				if (firstInteger >= 11 || firstInteger <= 0){
					firstInteger = 1;
				}

			Text end = GameObject.Find ("end").GetComponent<Text>();
			Debug.Log (end.text);
			int endInteger = Int32.Parse(end.text);

				if (endInteger <= firstInteger || endInteger >= 11){
					endInteger = 10;
				}

			Debug.Log(firstInteger);
			Debug.Log(endInteger);

			for(int i = firstInteger; i < endInteger + 1; i++){
				GameObject instance = Instantiate (imageButton, new Vector3(0, 0, 0), transform.rotation) as GameObject;
				instance.transform.SetParent(transform);
				array.Add(instance);
			
				RectTransform tmp = instance.GetComponent<RectTransform> () as RectTransform;
			//Image image = instance.GetComponent<Image> ();
			//image.material.mainTexture = Resources.Load("cafe" + i.ToString()) asTexture

				Texture2D texture = Resources.Load("cafe" + i.ToString()) as Texture2D;
				Image img = instance.GetComponent<Image> ();//GameObject.Find("Canvas/Panel/***").GetComponent<Image>();	
				img.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);

					if (i % 2 == 1){
						y -= 90;
						tmp.anchoredPosition = new Vector2(-40, y);
					} else {
						tmp.anchoredPosition = new Vector2(40, y);
					}
			
			RectTransform child = imageButton.GetComponent<RectTransform> () as RectTransform;
			RectTransform trans = GetComponent<RectTransform> () as RectTransform;
			child.sizeDelta = new Vector2(60, 60);

			}

		//child.parent = GetComponent<RectTransform> () as RectTransform;
		//RectTransform parent = GetComponent<RectTransform>() as RectTransform;
		//child.SetParent(parent);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
