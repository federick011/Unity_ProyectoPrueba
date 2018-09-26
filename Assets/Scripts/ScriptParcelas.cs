using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text.RegularExpressions;

public class ScriptParcelas : MonoBehaviour {

    

	public Movecalle movecalle;
	public int idparcela;

	public GameObject[] objetosescena;
	public GameObject[] Enemigosescena;
	//int[] IdEnemigoGenerado;
	int TipoDeObjeto;
	GameObject[] clonobjetos;
	GameObject[] clonEnemigos;
	int idobjeto;
	// Use this for initialization
	void Start () 
	{
		
		TipoDeObjeto=Random.Range(0, 2);
		//Debug.Log (TipoDeObjeto);
		if (TipoDeObjeto == 0)
		{
			if (idparcela != 0) 
			{
				clonobjetos = new GameObject[objetosescena.Length];
				idobjeto = Random.Range (0, objetosescena.Length);
				clonobjetos [idobjeto] = Instantiate (objetosescena [idobjeto], new Vector3 (transform.position.x, objetosescena [idobjeto].transform.position.y, transform.position.z), objetosescena [idobjeto].transform.rotation);
				clonobjetos [idobjeto].transform.parent = transform;
				//Debug.Log (idobjeto+" De parcela "+idparcela+" El objeto es "+clonobjetos[idobjeto]);
			}

		} 
		else if (TipoDeObjeto == 1) 
		{
			
			if (idparcela != 0) 
			{
				clonEnemigos = new GameObject[Enemigosescena.Length];
				idobjeto = Random.Range (0, Enemigosescena.Length);
				clonEnemigos [idobjeto] = Instantiate (Enemigosescena [idobjeto], new Vector3 (transform.position.x, Enemigosescena [idobjeto].transform.position.y, transform.position.z), Enemigosescena [idobjeto].transform.rotation);
				clonEnemigos [idobjeto].transform.parent = transform;
				//Debug.Log (idobjeto+" De parcela "+idparcela+" El objeto es "+clonobjetos[idobjeto]);
			}
		}

		

	}



	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") 
		{
			
			//Debug.Log ("la parcela: " + idparcela + " Sera Destruida");

			movecalle.Parceladañada (idparcela);

			//Debug.Log ("Este objeto sera destruido en 5");

			Destroy (this.gameObject, 7f);
			Debug.Log ("entro");
		}
			
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
