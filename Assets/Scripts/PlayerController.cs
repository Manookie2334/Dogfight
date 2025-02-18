using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float tiltSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float spinInput;


    // Update is called once per frame
    void Update()
    {
        //Allows player to control the tilt of the plane
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.left * verticalInput * tiltSpeed * Time.deltaTime);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * horizontalInput * tiltSpeed * Time.deltaTime);
        spinInput = Input.GetAxis("Spin");
        transform.Rotate(Vector3.up * spinInput * tiltSpeed * Time.deltaTime);


        //Moves the player forward
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
