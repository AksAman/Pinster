using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Pin : MonoBehaviour {

	Rigidbody2D rb2D;
	bool attached;
	public float moveSpeed;
	Transform rotatorParent;
	GameManager gManager;

	void Awake()
	{
		rb2D = GetComponent<Rigidbody2D> ();
		rotatorParent = GameObject.Find ("Rotator").transform;
		gManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		attached = false;
	}

	void Update()
	{
		if(!attached && !gManager.gameOver)
		{
			rb2D.MovePosition (rb2D.position + Vector2.up * moveSpeed);
		}

		if(attached)
		{
			transform.SetParent (rotatorParent);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log (other.tag);
		if(other.tag == "Center" && !gManager.gameOver)
		{
			attached = true;
			gManager.score += 1;
		}

		if(other.tag == "Shots")
		{
			gManager.gameOver = true;
//			Debug.Break ();
		}
	}
}
