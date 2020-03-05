using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Sprite idle;
    public Sprite right;
    public Sprite left;
    //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;        //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, 0.1f, -1f), ForceMode2D.Impulse);
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("TurnRight", true);
        }
        else
        {
            anim.SetBool("TurnRight", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("TurnLeft", true);
        }
        else
        {
            anim.SetBool("TurnLeft", false);
        }
    }
}
