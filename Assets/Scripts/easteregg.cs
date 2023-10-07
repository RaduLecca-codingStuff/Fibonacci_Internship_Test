using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class easteregg : MonoBehaviour
{
    AudioSource spoop;
    bool process=true;
    bool prevused=false;
    System.Random random;
    // Start is called before the first frame update
    void Awake()
    {
        spoop = GetComponent<AudioSource>();
        random = new System.Random();
    }
    IEnumerator sound(){
        process = false;
        int nr;
            yield return new WaitForSeconds(1);
        nr=random.Next(1,40);
        yield return new WaitForSeconds(2);
        if (nr == 16 && !prevused)
        {
            spoop.Play();
            prevused = true;
        }
        else
            prevused = false;
        yield return new WaitForSeconds(3);
        process = true;
        }
    // Update is called once per frame
    void Update()
    {
        if (process)
            StartCoroutine(sound());

    }
}
