using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetChill : MonoBehaviour
{
    public GameObject Father; 
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Player1")) 
        {
            GameObject player = col.transform.gameObject;
            player.gameObject.transform.SetParent(Father.transform, true);
        }
        if (col.CompareTag("Player2"))
        {
            GameObject player = col.transform.gameObject;
            player.gameObject.transform.SetParent(Father.transform, true);
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player1"))
        {
            GameObject player = col.transform.gameObject;
            player.gameObject.transform.SetParent(null);
        }
        if (col.CompareTag("Player2"))
        {
            GameObject player = col.transform.gameObject;
            player.gameObject.transform.SetParent(null);
        }
    }
}
