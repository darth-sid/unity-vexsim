using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePerspective : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.RightArrow)){
            transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z-1);
            }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z+1);
            }


        if(Input.GetKey(KeyCode.UpArrow)){
            transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y-1,transform.eulerAngles.z);
            }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y+1,transform.eulerAngles.z);
            }


 
    }
}
