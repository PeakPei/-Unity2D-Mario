using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player_Score : MonoBehaviour {

	public float timeLeft = 120;
	public int playerScore = 0;
	public GameObject timeLeftUI;
	public GameObject playerScoreUI;
	
	void Update () {
		timeLeft -= Time.deltaTime;
		timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
		playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
		if (timeLeft < 0.1f){
			SceneManager.LoadScene ("mario_1");
		}
	}
	void OnTriggerEnter2D (Collider2D trig){
		if(trig.gameObject.name == "EndLevel"){
			CountScore();
		}
		if(trig.gameObject.name == "points" || trig.gameObject.name == "points (1)" || trig.gameObject.name == "points (2)" || trig.gameObject.name == "mario3_0 (4)"){
			playerScore += 10;
			Destroy (trig.gameObject);
		}
		if(trig.gameObject.name == "mario3_0" || trig.gameObject.name == "mario3_0 (1)"){
			playerScore += 10;
			Destroy (trig.gameObject);
		}
		/*if(trig.gameObject.name == "points (3)"){
			Destroy (gameObject);
		}*/
	}
	void CountScore (){
		playerScore = playerScore + (int)(timeLeft * 10);
		
	}
}
