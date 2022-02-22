using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Ejes
    private float horizontalInput;
    private float verticalInput;

    //Velocidad de movimiento
    private float speed = 25f;
    //Velocidad de giro
    private float turnSpeed = 60f;

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
       
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
