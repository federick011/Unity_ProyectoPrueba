using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover_cañontanque : MonoBehaviour {

	public Lista_personajes Lista_person;
	//0 enemigo, 1 personaje
	public int IdObjeto;
	Vector3 PosPerson;

	// Use this for initialization
	void Start () 
	{
		if (IdObjeto == 0)
		{
			Lista_person = GameObject.Find ("Generador_Personajes").GetComponent<Lista_personajes> ();
		}


	}
	void OnTriggerEnter(Collider col)
	{
		if (IdObjeto == 1) 
		{
			if (col.gameObject.tag == "Enemigo") 
			{
				transform.LookAt (new Vector3(col.gameObject.transform.position.x, col.gameObject.transform.position.y, col.gameObject.transform.position.z));
			}
		}
	}
	// Update is called once per frame
	void Update ()
	{
		
		//cambia la rotacion
		//transform.rotation=Quaternion.Euler(0,0,0);
		if (IdObjeto == 0) 
		{
			if (transform.rotation.x>-40f) 
			{
				PosPerson = new Vector3 (Lista_person.ClonPersonaje [Lista_person.idpuc].transform.position.x, Lista_person.ClonPersonaje [Lista_person.idpuc].transform.position.y + 1f, Lista_person.ClonPersonaje [Lista_person.idpuc].transform.position.z);
				transform.LookAt (PosPerson);
			}

		}

	}
}
