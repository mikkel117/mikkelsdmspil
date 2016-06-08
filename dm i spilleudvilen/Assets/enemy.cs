using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	public int AttackDamage; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D o) {

		if (o.gameObject.tag == "Player") 
		{

			o.gameObject.GetComponent<health> ().ChangeHealth (AttackDamage);
		}

		if (o.gameObject.tag == "skyd") 
		{

			gameObject.GetComponent<health> ().ChangeHealth (-1);
			Destroy (o.gameObject);
		}
	
	}
}
