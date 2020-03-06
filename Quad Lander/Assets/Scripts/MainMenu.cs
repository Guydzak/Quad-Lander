using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("points", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickPlay()
    {
        PlayerPrefs.SetInt("points", 0);
        SceneManager.LoadScene("TestScene");
    }
    
    public void onClickExit()
    {
        Application.Quit();
    }
}
