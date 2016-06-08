using UnityEngine;
using System.Collections;

public class gotolevel : MonoBehaviour {

	public string SceneName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.S)) {

			UnityEngine.SceneManagement.SceneManager.LoadScene (SceneName);

		}
	}
}
