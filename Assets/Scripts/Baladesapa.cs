using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Baladesapa : MonoBehaviour {
	//0 para principal, 1 para enemigos
	public int idclien;
	float TiempoDeexplosion;

	public Lista_personajes generador_person;

	public GameObject explosion;
	GameObject clonexplo;
	public Text texto;
	string textopuntaje;
	int Contpuntaje;
	Movecubo[] Script;
	int semueveb=1;

	float PuntoInicio;

	float Radioexplo=5, Fuerzaexplo=500f;

	void Start () 
	{
		PuntoInicio=transform.position.z;
		generador_person=GameObject.Find("Generador_Personajes").GetComponent<Lista_personajes>();
		//Script = GameObject.Find ("Modelo_personaje1").GetComponents<Movecubo> ();
	}

	void OnCollisionEnter (Collision col)
	{
		if (idclien == 0) 
		{
			if (col.gameObject.tag != "Player" && col.gameObject.tag != "Bala") 
			{

				semueveb = 0;
				clonexplo = Instantiate (explosion, transform.position, transform.rotation);
				//clonexplo.transform.parent = transform;
				Destroy (this.gameObject, 0.15f);

			}
		} 
		else if (idclien == 1) 
		{
			if (col.gameObject.tag != "Bala_Enemigo" && col.gameObject.tag!="Enemigo") 
			{
				semueveb = 0;
				clonexplo = Instantiate (explosion, transform.position, transform.rotation);
				//clonexplo.transform.parent = transform;
				Destroy (this.gameObject, 0.15f);
			}
		}
		//destruye un objeto segun su nombre

	}

	void OnTriggerEnter(Collider other)
	{

		//el tag de otro trigger
		//this.tag
		//Destroy (other.gameObject);
		//posactual=transform.position.y;
		//transform.Translate(0.9f, 0, 0);
	}
	// Use this for initialization




	
	// Update is called once per frame
	void Update () 
	{
		TiempoDeexplosion += Time.deltaTime;
		if (TiempoDeexplosion>5f) 
		{
			clonexplo = Instantiate (explosion, transform.position, transform.rotation);
			Destroy (this.gameObject);
		}
		if (semueveb == 1) 
		{
			if (idclien == 0) 
			{
				transform.Translate (0, 0, 0.5f);

			} 
			else if (idclien == 1) 
			{
				//transform.LookAt(new Vector3(generador_person.ClonPersonaje[generador_person.idpuc].transform.position.x, generador_person.ClonPersonaje[generador_person.idpuc].transform.position.y, generador_person.ClonPersonaje[generador_person.idpuc].transform.position.z));
				transform.Translate (0, 0f, 0.8f);
			}

		}
		else 
		{
			//=========Script de explosion=========
			Collider[] colliders = Physics.OverlapSphere (transform.position, Radioexplo);

			foreach (Collider nearbyObject in colliders) 
			{
				Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
				if (rb != null) 
				{
					rb.AddExplosionForce (Fuerzaexplo, transform.position, Radioexplo);
				}
			}


			//======explosion fin===========
		}


		/*if (transform.position.y < -4f) 
		{
			Destroy (this.gameObject);
		}*/
		/*if(Script[0].moverAryAbdev()==1)
		{
			transform.Translate (0, 0, 3f);

			transform.LookAt(new Vector3(transform.position.x, 0.4f, transform.position.z+550f));

		}
		else if(Script[0].moverAryAbdev()==2)
		{

			transform.Translate (0, 0, 3f);

			transform.LookAt (new Vector3(transform.position.x, 0.4f, transform.position.z-550f));
		}
		if (Script[0].moverAryAbdev () == 3) {
			transform.Translate (0, 0, 3f);

			transform.LookAt (new Vector3 (transform.position.x + 550f, 0.4f, transform.position.z));
		} else if (Script[0].moverAryAbdev () == 4) {
			transform.Translate (0, 0, 3f);

			transform.LookAt (new Vector3 (transform.position.x - 550f, 0.4f, transform.position.z));
		} */

		

		
	}
}
