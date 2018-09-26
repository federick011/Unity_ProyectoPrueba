using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveDisparo : MonoBehaviour
{
    //Variable del tipo de vehiculo Player = 0, Terrorista = 1...
    public int IdTipoDeVehiculo;

    public float DistanciaRay;
    //Usamos a la clase MoveCamara si el tipo de vehiculo es el jugador
    public MoveCamara ScriptCamara;
    // el raycast que genera el propio personaje
    public Vector3 Posray;
    //la variable para el navmesh agent
    //NavMeshAgent agent;

    //Si el vehiculo es terrorista se usa esta variable
    private GameObject JugadorPri;
    
	// Use this for initialization
	void Start ()
    {
        if(IdTipoDeVehiculo == 1)
        {
           JugadorPri= GameObject.Find("VehiculoPlayer");
        }
        
    }


    
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            //Vemos que tipo de vehiculo es jugado 0 o enemigo 1
            if (IdTipoDeVehiculo == 0)
            {
                transform.LookAt(new Vector3(ScriptCamara.PosRayo.x, 0, ScriptCamara.PosRayo.z));
                RaycastHit Thehit;

                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Thehit, 200f))
                {

                    DistanciaRay = Thehit.distance;
                    Posray = Thehit.point;
                    Debug.Log("Le pego a " + Thehit.collider.tag);
                    if (Thehit.collider.tag == "Enemigo")
                    {
                        Thehit.collider.gameObject.GetComponent<MoveEnemigo>().vida--;
                    }

                }
            }
            else
            {
                transform.LookAt(JugadorPri.transform.position);
                RaycastHit Thehit;

                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Thehit, 200f))
                {

                    DistanciaRay = Thehit.distance;
                    Posray = Thehit.point;
                    Debug.Log("Le pego a " + Thehit.collider.tag);


                }
            }
        }
        
        
        
       
       
        


    }
}
