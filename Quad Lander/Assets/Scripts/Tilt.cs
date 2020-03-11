using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    private Rigidbody2D rb;
    float tiltX;
    public float speed = 10;
    public float edgeleft = -10f;
    public float edgeRight = 10;
    Animator anim;
    Vector3 curPositon;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        curPositon.x = rb.transform.position.x;
        tiltX = Input.acceleration.x * speed;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, edgeleft, edgeRight), transform.position.y, -1);
        if (Input.acceleration.x > 0.1f)
        {
            anim.SetBool("TurnRight", true);
        }

        else if (Input.acceleration.x < -0.1f)
        {
            anim.SetBool("TurnLeft", true);

        }

        else
        {
            anim.SetBool("TurnRight", false);
            anim.SetBool("TurnLeft", false);
        }
        
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(tiltX, 0f);
    }
}
