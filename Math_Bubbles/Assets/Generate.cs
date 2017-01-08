using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Generate : MonoBehaviour {
	//public GameObject bubble;
	//public GameObject clone;
	const float range = 10.0f;
    private float InstantiationTimer = 1f;
	public int i; 


    void Start () {
		i = 20; 
		InstantiationTimer = 3f;
    }
	

	void Update () {

		if (i > 0) {
			CreatePrefab ();
		} 
		else {
			SceneManager.LoadScene("endscreen");
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

