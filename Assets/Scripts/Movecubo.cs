using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Movecubo : MonoBehaviour {

	//para nimacion
	//public GameObject personaje;
	//public AnimationClip animacion1;
	//public AnimationClip animacion2;
	Animation varparaanimar;
	//======================
	public int Contpuntaje;
	//public Movecalle calle;
	Vector3 posobj;	
	Vector3 posobj2;
	int contador;
	//float velocidadsalto=150.0f;
	//float alturasalto=5.0f;
	float posactual;
	//public Text texto;
	//string textopuntaje;
	int[] mover1=new int[2];
	public bool Esrigido=true;

	public GameObject Explosion;
	GameObject clonexplo;
	float TiempoReco=0;
	//0 nave, 1 tierra
	public int idTipopersonaje;
    //0 si esta en la izquierda y 1 si esta en la derecha
    int PosPerso=0;
	public float Saludperso=100;
	//esta funcion es para poder interactuar con los botones, y solo acepta un parametro :,v
	public void moverArribaAbajo(int mover)
	{
		//para cambiar scena
		//SceneManager.LoadScene ("scena2");
		mover1[0] = mover;

	}


	public int moverAryAbdev()
	{
		return mover1 [0];
	}

	float PosYinicial;
	// Use this for initialization
	void Start () 
	{
		PosYinicial=transform.position.y;
		//cargar una imagen
		//imagen.sprite= Resources.Load<Sprite>("Texturas/Textura_calle");

		//inicializamos las animaciones
		//varparaanimar=personaje.AddComponent<Animation>();
		//varparaanimar.AddClip (animacion1, "animacion1");
		//varparaanimar.AddClip (animacion2, "animacion2");
		//varparaanimar= gameObject.GetComponent<Animation>();


	}

	//esto detecta colisiones una vez por toque 
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag!="Bala" && col.gameObject.tag!="Objetos_mapa") 
		{
			if (Saludperso > 0) 
			{
				Saludperso -= 5f;
			}

			if (Saludperso ==0) 
			{
				transform.GetComponent<Rigidbody> ().isKinematic = false;
				Esrigido = false;
				//clonexplo=Instantiate (Explosion, transform.parent.position, transform.rotation);

			}
			if (col.gameObject.tag == "Bala_enemigo") 
			{
				//Debug.Log ("Tomalo");
			}

		}
        

		//destruye un objeto segun su nombre
		/*if(col.gameObject.name == "cubo (2)")
		{
			

			Debug.Log ("esta chocando");



		}*/

	}

	//detecta colisiones mantenidas
	void OnTriggerEnter (Collider col)
	{
        
        /*if(col.gameObject.name == "cubo (2)")
		{
			

			

		}
		if (col.gameObject.name != "cubo" && col.gameObject.name != "Terrain") 
		{
			transform.Translate(0.9f, 0, 0);
		}*/
    }
		
	void moverperso()
	{
		if (idTipopersonaje == 0) 
		{

			
				if (Esrigido == true)
                {
					transform.Translate (0, 0, 0.4f);
                    //transform.GetComponent<Rigidbody>().AddForce(Vector3.up * 100);

				}
                else
                {
					//transform.position=new Vector3(475, transform.position.y, transform.position.z);
					if (TiempoReco < 1f)
                    {
						TiempoReco = TiempoReco + Time.deltaTime;
						transform.Translate (0, 0, 0.4f);
					}
                    //else if (TiempoReco > 0.9f)
                    //{
						//Debug.Log (TiempoReco);
						/*//=========Script de explosion=========
					Collider[] colliders = Physics.OverlapSphere (transform.position, 10f);

					foreach (Collider nearbyObject in colliders) 
					{
						Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
						if (rb != null) 
						{
							rb.AddExplosionForce (700f, transform.position, 10f);
						}
					}*/


						//======explosion fin===========
					//}
					//else if (TiempoReco > 60.0f) 
					//{
					//	TiempoReco = -1;
					//}

				}
				//varparaanimar.Play(animation:"Armature|Animacion_Correr");
			

			
            //para mover al personaje de un lado a otro
            if (transform.position.x < 476)
            {
                PosPerso = 1;
            }
            else if(transform.position.x > 494)
            {
                PosPerso = 0;
            }
			if (mover1 [0] == 1 && Esrigido == true)
            {
				if (PosPerso==0)
                {
					transform.Translate (-0.4f, 0, 0);

				}
                else if(PosPerso==1)
                {
                    transform.Translate(0.4f, 0, 0);
                }
         
			}

            /*else if (mover1 [0] < 1)
            {
				if (transform.position.x > PosYinicial && Esrigido == true)
                {
					

				}

			}*/
		}
		else if (idTipopersonaje == 1) 
		{

			/*if (transform.position.z < 800.1f) 
			{
				if (Esrigido == true)
				{
					transform.Translate (0, 0, 0.4f);

				}
				else
				{
					//transform.position=new Vector3(475, transform.position.y, transform.position.z);
					if (TiempoReco < 1f) 
					{
						TiempoReco=TiempoReco+Time.deltaTime;
						transform.Translate (0, 0, 0.4f);
					}
					/*else if (TiempoReco > 0.9f) 
					{
						//Debug.Log (TiempoReco);
						//=========Script de explosion=========
					Collider[] colliders = Physics.OverlapSphere (transform.position, 10f);

					foreach (Collider nearbyObject in colliders) 
					{
						Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
						if (rb != null) 
						{
							rb.AddExplosionForce (700f, transform.position, 10f);
						}
					}


						//======explosion fin===========
					}*/
					//else if (TiempoReco > 60.0f) 
					//{
					//	TiempoReco = -1;
					//}

				//}
				//varparaanimar.Play(animation:"Armature|Animacion_Correr");
			//}
			/*if (transform.position.z > 799.9f) 
			{
				transform.position=new Vector3(475, transform.position.y, transform.position.z-600);
			}
			if(mover1[0]==1 && Esrigido==true)
			{
				
			}
			else if (mover1 [0] < 1) 
			{

			}*/
		}
	}


	// Update is called once per frame
	void Update ()
	{
        Debug.Log(transform.rotation);
		//Debug.Log (Saludperso);
		//transform.position=new Vector3(475, transform.position.y, transform.position.z);
		if (Saludperso < 0) {
			Saludperso = 0;
		}

		moverperso ();
	}

}
