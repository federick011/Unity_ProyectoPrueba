using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_explosiones : MonoBehaviour {

	public int IdExplosion;
	// Use this for initialization
	void Start () 
	{
		switch (IdExplosion) 
		{
		case 0:
			Destroy (this.gameObject, 2f);
			break;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
