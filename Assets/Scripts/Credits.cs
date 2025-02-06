using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    //since the garage and the main menu are in a different scene, we are going to use GameObject.Find
    private GameObject garage;
    private GameObject main;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Main()
    {
        SceneManager.LoadScene("Main");
        main.SetActive(true);
        garage.SetActive(false);
    }

    public void GoBack()
    {
        SceneManager.LoadScene("Main");
    }
}
