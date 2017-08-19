using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
public int movementSpeed = 1;
public static bool canMove;
public Animator anim;

	void Start ()
	{
		//get the animator object at the beginning so you can use the same in update
		anim = GetComponent<Animator>();
	}
	// Update is called once per frame
	void Update ()
	{

		if (!canMove) {
			return;
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
		transform.Translate ((Vector3.up * movementSpeed * Time.deltaTime));
			//setting the animation state to 1
			anim.SetInteger("State", 1);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
		transform.Translate ((Vector3.down * movementSpeed * Time.deltaTime));
			anim.SetInteger("State", 0);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
		transform.Translate ((Vector3.right * movementSpeed * Time.deltaTime));
			anim.SetInteger("State", 2);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
		transform.Translate ((Vector3.left * movementSpeed * Time.deltaTime));
			anim.SetInteger("State", 3);
		}
	}
}
