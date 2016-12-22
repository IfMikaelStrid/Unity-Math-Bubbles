using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour
{
bool Pause;
    void Start()
    {
        Pause = false;
    }
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pause = !Pause;
        }
            if (Pause)
            {
                Time.timeScale = 0;
            }
            else if(!Pause)
            {
                Time.timeScale = 1;
            }
        
    }
}
/*
void Update()
{
    if (Input.GetKeyDown(KeyCode.P))
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}*/