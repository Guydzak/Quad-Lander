using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeller : MonoBehaviour
{
    // Start is called before the first frame update
    public CheckGround cG;
    public Vector3 startPos;
    public Vector3 endPos;
    GameObject Repel;
    public float RepelSpeed;
    public GameObject Quad;
    
    void Start()
    {
        cG = GameObject.FindGameObjectWithTag("Player").GetComponent<CheckGround>();
        Repel = GameObject.FindGameObjectWithTag("Respawn");
        Quad = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cG.isGrounded == true)
        {
            startPos = Quad.transform.position;
            endPos = Repel.transform.position;
            Quad.transform.position = Vector3.Lerp(startPos, endPos, RepelSpeed);
        }
        
        
    }
}
