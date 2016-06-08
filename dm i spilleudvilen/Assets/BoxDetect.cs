using UnityEngine;
using System.Collections;

public class BoxDetect : MonoBehaviour {


	public Score scoreScript;
	public float TimeReduce = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D detjegramte) {

		if (detjegramte.gameObject.name == "TimeReduceByBox") {

			scoreScript.Tiden -= TimeReduce;
			Destroy (gameObject);
		}
	
	}
}
