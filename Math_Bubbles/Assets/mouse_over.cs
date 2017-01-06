using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mouse_over : MonoBehaviour {

    void OnMouseOver() //Change to voicecontrol
    {
		Object.DestroyObject(this.gameObject);

		//SceneManager.LoadScene("math");
    }

}
