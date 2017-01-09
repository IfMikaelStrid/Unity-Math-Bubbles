using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Generate : MonoBehaviour {
	//public GameObject bubble;
	//public GameObject clone;
	const float range = 10.0f;
    private float InstantiationTimer = 1f;
	public int i; 
	private float timer = 8f;


    void Start () {
		i = 20; 
    }
	

	void Update () {

		if (i > 0) {
			CreatePrefab ();
		} 
		else {
			timer -= Time.deltaTime;
			if (timer <= 0) {
				SceneManager.LoadScene ("endscreen");
			}
		}
	}

    void CreatePrefab()
    {

        Vector3 randomPos = Random.insideUnitSphere * range;

        InstantiationTimer -= Time.deltaTime;

        

		if(InstantiationTimer <= 0)
		{
            	
			randomPos.z = 0;
		
			GameObject clone = (GameObject) Instantiate (Resources.Load("Sphere"), transform.position + randomPos, Quaternion.identity);

			InstantiationTimer = 3f;
	
			i = i - 1;

		}
    }
}

