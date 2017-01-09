using UnityEngine;
using Tobii.EyeTracking;
using System;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;

/// <summary>
/// Changes the color of the game object's material, when the the game object 
/// is in focus of the user's eye-gaze.
/// </summary>
/// <remarks>
/// Referenced by the Target game objects in the Simple Gaze Selection example scene.
/// </remarks>
[RequireComponent(typeof(GazeAware))]
[RequireComponent(typeof(MeshRenderer))]
public class ChangeColor : MonoBehaviour {

    public Color selectionColor;
 
    private GazeAware       _gazeAwareComponent;
    private MeshRenderer    _meshRenderer;

    private Color           _deselectionColor;
    private Color           _lerpColor;
    private float           _fadeSpeed = 0.1f;

	public static int number;
	public static int counter;
	public bool activate;
    public bool keywordset;

	public static GameObject g;
	public static int answer; 
	public int answer2;
	public static int first_entry;
	public string txt;

    /// <summary>
    /// Set the lerp color
    /// </summary>
    void Start()
    {
        _gazeAwareComponent = GetComponent<GazeAware>();
        _meshRenderer = GetComponent<MeshRenderer>();
        _lerpColor = _meshRenderer.material.color;
        _deselectionColor = Color.white;

		keywordset = true;
		first_entry = 0; 

    }

    /// <summary>
    /// Lerping the color
    /// </summary>
    void Update ()
    {

		if (recognition.activatedestruction == true) { 
			//GameObject.DestroyObject(this.gameObject);
			recognition.activatedestruction = false;
		}

        if (_meshRenderer.material.color != _lerpColor)
        {
            _meshRenderer.material.color = Color.Lerp(_meshRenderer.material.color, _lerpColor, _fadeSpeed);
        }

        // Change the color of the cube
        if (_gazeAwareComponent.HasGazeFocus)
        {
			//print (recognition.activatedestruction);

			first_entry = first_entry + 1; 
            SetLerpColor(selectionColor);

				g = this.gameObject;
				//answer = CreateNumbers.result;
				setKeywordOnce();

			if (first_entry == 1) {
				txt = this.gameObject.GetComponentInChildren<Text> ().text;
				answer = int.Parse (txt.Substring (0, 1));
				answer2 = int.Parse (txt.Substring (4, 1)); 
				answer = answer * answer2; 
				//Debug.Log (answer);
			}
				          
        }
        else
        {
			first_entry = 0; 
            SetLerpColor(_deselectionColor);
			//recognition.StopKeywordRecognizer();
			//Debug.Log (g.GetComponent<CreateNumbers>());
			//KeywordRecognizer k = recognition.keywordRecognizer.Stop();
        }
    }

    private void setKeywordOnce()
    {
		
       // bool repress = recognition.truefalse;
		if(keywordset == true)
        {
			keywordset = false;
			recognition rec = new recognition();
			rec.Start();
        }
    }

    /// <summary>
    /// Update the color, which should used for the lerping
    /// </summary>
    /// <param name="lerpColor"></param>
    public void SetLerpColor(Color lerpColor)
    {
        this._lerpColor = lerpColor;
    }
    /*
	public void activatevoice(){
		bool truefalse = recognition();
		Debug.Log (truefalse);
		if (truefalse == true) {
			//Object.DestroyObject (this.gameObject);
			counter = counter + 1; 

			Debug.Log (counter);
		}
		activate = false; 

	}*/


}
