using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsController : MonoBehaviour
{

    private float lowerBound = 1;
    private float warningBound = 500;
    private float horizontalBound = 650;
    public GameObject player;

    void Update()
    {
        // Deletes objects that crash into the sea.
        if(transform.position.y <= lowerBound)
        {
            Destroy(gameObject);
        }

        //Warns player for leaving game area
        if(player.transform.position.x > warningBound) 
        {
            Debug.Log("WARNING! Leaving Mission Area. Fall Back!");
        } else if(player.transform.position.x < -warningBound) 
        {
            Debug.Log("WARNING! Leaving Mission Area. Fall Back!");
        }

        if(player.transform.position.z > warningBound)
        {
            Debug.Log("WARNING! Leaving Mission Area. Fall Back!");
        } else if(player.transform.position.z < -warningBound)
        {
            Debug.Log("WARNING! Leaving Mission Area. Fall Back!");
        }

        //Destroys out of bounds player
        if(player.transform.position.x > horizontalBound)
        {
            Destroy(gameObject);
            Debug.Log("Mission Failed: Deserted");
        } else if(player.transform.position.x < -horizontalBound)
        {
            Destroy(gameObject);
            Debug.Log("Mission Failed: Deserted");
        }
        if(player.transform.position.z > horizontalBound)
        {
            Destroy(gameObject);
            Debug.Log("Mission Failed: Deserted");
        } else if(player.transform.position.z < -horizontalBound)
        {
            Destroy(gameObject);
            Debug.Log("Mission Failed: Deserted");
        }
    }
}
