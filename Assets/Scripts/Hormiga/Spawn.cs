using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ant;
    public Transform tree;
    public int AntTimeSpawn;

    private void Start()
    {
        InvokeRepeating("SpawnAnt", 1, AntTimeSpawn);
    }

    private void SpawnAnt()
    {
        GameObject antGO = Instantiate(ant, transform.position, Quaternion.identity);

        ant.GetComponent<AntWalk>().SetPosition(tree);


    }
}
