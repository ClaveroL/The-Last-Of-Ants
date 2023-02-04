using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAmmo : MonoBehaviour
{

    void Update()
    {
        Destroy(gameObject, 8);
    }
}
