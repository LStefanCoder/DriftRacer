using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenu : MonoBehaviour
{
    public GameObject helpMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //activate the help menu if the F1 key is pressed
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (helpMenuCanvas.activeSelf == false)
            {
                helpMenuCanvas.SetActive(true);
                //freezes the gameplay
                Time.timeScale = 0;
            }

            else
            {
                helpMenuCanvas.SetActive(false);
                //resumes the gameplay
                Time.timeScale = 1;
            }
        }
    }
}
