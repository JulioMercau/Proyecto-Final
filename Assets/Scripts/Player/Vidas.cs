using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public GameObject[] corazones;
    private int vida=3;
    Vector3 inicio = Vector3.zero;



    void Start()
    {
        
    }

    
    void Update()
    {
        if (vida<1)
        {
            Destroy(corazones[0].gameObject);
            SceneManager.LoadScene("PantallaPresentacion");
        }
        else if (vida<2)
        {
            Destroy(corazones[1].gameObject);
        }
        else if (vida<3)
        {
            Destroy(corazones[2].gameObject);
            
        }
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
}
