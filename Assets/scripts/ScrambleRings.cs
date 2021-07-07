using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrambleRings : MonoBehaviour
{
    public Vector3 init_location;
    public float buffer;
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
        transform.position = new Vector3(Random.Range(-48.0f+buffer,48.0f-buffer),transform.position.y,Random.Range(-72.0f+buffer,72.0f-buffer));
    }

    public void reset()
    {
        transform.position = init_location;
    }
}
