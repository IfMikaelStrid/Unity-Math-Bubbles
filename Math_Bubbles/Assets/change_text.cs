using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_text : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text>().text = "Your score was: " + recognition.count + " / 20";
		Debug.Log ("Count : " + recognition.count);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
