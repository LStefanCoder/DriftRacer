using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    /*public void LoadRace()
    {
        SceneManager.LoadScene('Level1');
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene('OptionsMenu');
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene('Credits');
    }*/

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
