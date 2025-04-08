using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class HelpMenu : MonoBehaviour
{
    public GameObject escapeMenuCanvas;
    public GameObject helpMenuCanvas;
    public GameObject mainCanvas;

    private AudioSource[] allAudioSources;
    private AudioSource engineSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //activate the help menu if the F1 key is pressed
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (helpMenuCanvas.activeSelf == false) //&& escapeMenuCanvas.activeSelf == false)
            {
                helpMenuCanvas.SetActive(true);
                mainCanvas.SetActive(false);
                StopAllAudio();
                //freezes the gameplay
                Time.timeScale = 0;
            }

            else
            {
                helpMenuCanvas.SetActive(false);
                mainCanvas.SetActive(true);
                StartAllAudio();
                //resumes the gameplay
                Time.timeScale = 1;
            }
        }

        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (escapeMenuCanvas.activeSelf == false)
            {
                helpMenuCanvas.SetActive(false);
                mainCanvas.SetActive(true);
                StartAllAudio();
                //resumes the gameplay
                Time.timeScale = 1;
            }
        }*/
    }

    //taken from https://discussions.unity.com/t/how-to-stop-all-audio/32919/4
    private void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }

    private void StartAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            if (audioS.name == "EngineSource")
            {
                audioS.Play();
            }
        }
    }
}
