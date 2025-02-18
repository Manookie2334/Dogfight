using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooter : MonoBehaviour
{

    public GameObject missileProjectile;

    // Update is called once per frame
    void Update()
    {
        //Allows player to fire mussiles with Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missileProjectile, transform.position, transform.rotation);
        }

    }
}
