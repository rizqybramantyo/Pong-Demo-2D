using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BolaScript : MonoBehaviour {
	public float speed;
	public int score = 0;
	public int score1 = 0;
	public Text textScore;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = 
			new Vector2 (speed, speed);
	}
	//void OnollisionEnter2D(on)
	// Update is called once per frame
	void Update(){
		
	}
		
	void OnTriggerEnter2D(Collider2D col){
		//Melihat di console nama yang bertabrakan
		//Debug.Log (col.gameObject.name);

		if (col.gameObject.name == "Sensor1") {
			score1 += 1;
			textScore.text = score.ToString () + " - " + score1.ToString () ;
			transform.position = new Vector2 (0, 0);
			//Penambahan score
		}
		if (col.gameObject.name == "Sensor") {
			score += 1;
			textScore.text = score.ToString () + " - " + score1.ToString () ;
			//Penambahan score
			transform.position = new Vector2 (0, 0);
		}
	}



 }
