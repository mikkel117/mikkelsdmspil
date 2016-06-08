using UnityEngine;
using System.Collections;

public class HealthDamage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerStay2D (Collider2D other)
	{

		if (other.tag == "Player") 
		{

			other.GetComponent<health> ().ChangeHealth (-1);


		}
	
	}
}
