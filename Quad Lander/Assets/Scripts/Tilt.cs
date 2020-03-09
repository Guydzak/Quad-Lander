using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    private Rigidbody2D rb;
    public float tiltX;
    public float speed = 10;
    public float edgeleft = -10f;
    public float edgeRight = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        tiltX = Input.acceleration.x * speed;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, edgeleft, edgeRight), transform.position.y, -1);
    }
}
