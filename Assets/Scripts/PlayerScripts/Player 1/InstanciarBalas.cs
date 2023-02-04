using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InstanciarBalas : MonoBehaviour
{
    public GameObject proyectil;
    public Transform Lanzadera;
    public float fuerza;
    public Animator Anim;
    public static int balasplayer1 = 10;
    public float cooldown = 0.6f;
    private float contador = 0;
    void Update()
    {
        contador = contador - 1*Time.deltaTime;
        InstaciarBalas();
        if (Input.GetKeyDown(KeyCode.J))
        {
            Anim.SetBool("Disparo", true);
        }
        else
        {
            Anim.SetBool("Disparo", false);
        }
    }

    void InstaciarBalas()
    {

        if (Input.GetKeyDown(KeyCode.J) && balasplayer1>0 && contador < 0)
        {
            balasplayer1--;
            contador = cooldown;
            GameObject Bala = Instantiate(proyectil, Lanzadera.position, Lanzadera.rotation);
            Bala.GetComponent<Rigidbody>().AddForce(Lanzadera.forward * fuerza, ForceMode.Impulse);
            Destroy(Bala, 10);
        }
        
    }

}
