using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MuerteRespawn : MonoBehaviour
{
    public GameObject RespawPoint;
    public int Team;
    
    private void Start()
    {
        transform.position = RespawPoint.transform.position;
        PuntosBlue.ScoreBlue = 0;
        PuntajeRed.ScoreRed = 0;
    }
    void Update()
    {
        SeMurio();
        Gano();

    }
    void SeMurio() 
    {
        int totalvidas = gameObject.GetComponent<Vidas>().vidas;
        if(totalvidas <= 0) 
        {
            transform.position = RespawPoint.transform.position;
            if (Team == 1) 
            {
                PuntosBlue.ScoreBlue++;
                Debug.Log("Puntos TeamAzul = " + PuntosBlue.ScoreBlue);
                totalvidas = 15;
                gameObject.GetComponent<Vidas>().vidas = totalvidas;
            }
            if (Team == 2)
            {
                PuntajeRed.ScoreRed++;
                Debug.Log("Puntos TeamRojo = " + PuntajeRed.ScoreRed);
                totalvidas = 15;
                gameObject.GetComponent<Vidas>().vidas = totalvidas;
                
            }
            
        }

    }
    void Gano() 
    {
        if (PuntosBlue.ScoreBlue > 7) 
        {
            PuntosBlue.ScoreBlue = 0;
            PuntajeRed.ScoreRed = 0;
            InstanciarBalas.balasplayer1 = 10;
            P2Disparar.balasplayer2 = 10;
            SceneManager.LoadScene(2);
        }
        if (PuntajeRed.ScoreRed > 7)
        {
            PuntajeRed.ScoreRed = 0;
            PuntosBlue.ScoreBlue = 0;
            InstanciarBalas.balasplayer1 = 10;
            P2Disparar.balasplayer2 = 10;
            SceneManager.LoadScene(3);
        }
    }
}
