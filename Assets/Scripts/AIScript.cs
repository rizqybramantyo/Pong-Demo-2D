using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour {

	public Transform ball;
	public float speedY = 6;
	Rigidbody2D rigid;
	bool isUp;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		int moveDir = (isUp ? 1 : -1);
		if (ball.position.y > transform.position.y) {
			moveDir = 1;
		}

		rigid.velocity = new Vector2 ( 0, speedY * moveDir);

	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name.Contains ("Wall")) {
			isUp = !isUp; 
		}
	}
}
