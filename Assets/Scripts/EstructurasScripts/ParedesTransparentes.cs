using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedesTransparentes : MonoBehaviour
{
    public Material comun;
    public Material Transparente;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
    void Update()
    {
        Detectado();
    }

    public void Detectado()
    {
        if (DetectarParedes.Detectado1 == gameObject.name | DetectarParedes.Detectado2 == gameObject.name) 
        {
            rend.sharedMaterial = Transparente;
        }
        else 
        {
            rend.sharedMaterial = comun;
        }
    }
}

