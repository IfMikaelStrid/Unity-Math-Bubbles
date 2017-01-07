using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateNumbers : MonoBehaviour {

	public int num1;
	public int num2;
	public int result;

	// Use this for initialization
	void Start () {
		num1 = Random.Range (3, 9);
		num2 = Random.Range (3, 8);
		result = num1 * num2;

		this.gameObject.GetComponentInChildren<Text> ().text = num1 + " + " + num2;
		string t = this.gameObject.GetComponentInChildren<Text>().text;
		Debug.Log (t);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
