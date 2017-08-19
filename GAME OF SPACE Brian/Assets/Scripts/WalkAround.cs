using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAround : MonoBehaviour {
	public int movementSpeed;
	public Collider2D obstacle;
	public static bool canMove;
	public float timeToChangeDirection;
	public int random;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (canMove) {
			movementSpeed = 10;
			timeToChangeDirection -= Time.deltaTime;
			random = (int)(Random.Range (0, 3));
			switch (random) {
			case 0:
				transform.Translate (Vector3.up * movementSpeed);
				break;
			case 1:
				transform.Translate (Vector3.down * movementSpeed);
				break;
			case 2:
				transform.Translate (Vector3.right * movementSpeed);
				break;
			case 3:
				transform.Translate (Vector3.left * movementSpeed);
				break;
			}
			if (timeToChangeDirection <= 0) {
			
				changeDirection ();
		
			}
		} else {
			movementSpeed = 0;
		}

		}
	

	void changeDirection() {
	float angle = Random.Range(0f, 360f);
	Quaternion quat = Quaternion.AngleAxis(angle, Vector3.forward);
	Vector3 newUp = quat * Vector3.up;
	newUp.z = 0;
	newUp.Normalize();
	transform.up = newUp;
	timeToChangeDirection = 5f;
	}

	public void allowMove() {
		canMove = true;
	}

	public void prohibitMove() {
		canMove = false;
	}
}
