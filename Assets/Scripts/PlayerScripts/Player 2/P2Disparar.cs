using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Disparar : MonoBehaviour
{
    public GameObject proyectil;
    public Animator Anim;
    public Transform Lanzadera;
    public float fuerza;
    public static int balasplayer2 = 10;
    public float cooldown = 0.6f;
    private float contador = 0;
    void Update()
    {
        contador = contador - 1 * Time.deltaTime;
        InstaciarBalas();
        if (Input.GetKeyDown(KeyCode.Keypad2))
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

        if (Input.GetKeyDown(KeyCode.Keypad2) && balasplayer2 >0 && contador < 0)
        {
            balasplayer2--;
            contador = cooldown;
            GameObject Bala = Instantiate(proyectil, Lanzadera.position, Lanzadera.rotation);
            Bala.GetComponent<Rigidbody>().AddForce(Lanzadera.forward * fuerza, ForceMode.Impulse);
            Destroy(Bala, 10);
        }

    }

}