using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class EscapeMenu : MonoBehaviour
{
    public GameObject escapeMenuCanvas;
    public GameObject helpMenuCanvas;

    private AudioSource[] allAudioSources;
    private AudioSource engineSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (helpMenuCanvas.activeSelf == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (escapeMenuCanvas.activeSelf == false)
                {
                    escapeMenuCanvas.SetActive(true);
                    StopAllAudio();
                    //freezes the gameplay
                    Time.timeScale = 0;
                }

                else if (escapeMenuCanvas.activeSelf == true)
                {
                    escapeMenuCanvas.SetActive(false);
                    StartAllAudio();
                    //resumes the gameplay
                    Time.timeScale = 1;
                }
            }
        }
        
    }

    //the next three functions handle the three buttons in the escape menu



    public void Quit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }
    
    public void Resume()
    {
        escapeMenuCanvas.SetActive(false);
        //resumes the gameplay
        Time.timeScale = 1;
    }

    public void Help()
    {
        escapeMenuCanvas.SetActive(false);
        helpMenuCanvas.SetActive(true);
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
