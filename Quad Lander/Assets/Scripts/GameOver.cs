﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text Score;
    public int score;
 
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = PlayerPrefs.GetInt("points").ToString();
    }
}
