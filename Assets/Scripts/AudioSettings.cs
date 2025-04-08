using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    //based on https://www.youtube.com/watch?v=_m6nTQOMFl0

    [SerializeField] Slider slider;
    [SerializeField] AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
        //in the PlayerPrefs, preference values can be saved
        SetVolume(PlayerPrefs.GetFloat("SavedMasterVolume", 100));
    }

    public void SetVolume(float val)
    {
        if(val < 1)
        {
            val = .001f;
        }

        RefreshSlider(val);
        PlayerPrefs.SetFloat("SavedMasterVolume", val);
        mixer.SetFloat("MasterVolume", Mathf.Log10(val / 100) * 20f);
    }

    public void SetVolumeFromSlider()
    {
        SetVolume(slider.value);
    }

    public void RefreshSlider(float val)
    {
        slider.value = val;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
