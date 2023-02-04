using UnityEngine.UI;
using UnityEngine;

public class PuntosBlue : MonoBehaviour
{
    public Text TeamBlue;
    public static int ScoreBlue;
    void Update()
    {
        TeamBlue.text = ScoreBlue.ToString();
    }
}

