using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckGround : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isGrounded = false;
    public int points;
    Animator anim;
    public UI uI;
    Rigidbody2D player;


    void Start()
    {
        points = PlayerPrefs.GetInt("points");
        anim = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Normal" || collision.gameObject.tag == "Special")
        {
            if(anim.GetBool("TurnRight") == true || anim.GetBool("TurnLeft") == true)
            {
                //player.constraints = RigidbodyConstraints2D.FreezeAll;
                anim.SetBool("TurnRight", false);
                anim.SetBool("Turnleft", false);
                StartCoroutine(explosion());
                anim.SetBool("Explosion", true);
            }
        }
        
        if (collision.gameObject.tag == "Normal")
        {
            anim.SetBool("Grounded", true);
            StartCoroutine(normalRepel());
            points += 10;
            PlayerPrefs.SetInt("points", points);
        }
        else if (collision.gameObject.tag == "Special")
        {
            anim.SetBool("SpecialLanding", true);
            points += 20;
            PlayerPrefs.SetInt("points", points);
            isGrounded = true;
            Debug.Log("Working");
            StartCoroutine(Change());
        }

    }

    IEnumerator Change()
    {
        yield return new WaitForSeconds(0.5f);
        isGrounded = false;
        anim.SetBool("Grounded", false);
        anim.SetBool("SpecialLanding", false);
    }

    IEnumerator normalRepel()
    {
        yield return new WaitForSeconds(3);
        isGrounded = true;
        Debug.Log("Working");
        StartCoroutine(Change());

    }

    IEnumerator explosion()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameOver");//Need to insert the explosion sprite animation and then transition to game over screen.
    }

}