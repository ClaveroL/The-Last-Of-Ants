using UnityEngine.UI;
using UnityEngine;

public class BarrasDeVida : MonoBehaviour
{
    public Image BarraVidaBlue;
    public GameObject BluePlayer;
    public Image BarraVidaRed;
    public GameObject RedPlayer;

    void Start()
    {

    }
    void Update()
    {
        float blue = BluePlayer.GetComponent<Vidas>().vidas;
        float red = RedPlayer.GetComponent<Vidas>().vidas;
        BarraVidaBlue.fillAmount = blue/7f;
        BarraVidaRed.fillAmount = red/7f;
    }
}
