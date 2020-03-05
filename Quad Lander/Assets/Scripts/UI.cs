using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public float timeRemaining = 45.0f; //How much time is remaining.
    public Text timeText; //References the "Time Remaining" UI.

    private void Update()     // Update is called once per frame
    {
        timeRemaining -= Time.deltaTime; //Subtracting "Time Remaining" from delta time.
        timeText.text = "Time Remaining: " + timeRemaining; // The text represents the time remaining. These two variables are directly conntected.

        if(timeRemaining <= 0) //When the time reaches zero, "Game Over is activated.
        {
            GameOver();
        }

    }

    public void GameOver()
    {

    }



}


