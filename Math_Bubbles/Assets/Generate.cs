using UnityEngine;
using System.Collections;


public class Generate : MonoBehaviour {
    public GameObject bubble;
    const float range = 10.0f;
    private float InstantiationTimer = 1f;

    void Start () {

    }
	

	void Update () {
        CreatePrefab();

    }

    void CreatePrefab()
    {

        Vector3 randomPos = Random.insideUnitSphere * range;

        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            randomPos.z = 0;
            Instantiate(bubble, transform.position + randomPos, Quaternion.identity);
            InstantiationTimer = 2f;
        }
    }
}

