using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextGUI : MonoBehaviour {
    public Text mathText;

    string mathproblem;
	// Use this for initialization
	void Start () {
        setText("2 + 2*3 = ?");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void setText(string mathproblemText) {
        mathText.text = mathproblemText;
    }
}
