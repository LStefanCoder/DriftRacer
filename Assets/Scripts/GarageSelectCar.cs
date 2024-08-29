using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageSelectCar : MonoBehaviour
{
    public GameObject leftArrow;
    public GameObject rightArrow;

    public GameObject buyButton;

    static int currentCar;
    static int selectedCar;
    static int currentTab;

    // Start is called before the first frame update
    void Start()
    {
        //at the start of the game, the BMW becomes the default car
        selectedCar = 0;
        currentCar = 0;

        //greying out the left arrow button when the there is no more windows to the right
    }

    // Update is called once per frame
    void Update()
    {
        //if (selectedCar == )
    }
}
