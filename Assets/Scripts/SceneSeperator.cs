using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour {
	public TextAsset text;
	public string[] scenes;
	public string[] scene1;
	public string[] scene2;
	public string[] scene3;
	public string[] scene4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void setText(TextAsset newText) {
		text = newText;
	}

	void splitText(TextAsset fullText) {
		
		scenes = fullText.text.Split('-');

	}
}
