using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class healthinterface : MonoBehaviour {
	public Image heart1, heart2, heart3;
	public Sprite full, empty;
	public health playerhealth;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (playerhealth.Liv == 3) {
			heart1.sprite = full;
			heart2.sprite = full;
			heart3.sprite = full;
		}
		if (playerhealth.Liv == 2) {
			heart1.sprite = empty;
			heart2.sprite = full;
			heart3.sprite = full;
		}
		if (playerhealth.Liv == 1) {
			heart1.sprite = empty;
			heart2.sprite = empty;
			heart3.sprite = full;
		}
		if (playerhealth.Liv == 0) {
			heart1.sprite = empty;
			heart2.sprite = empty;
			heart3.sprite = empty;
		}
	}
}
