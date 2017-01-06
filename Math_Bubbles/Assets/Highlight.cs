using UnityEngine;
using Tobii.EyeTracking;

/// <summary>
/// Changes the color of the game object's material, when the the game object 
/// is in focus of the user's eye-gaze.
/// </summary>
/// <remarks>
/// Referenced by the Target game objects in the Simple Gaze Selection example scene.
/// </remarks>
[RequireComponent(typeof(GazeAware))]
//[RequireComponent(typeof(MeshRenderer))]
public class Highlight : MonoBehaviour {

	private GazeAware       _gazeAwareComponent;


	UnityEngine.UI.Button btn;

	void Start()
	{
		_gazeAwareComponent = GetComponent<GazeAware>();
	}
		
	void Update ()
	{

		// Change the color of the cube
		if (_gazeAwareComponent.HasGazeFocus)
		{
			btn.Select();
		}
		else
		{
			//btn.Select();
		}
	}
		
}
