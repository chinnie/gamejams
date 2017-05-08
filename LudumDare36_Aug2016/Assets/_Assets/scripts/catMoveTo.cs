using UnityEngine;
using System.Collections;

public class catMoveTo : MonoBehaviour {

public Transform goal;
//    public NavMeshAgent agent;
    
    void Update ()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;        
//        agent.GetComponent<NavMeshAgent>();
//        agent.destination = gameObject.transform.position;

    }
}
