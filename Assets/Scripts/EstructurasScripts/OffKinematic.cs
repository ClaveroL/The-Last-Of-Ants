using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffKinematic : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {
        apagarkinematik();
    }

    void apagarkinematik()
    {
        int totalvidas = gameObject.GetComponent<Vidas>().vidas;
        if (totalvidas <= 0) 
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
