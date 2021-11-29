using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Transform fuente; //punto donde se instancia la bala
    public GameObject bala;
    public float fuerzabala = 1500f;

   
    
    void Start()
    {
        
    }

  
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject nuevaBala;
            nuevaBala = Instantiate(bala, fuente.position, fuente.rotation);
            //instancia del game object BALA

            nuevaBala.GetComponent<Rigidbody>().AddForce(fuente.forward * fuerzabala);  //impulso de la bala

            GetComponent<AudioSource>().Play();
            Destroy(nuevaBala, 3);
        }


    }


   
}
