using UnityEngine.UI;
using UnityEngine;


public class AmmoBlue : MonoBehaviour
{
    public Text TeamBlue;
    public Text TeamRed;
    void Update()
    {
        TeamBlue.text = P2Disparar.balasplayer2.ToString();
        TeamRed.text = InstanciarBalas.balasplayer1.ToString();
    }
}
