using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class return_main : MonoBehaviour {

	//void Start(){
	//	Button btn = (Button) gameObject.GetComponent("Button");
	//	Debug.Log (btn);
	//	btn.onClick.AddListener (TaskOnCLick);
	//}

	//void TaskOnCLick(){
	//	SceneManager.LoadScene("startscreen");

	//}

	void OnMouseDown() //Change to voicecontrol
	{
		SceneManager.LoadScene("startscreen");
	}


}
