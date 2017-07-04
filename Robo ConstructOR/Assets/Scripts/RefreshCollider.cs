using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefreshCollider : MonoBehaviour {
	
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
		Destroy (GetComponent<PolygonCollider2D> ());
		gameObject.AddComponent<PolygonCollider2D>();

	}
}
