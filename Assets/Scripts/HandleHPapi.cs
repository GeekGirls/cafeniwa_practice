using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Net;
using System.Xml;
using UnityEngine.UI;

public class HandleHPapi : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Texture texture = Resources.Load("test_cafe") as Texture;
		Image img = this.GetComponent<Image>();
    img.material.mainTexture = texture;
	}

	// Update is called once per frame
	void Update () {
  }

  // 本当は hotpepper の API を叩いて，画像を取得したいけど，
	// API を叩く部分がいまいちわからないので
	// Assets/images/test_cafe.jpg の Texture を返すようにしています．
  Texture2D getTitleImageFromID (string id) {
		string api_kye = "api_kye";
		string url = "http://webservice.recruit.co.jp/hotpepper/gourmet/v1/?format=json" +
								 "&key=" + api_kye +
								 "&id=" + id;

		WWW www = new WWW (url);
		StartCoroutine (WaitForRequest (www));

    // この辺りが Texture を返すところ
		Texture2D tex = new Texture2D(0, 0);
		tex.LoadImage(LoadBytes("Assets/images/test_cafe.jpg"));
		return tex;
	}

	byte[] LoadBytes(string path) {
	  FileStream fs = new FileStream(path, FileMode.Open);
		BinaryReader bin = new BinaryReader(fs);
		byte[] result = bin.ReadBytes((int)bin.BaseStream.Length);
		bin.Close();
		return result;
	}

	private IEnumerator WaitForRequest(WWW www){
	  yield return www;
		if (www.error == null){
			Debug.Log("WWW OK");
			Debug.Log(www.text);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}
  }
}
