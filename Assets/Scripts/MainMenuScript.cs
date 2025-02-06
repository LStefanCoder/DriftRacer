using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject garage;
    public GameObject carModel;

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Garage()
    {
        garage.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Main()
    {
        mainMenu.SetActive(true);
        garage.SetActive(false);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    //rotating the car model with the arrow keys
    public void Update()
    {
        //only rotate the car if the user is in the garage
        if(garage.activeInHierarchy == true)
        {
            if(Input.GetKey("left"))
            {
                carModel.transform.Rotate(0f, 2f, 0f);
            }

            if (Input.GetKey("right"))
            {
                carModel.transform.Rotate(0f, -2f, 0f);
            }
        }
    }
}
