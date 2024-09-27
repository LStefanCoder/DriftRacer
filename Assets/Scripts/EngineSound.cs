using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSound : MonoBehaviour
{
    //based on https://www.youtube.com/watch?v=FOajUhGLtII

    public AudioSource engineSound;

    public float minPitch = 0.5f;
    public float maxPitch = 2f;

    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        engineSound.pitch = minPitch;
    }

    // Update is called once per frame
    void Update()
    {
        //speed = ;

        if(speed < minPitch)
        {

        }
    }
}
