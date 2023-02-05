using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HormigaKill : MonoBehaviour
{
    static Arbol arbol;
    float daniarCada = 1;

    private void Start()
    {
        if (arbol == null)
        {
            arbol = FindObjectOfType<Arbol>();
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        GameObject otroGO = col.gameObject;
        if (otroGO.tag == "Bala")
        {
            Destroy(otroGO);
            Destroy(gameObject);
        }
        else if (otroGO.tag == "Arbol")
        {
            StartCoroutine(DaniarArbol());
        }
    }

    IEnumerator DaniarArbol()
    {
        while (true)
        {
            arbol.life -= 1;
            yield return new WaitForSeconds(daniarCada);
        }
    }
}
