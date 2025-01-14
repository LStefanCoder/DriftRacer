using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class FinishLine : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject finishCanvas;
    public TMP_Text continueButtonText;
    public TMP_Text scoreText;
    public TMP_Text winOrLoseText;
    public TMP_Text timeText;
    public TMP_Text finalTimeText;
    public TMP_Text UserField;
    public TMP_Text Player1Field;
    public TMP_Text Player2Field;
    public TMP_Text Player3Field;
    public TMP_Text Player4Field;

    private int position1 = 77;
    private int position2 = 24;
    private int position3 = -28;
    private int position4 = -84;
    private int position5 = -136;

    private string timeString;
    //private var allAudioSources : AudioSource[];
    private int finalScore;
    Timer timer;

    private AudioSource[] allAudioSources;

    // Start is called before the first frame update
    void Start()
    {
        //I put the code for the timer into this script, so that I can more conveniently end it when the game ends
        timer = GameObject.Find("TimerEmpty").GetComponent<Timer>();
        Debug.Log(timer);
        timer.startTimer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Line()
    {
        //getting the final time string before the main canvas is deactivated
        timeString = timeText.text;
        mainCanvas.SetActive(false);
        finishCanvas.SetActive(true);
    }

    public void onContinue()
    {
        finalScore = Car_Controller.TotalScoreValue;

        //unfreezing game
        Time.timeScale = 1;

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            if(finalScore < 1430)
            {
                //returning to the menu if one lost the game
                SceneManager.LoadScene("Main");
            }
            else
            {
                SceneManager.LoadScene("Level2");
            }
            
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
        StopAllAudio();
        timer.stopTimer();
        finalScore = Car_Controller.TotalScoreValue;
        //only trigger the finish line script for the finish line itself, and not other colliders
        if (other.gameObject.CompareTag("FinishLine"))
        {
            timeString = timeText.text;
            scoreText.text = finalScore.ToString();
            finalTimeText.text = "Your time: " + timeString;
            //freezing game
            Time.timeScale = 0;
            //displaying finish screen
            Line();

            if (finalScore < 250)
            {
                winOrLoseText.text = "You lost!";
                continueButtonText.text = "Go back";
            }

            if (finalScore > 250)
            {
                UserField.rectTransform.anchoredPosition = new Vector2(UserField.rectTransform.anchoredPosition.x, position4);

                Player1Field.rectTransform.anchoredPosition = new Vector2(Player1Field.rectTransform.anchoredPosition.x, position1);

                Player2Field.rectTransform.anchoredPosition = new Vector2(Player2Field.rectTransform.anchoredPosition.x, position2);

                Player3Field.rectTransform.anchoredPosition = new Vector2(Player3Field.rectTransform.anchoredPosition.x, position3);

                Player4Field.rectTransform.anchoredPosition = new Vector2(Player4Field.rectTransform.anchoredPosition.x, position5);

                winOrLoseText.text = "You lost!";
                continueButtonText.text = "Go back";
            }

            if (finalScore > 570)
            {
                UserField.rectTransform.anchoredPosition = new Vector2(UserField.rectTransform.anchoredPosition.x, position3);

                Player1Field.rectTransform.anchoredPosition = new Vector2(Player1Field.rectTransform.anchoredPosition.x, position1);

                Player2Field.rectTransform.anchoredPosition = new Vector2(Player2Field.rectTransform.anchoredPosition.x, position2);

                Player3Field.rectTransform.anchoredPosition = new Vector2(Player3Field.rectTransform.anchoredPosition.x, position4);

                Player4Field.rectTransform.anchoredPosition = new Vector2(Player4Field.rectTransform.anchoredPosition.x, position5);

                winOrLoseText.text = "You lost!";
                continueButtonText.text = "Go back";
            }

            if (finalScore > 1040)
            {
                UserField.rectTransform.anchoredPosition = new Vector2(UserField.rectTransform.anchoredPosition.x, position2);

                Player1Field.rectTransform.anchoredPosition = new Vector2(Player1Field.rectTransform.anchoredPosition.x, position1);

                Player2Field.rectTransform.anchoredPosition = new Vector2(Player2Field.rectTransform.anchoredPosition.x, position3);

                Player3Field.rectTransform.anchoredPosition = new Vector2(Player3Field.rectTransform.anchoredPosition.x, position4);

                Player4Field.rectTransform.anchoredPosition = new Vector2(Player4Field.rectTransform.anchoredPosition.x, position5);

                winOrLoseText.text = "You lost!";
                continueButtonText.text = "Go back";
            }

            if (finalScore > 1430)
            {
                UserField.rectTransform.anchoredPosition = new Vector2(UserField.rectTransform.anchoredPosition.x, position1);

                Player1Field.rectTransform.anchoredPosition = new Vector2(Player1Field.rectTransform.anchoredPosition.x, position2);

                Player2Field.rectTransform.anchoredPosition = new Vector2(Player2Field.rectTransform.anchoredPosition.x, position3);

                Player3Field.rectTransform.anchoredPosition = new Vector2(Player3Field.rectTransform.anchoredPosition.x, position4);

                Player4Field.rectTransform.anchoredPosition = new Vector2(Player4Field.rectTransform.anchoredPosition.x, position5);

                winOrLoseText.text = "You won!";
                continueButtonText.text = "Next";
            }
        }

        
    }

    //taken from https://discussions.unity.com/t/how-to-stop-all-audio/32919/4
    private void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }

    /*private void StartAllAudio()
    {

    }

    private void StopAllAudio()
    {
        for (var source : AudioSource in allAudioSources)
        {
            source.Stop();
        }
    }*/
}

