using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imagechange : MonoBehaviour {

	public Sprite[] sprite;
	private int count;
	private Image image;

	void Start(){
		image = gameObject.GetComponent<Image> ();
		gameObject.SetActive (false);
	}

	public void Change(){
		gameObject.SetActive (true);
		Debug.Log ("count"+count);
		image.sprite = sprite [count];
		count++;
	
	}
}
