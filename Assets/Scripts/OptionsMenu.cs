using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    //based on https://www.youtube.com/watch?v=JJ8S_RqHt6o
    public TMP_Dropdown qualityDropdown;
    public Slider mainVolume;
    public Slider musicVolume;

    public void ChangeQuality()
    {
        if (qualityDropdown.value == 0)
        {
            QualitySettings.SetQualityLevel(0); 
        }

        if (qualityDropdown.value == 1)
        {
            QualitySettings.SetQualityLevel(1);
        }

        if (qualityDropdown.value == 2)
        {
            QualitySettings.SetQualityLevel(2);
        }

    }

    public void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //based on https://discussions.unity.com/t/controlling-master-volume-with-one-slider/163184
        AudioListener.volume = mainVolume.value;
    }

    //music volume see here: https://www.youtube.com/watch?v=G-JUp8AMEx0
}
