using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //based on https://www.youtube.com/watch?v=DU7cgVsU2rM 

    public static SoundManager instance;
    [SerializeField] private AudioSource slidingObject;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlaySlide(AudioClip slidingClip, Transform slidingTransform, float vol)
    {
        //the rotation of the audio source is irrelevant, thus the Quaternion.identity declares a default rotation
        AudioSource slidingSource = Instantiate(slidingObject, slidingTransform.position, Quaternion.identity);

        slidingSource.clip = slidingClip;

        slidingSource.volume = vol;

        slidingSource.Play();

        float clipLength = slidingSource.clip.length;

        //ending the clip and the clip object when it has played
        Destroy(slidingSource.gameObject, clipLength);
    }

}
