using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressed SPACE");
        }

    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Roteting LEFT");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Roteting RIGHT");
        }
    }
}
