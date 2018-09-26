using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text.RegularExpressions;

public class Moveenemigo : MonoBehaviour {

	public Lista_personajes Lista_perso;
	public GameObject Explosionene;
	GameObject clonexploene;
	//El tipo de enemigo
	public int idenemigo;
	//Id unica del enemigo
	public int IdUnicaEnemigo;
	int semueve;
    float DistanciaPerse=50.5f;
    Vector3 PosMirar;
	// Use this for initialization
	void Start () 
	{
		Lista_perso=GameObject.Find("Generador_Personajes").GetComponent<Lista_personajes>();
	}



	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Bala") 
		{
			if (idenemigo == 0) 
			{
				clonexploene=Instantiate (Explosionene, transform.position, transform.rotation);
			}

			//clonexploene.transform.parent=transform;
			Destroy (this.gameObject, 0.15f);
		}
		//destruye un objeto segun su nombre

	}


	// Update is called once per frame
	void Update ()
	{
        // la posicion donde esta el personaje
        PosMirar = Lista_perso.ClonPersonaje[Lista_perso.idpuc].transform.position;

        if (idenemigo == 0) 
		{
			
			if (PosMirar.z > transform.position.z && PosMirar.z<transform.position.z+DistanciaPerse) 
			{
				transform.LookAt (new Vector3 (PosMirar.x, PosMirar.y, PosMirar.z));
				transform.Translate (0, 0, 0.3f);
			}
			else 
			{
				transform.LookAt (new Vector3(PosMirar.x, transform.position.y, PosMirar.z));
		
			}
		}
		if (idenemigo == 1) 
		{
			
			if (PosMirar.z > transform.position.z && PosMirar.z<transform.position.z+DistanciaPerse) 
			{
				transform.LookAt (new Vector3 (PosMirar.x, transform.position.y, PosMirar.z));
				transform.Translate (0, 0, 0.3f);
			} 
			else 
			{
				transform.LookAt (new Vector3(PosMirar.x, transform.position.y, PosMirar.z));
			}
		}
		//Debug.Log (Lista_perso.ClonPersonaje [Lista_perso.idpuc]);
		//transform.Translate (0, 0, 0.39f);
		//anim=GameObject.Find("cuboxd 1").GetComponent<Animator>();

		//anim=GameObject.Find("cuboxd 1").GetComponent<Animator>();

		//anim.StartPlayback;
		
	}
	//float contador=0;
	void moverene()
	{
		
		//transform.Translate (0, 0, 0.39f);

	}
}
