using UnityEngine;
using System.Collections;

public class Skyde : MonoBehaviour {

	public GameObject skyd;
	public GameObject SpawnPoint;

	private float counter;

	// Use this for initialization
	void Start() {
	
	}
	
	// Update is called once per frame
	void Update () {


		counter += Time.deltaTime;

		if (Input.GetKey (KeyCode.K) && counter > 0.5) 
		{
			//hvis k bliver trykket på, såsker dette
			GameObject spawn = Instantiate(skyd) as GameObject;
			spawn.transform.position = SpawnPoint.transform.position;

			Destroy (spawn,1);

			if (spawn.transform.position.x < this.gameObject.transform.position.x) 
			{
				spawn.GetComponent<projectile> ().Direction = Vector2.left;
			} 
			else 
			{
				spawn.GetComponent<projectile> ().Direction = Vector2.right;
			}

			counter = 0;
		}



	
	}
}

