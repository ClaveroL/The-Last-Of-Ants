using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaSinBug : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    public float speed;
    public float timeshot;

    private static Transform playerTransform;

    void Start()
    {
        if (!playerTransform)
        {
            playerTransform = GameObject.FindWithTag("Player").transform;
        }

        rb.AddForce(playerTransform.forward * speed, ForceMode.Impulse);
        Destroy(gameObject,timeshot);
    }



}
