using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Exti : MonoBehaviour
{

    public GameObject[] corazones;
    private int vida;



    private GameObject player;
    Vector3 inicio = Vector3.zero;
       
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        vida = corazones.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void VidasCheck()
    {
        
        
        if (vida < 1)
        {
            Destroy(corazones[0].gameObject);
            SceneManager.LoadScene("PantallaPresentacion");
        }
        else if (vida < 2)
        {
            Destroy(corazones[1].gameObject);
        }
        else if (vida < 3)
        {
            Destroy(corazones[2].gameObject);

        }
        

    }



    


    void OnTriggerEnter(Collider other)
    {
        player.transform.position = inicio;
        GetComponent<AudioSource>().Play();
        vida--;
        VidasCheck();

    }

}
