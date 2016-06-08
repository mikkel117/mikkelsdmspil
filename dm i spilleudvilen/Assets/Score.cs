using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public UnityEngine.UI.Text TidTekst;

	public float Tiden;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Tiden += Time.deltaTime;
		TidTekst.text = "Din tid: " + (int)Tiden;
	
	}
}
