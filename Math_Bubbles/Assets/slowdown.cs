using UnityEngine;
using System.Collections;

public class slowdown : MonoBehaviour
{
    bool Pause;
    void Start()
    {
        Pause = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause = !Pause;
            if (Pause)
            {
                Application.targetFrameRate = Application.targetFrameRate / 10;
            }
            else
            {
                Application.targetFrameRate = Application.targetFrameRate * 10;

            }
        }
        
 /*           if (Time.timeScale == 1.0F)
                Time.timeScale = 0.7F;
            else
                Time.timeScale = 1.0F;
            Time.fixedDeltaTime = 0.02F * Time.timeScale;*/
        
    }
}