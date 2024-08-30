using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageTabs : MonoBehaviour
{
    public GameObject carTab;
    public GameObject colorTab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //the next three functions activate or deactivate 

    public void ActivateCarsMenu()
    {
        carTab.SetActive(true);
        colorTab.SetActive(false);
    }

    public void ActivateColorsMenu()
    {
        carTab.SetActive(false);
        colorTab.SetActive(true);
    }

}
