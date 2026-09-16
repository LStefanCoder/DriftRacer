using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSpoiler : MonoBehaviour
{
    public GameObject Spoiler1;
    public GameObject Spoiler2;

    // Start is called before the first frame update
    void Start()
    {
        Spoiler1.SetActive(false);
        Spoiler2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GarageSelectSpoiler.spoilerStatus == 0)
        {
            Spoiler1.SetActive(false);
            Spoiler2.SetActive(false);
        }

        if(GarageSelectSpoiler.spoilerStatus == 1)
        {
            Spoiler1.SetActive(true);
            Spoiler2.SetActive(false);
        }

        if(GarageSelectSpoiler.spoilerStatus == 2)
        {
            Spoiler1.SetActive(false);
            Spoiler2.SetActive(true);
        }
    }
}
