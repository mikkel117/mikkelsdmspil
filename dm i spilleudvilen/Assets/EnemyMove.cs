using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {


	public Vector2 Direction1, Direction2;

	private Vector2 StartPos;

	public float movementTime = 1;
	public bool OneWay = false;

	public float Speed = 100;


	// Use this for initialization
	void Start () 
	{
		

			StartCoroutine (SideWalk ());


		StartCoroutine (TrueOrFalse ());
	}

	IEnumerator TrueOrFalse()
	{
		while (true) {

			yield return new WaitForSeconds (movementTime);
			if (OneWay) {
				OneWay = false;
				transform.localScale = new Vector3 (transform.localScale.x*-1, transform.localScale.y, transform.localScale.z);
			} else {
				OneWay = true;
				transform.localScale = new Vector3 (transform.localScale.x*-1, transform.localScale.y, transform.localScale.z);
			}
		
		}
	}


	bool GoTowardsPoint1;

	IEnumerator SideWalk()
	{




		while (true) 
		{

			if (OneWay) 
			{
				transform.Translate (Direction1 * Speed * Time.deltaTime);


			} 
			else 
			{
				transform.Translate (Direction2 * Speed * Time.deltaTime);

			}

			yield return null;

		}
	}


	
	// Update is called once per frame
	void Update () {

	
	
	}
}
