using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooter : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public GameObject missileProjectile;
    public Transform target;
    public float spawnDelay = 3f;
    public float spawnInterval = 1.5f;


    void Start()
    {
        InvokeRepeating("FireMissile", spawnDelay, spawnInterval);
    }


    // Update is called once per frame
    void Update()
    {
    
    Vector3 targetDirection = target.position - transform.position;

    float singleStep = rotationSpeed * Time.deltaTime;

    Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

    Debug.DrawRay(transform.position, newDirection, Color.red);

    transform.rotation = Quaternion.LookRotation(newDirection);
    }

    void FireMissile()
    {
        Instantiate(missileProjectile, transform.position, transform.rotation);
    }

}
