using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
