using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    	public ParticleSystem pSystem;
	public GameManager gameManager;

	void Start() {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}


    	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag("Throwable")) {            
			gameManager.score++;
		}
        }	    
}
