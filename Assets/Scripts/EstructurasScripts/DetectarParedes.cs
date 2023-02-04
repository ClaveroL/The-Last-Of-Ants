using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarParedes : MonoBehaviour
{
    public Transform Player1;
    public Transform Player2;
    public RaycastHit Transparencia1;
    public RaycastHit Transparencia2;
    public static string Detectado1;
    public static string Detectado2;
    void Update()
    {
        Detectar();
        Detectar2();
    }
    public void Detectar() 
    {
        if (Physics.Linecast(transform.position,Player1.position, out Transparencia1))
        {
                Detectado1 = Transparencia1.transform.gameObject.name;
        }

    }
    public void Detectar2() 
    {

        if (Physics.Linecast(transform.position, Player2.position, out Transparencia2))
        {
            Detectado2 = Transparencia2.transform.gameObject.name;
        }

    }

}
