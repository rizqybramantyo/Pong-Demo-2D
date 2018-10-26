using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D> ().transform.Translate (0,0.1f, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D> ().transform.Translate (0,-0.1f, 0);
		}


	}
}
