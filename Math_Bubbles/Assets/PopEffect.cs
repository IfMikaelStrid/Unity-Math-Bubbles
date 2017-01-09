using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopEffect : MonoBehaviour {
    public AudioClip pop = new AudioClip();
    AudioSource mySound = new AudioSource();
    private bool popBool;
    public void Start()
    {
        popBool = true;
        PopSound();
    }
    public void PopSound()
    {
        if (popBool)
        {
            mySound = GetComponent<AudioSource>();
            mySound.PlayOneShot(pop, 0.8f);
            popBool = false;
        }

    }
}

