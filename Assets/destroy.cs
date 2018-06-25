using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	public GameObject image;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnTriggerEnter(Collider c){
		Debug.Log("destroy");
		image.gameObject.SetActive (false);	
	}
}
