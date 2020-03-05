using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{

    public float score = 0f; //The player's score.
    public Text scoreText; //The text of the player's score.

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
