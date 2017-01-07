using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

	void Start(){
		Button btn = (Button) gameObject.GetComponent("Button");
		Debug.Log (btn);
		btn.onClick.AddListener (TaskOnCLick);
	}

	void TaskOnCLick(){
		SceneManager.LoadScene("bubbles");

	}

}
