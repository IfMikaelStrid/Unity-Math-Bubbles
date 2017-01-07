using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InstructionScreen : MonoBehaviour {

	void Start(){
		Button btn = (Button) gameObject.GetComponent("Button");
		btn.onClick.AddListener (TaskOnCLick);
	}

	void TaskOnCLick(){
		SceneManager.LoadScene("instructionscreen");

	}

}
