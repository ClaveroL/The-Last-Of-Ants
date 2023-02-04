using UnityEngine.UI;
using UnityEngine;

public class PuntajeRed : MonoBehaviour
{
    public Text TeamRed;
    public static int ScoreRed;
    void Update()
    {
        TeamRed.text = ScoreRed.ToString();
    }
}
