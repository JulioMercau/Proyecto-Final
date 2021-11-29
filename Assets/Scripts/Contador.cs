using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Contador : MonoBehaviour
{

    public Text contador;
    private float tiempo = 300f;

    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo-=Time.deltaTime;
        int minutos = (int)(tiempo / 60);
        float segundos = tiempo % 60f;

        contador.text = " " + minutos.ToString("00")+":"+ segundos.ToString("00");

        if (tiempo<00)
        {
            
            SceneManager.LoadScene("PantallaPresentacion"); //si se acaba el tiempo vuelve a la presentacion
        }
    }
}
