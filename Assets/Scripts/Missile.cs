using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float projectileSpeed = 30f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
