using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    bool pausa= false;
    public GameObject pausamenu;
    public GameObject UI;
    void Start()
    {
        pausamenu.SetActive(false);
        PausaDesactivada();
    }
    void Update()
    {
        toggle();
    }

    void toggle() 
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (pausa)
            {
                PausaDesactivada();
            }
            else
            {
                PausaActivada();
            }
        }

    }
    void PausaActivada() 
    {
        pausamenu.SetActive(true);
        UI.SetActive(false);
        pausa = true;
        Time.timeScale = 0;
    }
    void PausaDesactivada() 
    {
        pausamenu.SetActive(false);
        UI.SetActive(true);
        pausa = false;
        Time.timeScale = 1;
    }
    public void VolverAlMenu() 
    {
        SceneManager.LoadScene(0);
    }

}
