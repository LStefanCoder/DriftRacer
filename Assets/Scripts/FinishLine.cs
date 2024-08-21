using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //this is a built-in function, see https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
    //inspired by https://www.youtube.com/watch?v=lmbJiV8ZETc
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger hit");
    }
}

