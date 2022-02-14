using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {


	public float dropTime = 0.5f;
	public int pooledBalls = 20;

	public GameObject ball;
	public Rigidbody rb;


	List<GameObject> balls;

	void Awake() {
		Application.targetFrameRate = 90;
	}


	void Start () {
		balls = new List<GameObject>();

		for (int x = 0; x < pooledBalls; x++) {
			GameObject obj = (GameObject)Instantiate(ball);
			obj.SetActive(false);
			balls.Add(obj);
		}

		InvokeRepeating("ResetBalls", dropTime, dropTime);
	}
	

	void ResetBalls() {
		for (int x = 0; x < balls.Count; x++) {
			if (!balls[x].activeInHierarchy) {
				rb = GetComponent<Rigidbody>();
				balls[x].transform.position = transform.position;

				rb = balls[x].GetComponent<Rigidbody>();
				rb.velocity = new Vector3 (0,0,0);

				balls[x].SetActive(true);
				break;
			}
		}
	}
}
