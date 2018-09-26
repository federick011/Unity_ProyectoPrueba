using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemigo : MonoBehaviour
{
    
    NavMeshAgent AgenteEnemigo;
    //var para encontrar al jugador
    GameObject Jugador;
    //variables atributos enemigo
    //tipo de enemigo Nivel 1 = 0... etc
    public int NivelEnemigo;

    public float vida=100.0f;
	// Use this for initialization
	void Start ()
    {
        AgenteEnemigo = GetComponent<NavMeshAgent>();
        Jugador = GameObject.Find("VehiculoPlayer");
	}
	
	// Update is called once per frame
	void Update ()
    {
        AgenteEnemigo.destination = Jugador.transform.position;

        if (vida < 1f)
        {
            Destroy(this.gameObject);
        }
	}
}
