using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {


	public GameObject Panel;
	public UnityEngine.UI.Text Text;
	public Score s;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {


			Panel.SetActive (true);
			Text.text = "Din tid: " + (int)s.Tiden;

			gameObject.SetActive (false);

		}
	
	}
}
