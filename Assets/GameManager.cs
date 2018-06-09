using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int score;
	public Text scoreText;
	public Text gameOverText;

	public Text goodLuckText;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > 1) {
			goodLuckText.enabled = false;
		}
		
		scoreText.text = "SCORE: " + score;
		
		if (Time.time > 18) {
			GameObject.Destroy(GameObject.Find("Object spawner"));
		}

		if (Time.time > 20) {
			gameOverText.enabled = true;
		}
	}
}
