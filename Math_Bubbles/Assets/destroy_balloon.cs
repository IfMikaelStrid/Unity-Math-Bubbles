using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class destroy_balloon : MonoBehaviour {

	void Start() 

	{
		Object.DestroyObject(this.gameObject);
	}
}


		

