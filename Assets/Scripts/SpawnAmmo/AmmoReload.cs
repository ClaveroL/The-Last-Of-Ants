using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoReload : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision coll)
    {
        GameObject Jugador = coll.gameObject;
        if (Jugador.transform.gameObject.tag == "Player1") 
        {
            InstanciarBalas.balasplayer1 = InstanciarBalas.balasplayer1 + 10;
            Destroy(gameObject);
        }
        GameObject Jugador2 = coll.gameObject;
        if (Jugador2.transform.gameObject.tag == "Player2")
        {
            P2Disparar.balasplayer2 = P2Disparar.balasplayer2 + 10;
            Destroy(gameObject);
        }
    }
}
