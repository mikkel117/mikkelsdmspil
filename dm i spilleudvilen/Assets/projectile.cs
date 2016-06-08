using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {

	public Rigidbody2D RB;
	public float Speed;
	public Vector2 Direction;

	// Use this for initialization
	void Start ()
	{
		RB.velocity = Direction * Speed;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
