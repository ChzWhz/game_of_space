using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTextAtLine : MonoBehaviour {
	public TextAsset theText;
	public int startLine;
	public int endLine;
	public bool destroyWhenActivated;
	public WalkAround rumba;

	public textBoxManager theTextBox;
	// Use this for initialization
	void Start () {
		theTextBox = FindObjectOfType<textBoxManager>();
		rumba = FindObjectOfType<WalkAround>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!(theTextBox.isActive)) {
			rumba.allowMove();
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name == "Player") {
			theTextBox.reloadScript (theText);
			theTextBox.currentLine = startLine;
			theTextBox.endAtLine = endLine;
			theTextBox.enableTextBox ();
		    rumba.prohibitMove();

			if (destroyWhenActivated) {
				Destroy(gameObject);
			}
		}
	}
}
