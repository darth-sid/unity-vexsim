using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e : MonoBehaviour
{
    public GameObject[] field_rings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void scramble()
    {
        field_rings = GameObject.FindGameObjectsWithTag("FieldRing");
        foreach (GameObject ring in field_rings)
        {
            ring.GetComponent<ScrambleRings>().randomize();
            }
    }

    }
