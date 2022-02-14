	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    	public GameManager gameManager;
	public int oldScore;
	private Text fullText;

	void Start () {
	        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();	

		fullText = GetComponentInChildren<Text>();
		fullText.text = " Score: " + "\n" + gameManager.score.ToString();
	}

	void Update() {
		if (gameManager.score > oldScore) {
			ScoreUpdate();
		}
	}

	void ScoreUpdate() {
		oldScore = gameManager.score;
		fullText.text = " Score: " + "\n" + gameManager.score.ToString();
	}
}
