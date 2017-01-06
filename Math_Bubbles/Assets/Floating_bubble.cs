using UnityEngine;
using System.Collections;

public class Floating_bubble : MonoBehaviour {
    public float amplitude;         //Set in Inspector 
    public float speed;
    public float rise_speed;        //Set in Inspector 
    public float scale;             //Set in Inspector 
    private float tempVal;
    private Vector3 tempPos;
    public GameObject particle;
    bool pause;
    // Use this for initialization
    void Start () {
        pause = false;
        tempPos.y = -5;
        tempVal = transform.position.x;
        
        speed = Random.Range(0.0f,0.0f);
        rise_speed = Random.Range(0.005f, 0.05f);
        amplitude = Random.Range(0.0f,1.0f);
        scale = Random.Range(0.0f, 0.5f);
        transform.localScale += new Vector3(scale, scale, 0);
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pause = !pause;
        }
        if (pause) {
            Time.timeScale = 0;
            transform.position = tempPos;
        }
        else {
            Time.timeScale = 1;
            tempPos.y = tempPos.y + rise_speed;
            tempPos.x = tempVal + amplitude * Mathf.Sin(speed * Time.time);
            transform.position = tempPos;
        }
    }
}
