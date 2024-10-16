using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EscapeMenu : MonoBehaviour
{
    public GameObject escapeMenuCanvas;
    public GameObject helpMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (escapeMenuCanvas.activeSelf == false)
            {
                escapeMenuCanvas.SetActive(true);
                //freezes the gameplay
                Time.timeScale = 0;
            }

            else
            {
                escapeMenuCanvas.SetActive(false);
                //resumes the gameplay
                Time.timeScale = 1;
            }
        }
    }

    //the next three functions handle the three buttons in the escape menu



    public void Quit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }

    public void Resume()
    {
        escapeMenuCanvas.SetActive(false);
        //resumes the gameplay
        Time.timeScale = 1;
    }

    public void Help()
    {
        escapeMenuCanvas.SetActive(false);
        helpMenuCanvas.SetActive(true);
    }
}
