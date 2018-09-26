using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour {
	//0 para principal, 1 para enemigos
	public int IdCliente;
	//public Lista_personajes Lista_persodis;
	public GameObject Balaoriginal;
	GameObject Clonbala;


	//public GameObject script;
	//int disparo=0;
	// Use this for initialization
	float TiempoDisparar=0.5f;
	void Start () 
	{
		if (IdCliente != 0) 
		{
			//Lista_persodis=GameObject.Find("Generador_Personajes").GetComponent<Lista_personajes>();
		}
		

	}

	void OnTriggerStay(Collider col)
	{
		if (IdCliente == 1 && col.gameObject.tag=="Player") 
		{
			//if (Lista_persodis.ClonPersonaje [Lista_persodis.idpuc].transform.position.z > transform.position.z - 22f || Lista_persodis.ClonPersonaje [Lista_persodis.idpuc].transform.position.z < transform.position.z + 22f) 
			//{
				TiempoDisparar += Time.deltaTime;
				if (TiempoDisparar > 2f) 
				{
					Clonbala = Instantiate (Balaoriginal, new Vector3 (transform.position.x, transform.position.y, transform.position.z+2f),Quaternion.identity);
					//Clonbala.transform.parent = transform;
				    Clonbala.transform.LookAt(new Vector3(col.gameObject.transform.position.x,col.gameObject.transform.position.y, col.gameObject.transform.position.z));
					Clonbala.GetComponent<Baladesapa> ().idclien = IdCliente;
					Clonbala.GetComponent<Rigidbody> ().isKinematic = true;
					TiempoDisparar = 0;

				}
			//}

		}
		else if (IdCliente == 0 && col.gameObject.tag=="Enemigo") 
		{
			
			//if (Lista_persodis.ClonPersonaje [Lista_persodis.idpuc].transform.position.z > transform.position.z - 22f || Lista_persodis.ClonPersonaje [Lista_persodis.idpuc].transform.position.z < transform.position.z + 22f) 
			//{
			//}

		}
	}
	// Update is called once per frame
	void Update ()
	{
		
		
		if (IdCliente == 0)
		{
			if (Input.GetMouseButton (1)) 
			{
				TiempoDisparar += Time.deltaTime;
				if (TiempoDisparar > 0.4f) 
				{
					Clonbala = Instantiate (Balaoriginal, new Vector3 (transform.position.x, transform.position.y, transform.position.z + 0.5f), Quaternion.identity);
					Clonbala.transform.parent = transform;
					Clonbala.GetComponent<Baladesapa> ().idclien = IdCliente;
					Clonbala.GetComponent<Rigidbody> ().isKinematic = false;
					TiempoDisparar = 0;
				}

				//Clonbala.transform.localScale=new Vector3(0.246f, 0.126f, 0.8836f);

				//Clonbala.AddComponent<Rigidbody> ();

			}
		}
		/*else if (IdCliente == 1 ) 
		{
			if (Lista_persodis.ClonPersonaje [Lista_persodis.idpuc].transform.position.z > transform.position.z - 22f || Lista_persodis.ClonPersonaje [Lista_persodis.idpuc].transform.position.z < transform.position.z + 22f) 
			{
				TiempoDisparar += Time.deltaTime;
				if (TiempoDisparar > 2f) 
				{
					Clonbala = Instantiate (Balaoriginal, new Vector3 (transform.position.x, transform.position.y, transform.position.z+2f),Quaternion.identity);
					//Clonbala.transform.parent = transform;
					Clonbala.transform.LookAt(new Vector3(Lista_persodis.ClonPersonaje[Lista_persodis.idpuc].transform.position.x,Lista_persodis.ClonPersonaje[Lista_persodis.idpuc].transform.position.y,Lista_persodis.ClonPersonaje[Lista_persodis.idpuc].transform.position.z));
					Clonbala.GetComponent<Baladesapa> ().idclien = IdCliente;
					Clonbala.GetComponent<Rigidbody> ().isKinematic = true;
					TiempoDisparar = 0;

				}
			}

		}*/



	}


}
