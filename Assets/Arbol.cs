using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Arbol : MonoBehaviour
{
    public int life = 100;

    [SerializeField]
    Text vidaTexto;

    private void FixedUpdate()
    {
        vidaTexto.text = $"Vida: {life}";
        if (life <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
