using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveobsta1 : MonoBehaviour {
	
	int lol;

	Vector3 posinicial;
	// Use this for initialization
	void Start () 
	{
		posinicial=transform.position;
		
	}

	void OnCollisionStay (Collision col)
	{
		if(col.gameObject.tag == "Terreno")
		{
			
			//Debug.Log ("esta chocando");


				//Destroy(col.gameObject);
			Destroy(this.gameObject);
			//transform.Translate(0.9f, 0, 0);

		}

	}

	void OnTriggerStay(Collider other)
	{
		//Destroy (this.gameObject);
		//posactual=transform.position.y;
		//transform.Translate(0.9f, 0, 0);

	}

	
	// Update is called once per frame
	void Update () 
	{
		

		//transform.RotateAround (puntocentro, Vector3.right, 0.5f);

		//lol=Random.Range (1, 12);
		//transform.Translate (velocidadX, 0, 0);
		//Debug.Log (lol);
		//transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
	}
}
