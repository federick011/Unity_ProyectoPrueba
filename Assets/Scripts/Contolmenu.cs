using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Contolmenu : MonoBehaviour {


	public Lista_personajes Generador;
	Movecubo scriptpersonaje1;
	Rect RectArriba;
	Rect RectAbajo;
	Rect RectDerecha;
	Rect RectIzquierda;
	//Rect Rectrotar;
	Rect rectimage;
	public Image imagenrect;
	public Image imagenarriba;
	public Image imagenabajo;
	public Image imagederecha;
	public Image imageizquierda;
	//public Image imagerotar;

	//si es 0 mira a la z si es 1 mira a la x
	/*int pospersonaje;
	public void pospersonajefun(int pos)
	{
		if (pospersonaje == 1) 
		{
			pospersonaje = 0;
		} 
		else if (pospersonaje == 0) 
		{
			pospersonaje = 1;
		}
	}

	public void Cambiascena(string nombre)
	{
		

	}*/




	// Use this for initialization
	void Start () 
	{
		//llamamos al script del movecubo por medio de su prefab generado por el script Lista_personajes
		scriptpersonaje1=Generador.ClonPersonaje[Generador.idpuc].GetComponent<Movecubo>();


		RectArriba=new Rect(imagenarriba.transform.position.x-40, imagenarriba.transform.position.y-40, 80f, 80f);
		RectAbajo = new Rect (imagenabajo.transform.position.x-40, imagenabajo.transform.position.y-40, 80f, 80f);
		//RectDerecha = new Rect (imagederecha.transform.position.x-40, imagederecha.transform.position.y-40, 80f, 80f);
		//RectIzquierda = new Rect (imageizquierda.transform.position.x-40, imageizquierda.transform.position.y-40, 80f, 80f);

		rectimage=new Rect(imagenrect.transform.position.x, imagenrect.transform.position.y, 20, 20);
		//Rectrotar=new Rect (imagerotar.transform.position.x-40, imagerotar.transform.position.y-40, 80f, 80f);



	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
		if (Input.GetMouseButton(0)) 
		{

			//pulsacion = Camera.main.ScreenPointToRay (Input.mousePosition);
			imagenrect.transform.position = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			rectimage.position=new Vector2(Input.mousePosition.x, Input.mousePosition.y);



			//Debug.Log (rectimage.position.x + " Y: " + rectimage.position.y);

			//Debug.Log (Input.mousePosition.x + " Y: " + Input.mousePosition.y);


			//if (rectimage.Overlaps (RectArriba)) 
			//{
				scriptpersonaje1.moverArribaAbajo (1);
			//} 
			/*else if (rectimage.Overlaps (RectAbajo)) 
			{
				scriptpersonaje1.moverArribaAbajo (2);
			} 
			else 
			{
				scriptpersonaje1.moverArribaAbajo (0);
			}
			/*if (rectimage.Overlaps (RectDerecha)) 
			{
				scriptpersonaje1.moverArribaAbajo (3);
			}
			else if (rectimage.Overlaps (RectIzquierda)) 
			{
				scriptpersonaje1.moverArribaAbajo (4);
			}*/


		}
		else
		{
			imagenrect.transform.position = new Vector2 (-100, -100);
			scriptpersonaje1.moverArribaAbajo (0);
		}

	}
}
