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
        //dir = new Vector3(0,0,0);
        if(Input.GetKey(KeyCode.W)){
            rb.velocity = transform.forward * speed;//new Vector3(1,0,0);
            }
        else if(Input.GetKey(KeyCode.S)){
            rb.velocity = -transform.forward * speed;//new Vector3(-1,0,0);    
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * speed, Space.World);
        }
        else if(Input.GetKey(KeyCode.A)){
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * speed, Space.World);
            }
        //rb.AddForce(dir, ForceMode.VelocityChange);//dir.normalized*speed;
    }
}
