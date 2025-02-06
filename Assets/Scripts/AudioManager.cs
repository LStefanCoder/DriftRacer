using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    //based on https://www.youtube.com/watch?v=_m6nTQOMFl0

    [SerializeField] Slider mainSlider;
    [SerializeField] AudioMixer mixer;

    // Start is called before the first frame update
    private void Start()
    {
        SetVolume(PlayerPrefs.GetFloat("SaveMasterVolume", 100));
    }

    public void SetVolume(float val)
    {
        if(val < 1)
        {
            val = 0.001f;
        }

        RefreshSlider(val);
        PlayerPrefs.SetFloat("SavedMasterVolume", val);
        mixer.SetFloat("MasterVolume", Mathf.Log10(val / 100) * 20f);
    }
    
    public void SetVolumeFromSlider()
    {
        SetVolume(mainSlider.value);
    }

    public void RefreshSlider(float val)
    {
        mainSlider.value = val;
    }
}
