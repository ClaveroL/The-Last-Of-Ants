using UnityEngine;

public class BalaV1 : MonoBehaviour
{
    public Rigidbody RbBala;
    void OnCollisionEnter(Collision Detect)
    {
        GameObject target = Detect.transform.gameObject;
        if (target.GetComponent<Vidas>())
        {
            target.GetComponent<Vidas>().vidas--;
            if (Detect.transform.gameObject.tag == "Enemigo")
            {

                int totaldevidas = target.GetComponent<Vidas>().vidas;
                if (totaldevidas > 0)
                {
                    target.GetComponent<Rigidbody>().AddForceAtPosition(transform.forward * 1000/totaldevidas, target.transform.position, ForceMode.Impulse);
                }
                else
                {
                    target.GetComponent<Rigidbody>().AddForceAtPosition(transform.forward * 1000, target.transform.position, ForceMode.Impulse);
                }
            }
            if (Detect.transform.gameObject.tag == "Estructura") 
            {
                target.GetComponent<Rigidbody>().AddForceAtPosition(transform.forward * 150, target.transform.position, ForceMode.Impulse);
            }
            if (Detect.transform.gameObject.tag == "Player1") 
            {
                    target.GetComponent<Rigidbody>().AddForceAtPosition(transform.forward * 100, target.transform.position, ForceMode.Impulse);
            }
            if (Detect.transform.gameObject.tag == "Player2")
            {
                    target.GetComponent<Rigidbody>().AddForceAtPosition(transform.forward * 100, target.transform.position, ForceMode.Impulse);
            }



        }
        Destroy(gameObject);
    }
}
