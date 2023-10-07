using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisualButtons : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audio;
    public bool canInteract;
    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public void Pressed()
    {
        if(canInteract)
        audio.Play();
    }

    public void SetBool(bool bo)
    {
        canInteract = bo;
    }
}
