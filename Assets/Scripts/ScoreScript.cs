using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour {

	public Text ScoreCount;
	public GameObject Ball;
	private int Player_Score = 0;
	private int Player_Score_2 = 0;
	// Use this for initialization
	void Start () {
		Ball = GameObject.Find ("Ball");
	}
	
	// Update is called once per frame
	void Update () {
		
		}
		//print (Player_Score + "," + Player_Score_2);

}
