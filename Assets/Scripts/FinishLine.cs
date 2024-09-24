using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishLine : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject finishCanvas;
    public TMP_Text scoreText;

    private int finalScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Line()
    {
        mainCanvas.SetActive(false);
        finishCanvas.SetActive(true);
    }

    public void onContinue()
    {
        //unfreezing game
        Time.timeScale = 1;
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            SceneManager.LoadScene("Main");
        }

        if (SceneManager.GetActiveScene().name == "Level2")
        {
            SceneManager.LoadScene("Main");
        }
    }

    //this is a built-in function, see https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
    //inspired by https://www.youtube.com/watch?v=lmbJiV8ZETc
    private void OnTriggerEnter(Collider other)
    {
        finalScore = Car_Controller.TotalScoreValue;
        //only trigger the finish line script for the finish line itself, and not other colliders
        if (other.gameObject.CompareTag("FinishLine"))
        {
            scoreText.text = finalScore.ToString();
            //freezing game
            Time.timeScale = 0;
            //displaying finish screen
            Line();
        }
    }
}

