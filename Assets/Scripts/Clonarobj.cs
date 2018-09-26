using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clonarobj : MonoBehaviour {

	public GameObject eje2;
	GameObject clone;
	// Use this for initialization
	void Start () {

		for (int i = 0; i <= 1; i++) 
		{
			clone=Instantiate(eje2, new Vector3(4, 4, 4), Quaternion.identity);
			//clone.AddComponent<Rigidbody>();
			//clone.AddComponent<CapsuleCollider> ();


			//destruye un objeto a un tiempo determinado ej: 10f :v
			//Destroy (clone, 10f);
		}


	}


	// Update is called once per frame
	void Update () {
		
	}
}
