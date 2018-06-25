using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

	public float speed;
	private float x;
	private float z;


	Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = this.gameObject.GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		x = Input.GetAxis ("Horizontal");

		if (x == 0) {
			rigidbody.velocity =new Vector3(0,rigidbody.velocity.y,rigidbody.velocity.z);
		}
		if (rigidbody.velocity.z<10) {
			rigidbody.AddForce (new Vector3(x * speed, 0, speed),ForceMode.VelocityChange);
		} else {
			rigidbody.AddForce (new Vector3(x * speed, 0, 0),ForceMode.VelocityChange);
		}

	
	}

	void OnCollisionEnter(Collision c){
	if (c.gameObject.tag == "GameoverCube") {
			SceneManager.LoadScene ("gameover");
		} else if(c.gameObject.tag=="ClearCube"){
			SceneManager.LoadScene ("clear");
		}
	}
	/*
	void OnTriggerEnter(Collider co){			GUI.(new
		}
		
}*/
}
