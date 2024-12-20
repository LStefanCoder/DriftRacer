using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageSelectSpoiler : MonoBehaviour
{
    public GameObject noSpoiler;
    public GameObject Spoiler1;
    public GameObject Spoiler2;

    //the global variable maintaining which state the car is in:
    //no spoiler, first spoiler, second spoiler
    public static int spoilerStatus;


    // Start is called before the first frame update
    void Start()
    {
        //when the game is first started, the car has no spoiler
        spoilerStatus = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateNoSpoiler()
    {
        spoilerStatus = 0;
    }

    public void ActivateSpoilerOne()
    {
        spoilerStatus = 1;
    }

    public void ActivateSpoilerTwo()
    {
        spoilerStatus = 2;
    }
}
