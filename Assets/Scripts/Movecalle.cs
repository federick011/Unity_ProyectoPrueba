using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text.RegularExpressions;

public class Movecalle : MonoBehaviour
{

	//para clonar objetos
	//public GameObject[] ObjetoOriginal;
	//public GameObject[] clone;
	public GameObject[] Parcelas;
	GameObject[] clonparcelas;

	float[] posparcela;
	//int AnchoYlargoParcela=25;
	float[] Tiempo;
	//int numerodeparcelas=20;
	int[] construir;
	//int idparceladañada;

	// Use this for initialization
	void Start () 
	{
		//Debug.Log (Parcelas.Length);
		clonparcelas=new GameObject[Parcelas.Length];

		Tiempo=new float[Parcelas.Length];
		construir=new int[Parcelas.Length];

		posparcela=new float[Parcelas.Length];
		float posparcelacentro=transform.position.z-400;
		for (int i = 0; i < Parcelas.Length; i++) 
		{
			posparcela[i]=posparcelacentro;
			clonparcelas[i]=Instantiate(Parcelas[i], new Vector3(transform.position.x, 0, posparcela[i]), Quaternion.identity);
			clonparcelas [i].GetComponent<ScriptParcelas> ().idparcela = i;
			//clonparcelas[i].transform.parent=transform;
			posparcelacentro=posparcelacentro+25;
			Tiempo [i] = 0;
			construir [i] = 0;
			//Debug.Log ("parcela: [" + i + "] = " + posparcela[i]);
		}

		//clone = GameObject.FindGameObjectsWithTag ("Objetos_mapa");
		//instaciamos a los enemigos
		/*for (int c = 0; c < clone.Length; c++) 
		{
			
			clone[c]=Instantiate(ObjetoOriginal[c], new Vector3(475, 0, 260), Quaternion.identity);
			//hago de este clon hijo del objeto que contiene este script
			clone[c].transform.parent=transform;
		}*/

	}


	/*void OnTriggerStay(Collider other)
	{
		//Destroy (this.gameObject);
		//posactual=transform.position.y;


	}*/

	// Update is called once per frame
	void Update () 
	{
		
            //renovar parcelas ya atravesadas
			for (int i = 0; i < Parcelas.Length; i++) 
			{
				if (construir[i] == 1) 
				{
					Tiempo[i]=Tiempo[i]+Time.deltaTime;


				}
				if (Tiempo[i] > 9) 
				{

					clonparcelas[i]=Instantiate(Parcelas[i], new Vector3(transform.position.x, 0, posparcela[i]), Quaternion.identity);
					clonparcelas [i].GetComponent<ScriptParcelas> ().idparcela = i;
					//clonparcelas[i].transform.parent=transform;
					construir[i] = 0;
					Tiempo[i] = 0;
				}
			}


            
		


		//Debug.Log (Random.Range (1, 20));
		/*if (transform.position.z < 0) 
		 {
			transform.position = new Vector3 (475, -1, 750);
		}
		else 
		{
			transform.Translate(0, 0, -0.5f);
		}*/
			
	}


	public void Parceladañada(int Idparcela)
	{

		if (construir[Idparcela] == 0 && Tiempo[Idparcela] == 0) 
		{
			construir[Idparcela] = 1;
			//idparceladañada = Idparcela;
			//Debug.Log ("Mensaje enviado desde movecalle la parcela:"+idparcela+" ha sido dañada "+Tiempo);
			//Debug.Log (construir [Idparcela]+" Tiempo id "+Idparcela+" "+Tiempo[Idparcela]);
		}

	}

}
