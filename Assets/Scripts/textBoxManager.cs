using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Networking;

public class textBoxManager : MonoBehaviour {

public GameObject Panel;

public Text theText;

public TextAsset textFile;
public string[] textLines;

public bool isActive;

public int currentLine;
public int endAtLine;

//public bool stopMovement;


	// Use this for initialization
	void Start ()
	{
		//player = FindObjectOfType<PlayerController> ();
		if (textFile != null) {
		//split into lines at new line character
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0) {
		//set end line of text SO IT KNOWS WHEN TO STOP
			endAtLine = textLines.Length - 1;
		}

		if (isActive) {
			//TURN TEXT BOX ON
			enableTextBox ();
		} else {
			//TURN TEXT BOX OFF
			disableTextBox();
		}
	}

	void Update ()
	{

		if (!isActive) {
			return;
		}

		theText.text = textLines [currentLine];
		if (Input.GetKeyDown (KeyCode.Return)) {
			currentLine += 1;
		}

		if (currentLine > endAtLine) {
			disableTextBox ();
		}


	}


	public void enableTextBox ()
	{
		Panel.SetActive (true);
		isActive = true;
		PlayerController.canMove = false;
	}

	public void disableTextBox() {
		Panel.SetActive(false);
		isActive = false;
		PlayerController.canMove = true;
	}

	public bool isActivated() {
		return isActive;
	}

	public void reloadScript (TextAsset newText)
	{
		if (newText != null) {
			textLines = new string[1];
			textLines = (newText.text.Split ('\n'));
		}
	}

}
