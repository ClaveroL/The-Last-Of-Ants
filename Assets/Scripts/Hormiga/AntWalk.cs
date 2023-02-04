
using UnityEngine;
using UnityEngine.AI;


public class AntWalk : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform tree;

    public void SetPosition(Transform treeT)
    {
        tree = treeT;
    }

    private void Update()
    {
        if(tree!= null)
        agent.SetDestination(tree.position);
    }

}
