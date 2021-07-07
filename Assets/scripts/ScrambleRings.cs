using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrambleRings : MonoBehaviour
{
    public Vector3 init_location;
    // Start is called before the first frame update
    void Start()
    {
        init_location = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void randomize()
    {
        transform.position = new Vector3(Random.Range(-45.0f,45.0f),transform.position.y,Random.Range(-69.0f,69.0f));
    }

    public void reset()
    {
        transform.position = init_location;
    }
}
