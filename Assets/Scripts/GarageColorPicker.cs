using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class GarageColorPicker : MonoBehaviour
{
    public FlexibleColorPicker picker;
    public Material materialToChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        materialToChange.color = picker.color;
    }
}
