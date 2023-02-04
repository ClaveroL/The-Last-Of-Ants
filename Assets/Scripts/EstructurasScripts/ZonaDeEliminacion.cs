using UnityEngine;
     

public class ZonaDeEliminacion : MonoBehaviour
{
    public GameObject SpawnTeam1;
    public GameObject SpawnTeam2;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider Zona)
    {
        if (Zona.transform.gameObject.tag == "Player1")
        {
            GameObject Player1 = Zona.transform.gameObject;
            Player1.transform.position = SpawnTeam1.transform.position;
            PuntosBlue.ScoreBlue++;
            Debug.Log("Puntos TeamAzul = " + PuntosBlue.ScoreBlue);


        }
        if (Zona.transform.gameObject.tag == "Player2")
        {
            GameObject Player2 = Zona.transform.gameObject;
            Player2.transform.position = SpawnTeam2.transform.position;
            PuntajeRed.ScoreRed++;
            Debug.Log("Puntos TeamRojo = " + PuntajeRed.ScoreRed);
        }

        if (Zona.transform.gameObject.tag == "Estructura") 
        {
            GameObject C1 = Zona.transform.gameObject;
            Destroy(C1);
        }

    }
}
