using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This is thing is friendly");
                break;
            case "Finish":
                Debug.Log("Congrats you finished!");
                break;
            case "Fuel":
                Debug.Log("You got the fuel!");
                break;
            default:
                Debug.Log("You blew up!!");
                break;
             
        }
    }
}
