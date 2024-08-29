using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject garage;

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
}
