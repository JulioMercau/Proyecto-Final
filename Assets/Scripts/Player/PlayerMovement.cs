using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;

    public float speed = 10f;

    public float gravity = -9.81f; //variable para la fuerza de gravedad


    Vector3 velocity;

    void Start()
    {
        
    }

    
    void Update()
    {
        //movimiento del personaje
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move= transform.right*x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);
        
        //control de la gravedad
        velocity.y += gravity*Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);
    }
}
