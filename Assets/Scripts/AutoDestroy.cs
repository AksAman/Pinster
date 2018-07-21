using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {

	Rigidbody2D rb2D;
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
//		Destroy(gameObject, 5);
	}

	void Update()
	{
		
	}
}
