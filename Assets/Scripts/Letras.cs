using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letras : MonoBehaviour
{
    public MoveCamara Camara;
    //public MoveCubo Personaje;
    //float posperso;
	// Use this for initialization
	void Start ()
    {
        //Personaje = Personaje.GetComponent<MoveCubo>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //para que el texto este a la misma distancia del punto final del raycast
        //posperso = Personaje.DistanciaRay;
        //transform.LookAt(Camara.transform.position);
        transform.position =new Vector3 (Camara.PosRayo.x, Camara.PosRayo.y+12f, Camara.PosRayo.z);
		
	}
}
