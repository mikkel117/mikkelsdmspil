using UnityEngine;
using System.Collections;

public class killzone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D o) {

		if (o.tag == "Player") {
			Destroy (o.gameObject);
		}
	}

	void OnCollisionEnter2D (Collision2D o) {

		if (o.gameObject.tag == "Player") {
			Destroy (o.gameObject);
		}
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel (Application.loadedLevel);
		}

		if (Input.GetKeyDown (KeyCode.P)) {
			Application.LoadLevel (0);
		}
	}
}
