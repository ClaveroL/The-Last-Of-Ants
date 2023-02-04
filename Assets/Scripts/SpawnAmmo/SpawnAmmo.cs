using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnAmmo : MonoBehaviour
{
    public GameObject ammo;
    public float frecuenciaAmmo = 4;
    
    void Update()
    {
        frecuenciaAmmo = frecuenciaAmmo - 1 * Time.deltaTime;
        if (frecuenciaAmmo < 0)
        {
            frecuenciaAmmo = Random.Range(10,20);
 
            Instantiate(ammo,transform);
        }
    }

}
