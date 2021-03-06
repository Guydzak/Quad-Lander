﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public float timeRemaining = 45.0f; //How much time is remaining.
    public Text timeText; //References the "Time Remaining" UI.
    public Text points; //Displays the points.
    public CheckGround cG;
    Animator anim;
    public int t;


    void Start()
    {
        anim = GetComponent<Animator>();
        cG = GameObject.FindGameObjectWithTag("Player").GetComponent<CheckGround>();
    }


    void Update()     // Update is called once per frame
    {

        if (timeRemaining <= 0) //When the time reaches zero, "Game Over is activated.
        {
            PlayerPrefs.GetInt("Points", 0);
            GameOver();
        }
        timeRemaining -= Time.deltaTime; //Subtracting "Time Remaining" from delta time.
        timeText.text = "Time Remaining: " + timeRemaining; // The text represents the time remaining. These two variables are directly conntected.
        points.text = "SCORE :" + cG.points.ToString();


    }

    public void GameOver()
    {
        StartCoroutine(explotion());
        anim.SetBool("Explosion", true);
        
    }

    IEnumerator explotion()
    {
        yield return new WaitForSeconds(t);
        SceneManager.LoadScene("GameOver");
    }



}


