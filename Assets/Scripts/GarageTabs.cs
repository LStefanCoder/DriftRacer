using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageTabs : MonoBehaviour
{
    public GameObject elementsTab;
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
        elementsTab.SetActive(true);
        colorTab.SetActive(false);
    }

    public void ActivateColorsMenu()
    {
        elementsTab.SetActive(false);
        colorTab.SetActive(true);
    }

}
