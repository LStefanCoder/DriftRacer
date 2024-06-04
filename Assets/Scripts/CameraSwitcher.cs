using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//inspired by https://www.youtube.com/watch?v=whPUzeLSHhQ
//switches camera when a key is pressed

public class CameraSwitcher : MonoBehaviour
{
    public Camera fromBehind;
    public Camera front;
    public Camera back;

    // Start is called before the first frame update
    void Start()
    {
        //in the beginning, only the camera from behind
        front.enabled = false;
        back.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //keycodes for the script api are here: https://docs.unity3d.com/ScriptReference/KeyCode.html
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            ChangeToBehind();
        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            ChangeToFront();
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            ChangeToBack();
        }
    }

    void ChangeToBehind()
    {
        fromBehind.enabled = true;
        front.enabled = false;
        back.enabled = false;
    }

    void ChangeToFront()
    {
        fromBehind.enabled = false;
        front.enabled = true;
        back.enabled = false;
    }

    void ChangeToBack()
    {
        fromBehind.enabled = false;
        front.enabled = false;
        back.enabled = true;
    }
}
