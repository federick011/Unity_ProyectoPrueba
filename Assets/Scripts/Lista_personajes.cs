using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lista_personajes : MonoBehaviour {

	public GameObject[] Personajes;
	public GameObject[] ClonPersonaje;

	public Text Texto1;
	String Sangrejugador;
	public int Jugar;
	//id del personaje segun su orden
	public int idpuc;
	//public int[] Idpersonaje;
	// Use this for initialization
	void Start () 
	{
		
		ClonPersonaje=new GameObject[Personajes.Length];
		//Idpersonaje=new int[Personajes.Length];
		/*for (int i = 0; i < Personajes.Length; i++)
		{
			//ClonPersonaje[i]=Instantiate(Personajes[i], new Vector3(Personajes[i].transform.position.x, Personajes[i].transform.position.y, Personajes[i].transform.position.z), Quaternion.identity);
			Idpersonaje[i]=i;
		}*/
		ClonPersonaje[idpuc]=Instantiate(Personajes[idpuc], new Vector3(Personajes[idpuc].transform.position.x, Personajes[idpuc].transform.position.y, Personajes[idpuc].transform.position.z), Personajes[idpuc].transform.rotation);
		//ClonPersonaje [idpuc].GetComponent<Movecubo> ().idpersonaje = idpuc;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Sangrejugador = Convert.ToString (ClonPersonaje[idpuc].GetComponent<Movecubo>().Saludperso);
		Texto1.text=Sangrejugador;
	}
}
