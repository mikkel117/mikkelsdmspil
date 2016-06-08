using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {

	public int Liv = 1;

	public GameObject DestroyThis;

	public float InviTime = 0.5f;

	public bool CanBecomeInvincible; 

	private bool inviRunning = false;

	public void ChangeHealth(int change)
	{
		if (inviRunning == false) {
			Liv += change;
		}

		if (Liv <= 0) {
			Destroy (DestroyThis);
		} else if(CanBecomeInvincible && inviRunning == false) {

			StartCoroutine (Invi ());
		}




	}

	IEnumerator Invi()
	{
		inviRunning = true;

		yield return new WaitForSeconds (InviTime);

		inviRunning = false;


	}
}
