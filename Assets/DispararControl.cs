using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararControl : MonoBehaviour
{
    [SerializeField]
    private GameObject bala;
    [SerializeField]
    private KeyCode tecla = KeyCode.K;
    public Transform contenedor;
    [SerializeField]
    private Transform lanzadera;
    private bool canshot = true;
    private float cooldown = 0;

    void Update()
    {
        cooldown =+ cooldown - Time.deltaTime;

        if (cooldown < 0)
        {
            canshot = true;

        }
        else
        {
            canshot = false;
        }

        {
            if (Input.GetKeyDown(tecla) && canshot)
            {
                Instantiate(bala, lanzadera.position, Quaternion.identity, contenedor);
                cooldown = 0.5f;
            }
        }
    }
}
