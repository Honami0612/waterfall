using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter : MonoBehaviour {
	public GameObject image;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider co){
		Debug.Log ("Enter");
		image.gameObject.GetComponent<imagechange> ().Change ();
	}
}
