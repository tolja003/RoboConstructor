using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporaryMovementScript : MonoBehaviour {
	public float Speed=1.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("right")) {
			transform.position += new Vector3 (Time.deltaTime*Speed,0,0);
		}
		if (Input.GetKey ("left")) {
			transform.position -= new Vector3 (Time.deltaTime*Speed,0,0);
		}
		if (Input.GetKey ("up")) {
			
		}
	}
}
