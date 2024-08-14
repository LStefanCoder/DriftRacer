using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static GlobalVariables;

//public static var currentScene;

public class CallingStartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GlobalVariables.currentScene = SceneManager.GetActiveScene();

        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene("HelpMenu");
        }
    }
}
