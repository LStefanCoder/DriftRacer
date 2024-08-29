using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyCounter : MonoBehaviour
{
    public TMP_Text text1;
    //private TMP_Text txt;

    private void Awake()
    {
        //txt = GetComponent<TMP_Text>();
    }
    private void Update()
    {
        //the text is always updated to the current amount of in-game currency the user has
        text1.text = SaveManager.instance.money.ToString();
        //text1.text = "a";
    }
}