using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unparent : MonoBehaviour
{
    void Update()
    {
        SeRompe();
    }

    void SeRompe() 
    {
        int totalvidas = gameObject.GetComponent<Vidas>().vidas;
        if(totalvidas <= 0) 
        {
          gameObject.transform.SetParent(null);
        }
        
    }
}
