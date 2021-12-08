using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebot : MonoBehaviour
{
    public float speed;
    private Vector3 dir;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = new Vector3(0,0,0);
        if(Input.GetKey(KeyCode.W)){
            dir = new Vector3(1,0,0);
            }
        if(Input.GetKey(KeyCode.S)){
            dir = new Vector3(-1,0,0);    
        }
        if(Input.GetKey(KeyCode.D)){
            dir = new Vector3(0,0,-1);
            }
        if(Input.GetKey(KeyCode.A)){
            dir = new Vector3(1,0,1);
            }
        rb.AddForce(dir, ForceMode.VelocityChange);//dir.normalized*speed;


    }
}
