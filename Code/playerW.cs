using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerW : MonoBehaviour {
	
	void Update () {
		if (gameObject.transform.position.y < -7){
			Die();
		}
	}

	void Die (){
		SceneManager.LoadScene ("mario_1");
	}
}
