using UnityEngine;
using System.Collections;

public class VidaNave : MonoBehaviour {

	public int vidaNave = 1;

	void Start() {

	}

	void OnTriggerEnter2D() {
		vidaNave--;
	}

	void Update() {
		if(vidaNave <= 0) {
			Die();
		}
	}

	void Die() {
		Destroy(gameObject);
	}

}
