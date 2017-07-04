using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropForTools : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnDragging(){
		RectTransform tr = gameObject.GetComponent<RectTransform> ();
		transform.position=new Vector2(Input.mousePosition.x/*-tr.sizeDelta.x*/,Input.mousePosition.y/*-tr.sizeDelta.y*/);
	}
}
