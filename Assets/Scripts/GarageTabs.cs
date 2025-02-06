using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageTabs : MonoBehaviour
{
    public GameObject spoilersTab;
    public GameObject colorTab;
    public GameObject instructionText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //the next three functions activate or deactivate 

    public void ActivateSpoilersMenu()
    {
        spoilersTab.SetActive(true);
        colorTab.SetActive(false);
        //removing the instruction
        instructionText.SetActive(false);
    }

    public void ActivateColorsMenu()
    {
        spoilersTab.SetActive(false);
        colorTab.SetActive(true);
        instructionText.SetActive(false);
    }

}
