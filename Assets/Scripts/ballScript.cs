using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {

	void OnEnable() {
		Invoke("ResetBall", 10);
	}
	
	void OnDisable() {
		CancelInvoke();
	}

	void ResetBall() {
		gameObject.SetActive(false);
	}
}
