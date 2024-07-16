using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OptionsMenu_quality : MonoBehaviour
{
    //based on https://www.youtube.com/watch?v=JJ8S_RqHt6o
    public TMP_Dropdown qualityDropdown;

    public void ChangeQuality()
    {
        if (qualityDropdown.value == "Low")
        {
            QualitySettings.SetQualityLevel("Performant"); 
        }

        if (qualityDropdown.value == "Mid")
        {
            QualitySettings.SetQualityLevel("Balanced");
        }

        if (qualityDropdown.value == "High")
        {
            QualitySettings.SetQualityLevel("High Fidelity");
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
