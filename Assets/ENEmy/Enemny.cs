using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemny : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent myAgent;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        myAgent=GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        myAgent.SetDestination(target.position);
    }
}
