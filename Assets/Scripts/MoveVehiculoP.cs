using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveVehiculoP : MonoBehaviour
{
    //para que se mueve entre puntos
    public Transform[] points;
    private int destPoint;
    private float Tiempo;
    //variable del navmesh agent
    NavMeshAgent Agent;

    public float VidaJugador=100.0f;
	// Use this for initialization
	void Start ()
    {
        destPoint =Random.Range(0, points.Length);
        Agent = GetComponent<NavMeshAgent>();

        GotoNextPoint();
        //Debug.Log("Cantiodad de puntos "+ points.Length);
    }
    void GotoNextPoint()
    {
        destPoint = Random.Range(0, points.Length);
        // Set the agent to go to the currently selected destination.
        Agent.destination = points[destPoint].position;
    }

    // Update is called once per frame
    void Update ()
    {
        if(Agent.remainingDistance < 0.5f && Tiempo == 0)
        {
            
                GotoNextPoint();

        }
            

    }
}
